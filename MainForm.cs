using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static TPV_Galo.Ventas;

namespace TPV_Galo{

    public partial class MainForm : Form
    {

        public static BindingList<Product> products = new BindingList<Product>();
        BindingList<CartItem> cart = new BindingList<CartItem>();

        private MetodoPago metodoPagoSeleccionado;
        private List<Product> productosBase;
        public MainForm()
        {
            InitializeComponent();
            gridConfiguration();

        }

        // ================= CART GRID =================

        private void gridConfiguration()
        {

            dgvCart.AutoGenerateColumns = false;
            dgvCart.Columns.Clear();

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "productName",
                HeaderText = "Producto",
                Name = "colProducto"
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "quantity",
                HeaderText = "Cantidad",
                Name = "colCantidad"
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "totalPrice",
                HeaderText = "Importe",
                Name = "colImporte"
            });


            // Elimina la flecha de la izquierda de los grids y sus ediciones en producción
            dgvCart.RowHeadersVisible = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.DataSource = ProductsRepository.Products;
            dgvCart.DataSource = cart;

            // Para el buscador
            productosBase = ProductsRepository.Products.ToList();
            dgvProducts.DataSource = productosBase;
        }

        // ================= ADD =================

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            Product p = dgvProducts.CurrentRow.DataBoundItem as Product;

            if (p == null) return;

            if (p.stock <= 0)
            {
                MessageBox.Show("No hay stock disponible");
                return;
            }

            CartItem existing = cart.FirstOrDefault(c => c.Product.Id == p.Id);

            if (existing != null)
            {
                existing.quantity++;
            }
            else
            {
                cart.Add(new CartItem
                {
                    Product = p,
                    quantity = 1
                });
            }

            p.stock--;

            dgvCart.Refresh();
            dgvProducts.Refresh();
            updateTotal();
        }

        // ================= REMOVE ============================

        private void btnRemoveToCart_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null) return;

            CartItem item = dgvCart.CurrentRow.DataBoundItem as CartItem;
            if (item == null) return;

            item.quantity--;
            item.Product.stock++;

            if (item.quantity <= 0)
            {
                cart.Remove(item);
            }


            dgvCart.Refresh();
            dgvProducts.Refresh();
            updateTotal();
        }

        // ================= TOTAL =======================

        private void updateTotal()
        {

            decimal total = 0;

            foreach (var item in cart)
                total += item.totalPrice;

            labelTotal.Text = "Total: " + total + " €";
        }

        // ================= OPEN PRODUCTS ADMIN LANDING =================

        private void btnAdminProducts_Click(object sender, EventArgs e)
        {
            this.Hide();

            ProductsForm form = new ProductsForm();

            form.FormClosed += (s, args) =>
            {
                // Recargar el grid de productos despues de añadir productos en admin
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = ProductsRepository.Products;
                this.Show(); // Aquí recuperas MainForm
            };

            form.Show();

        }

        // ================= FINISH SELL =====================
        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            if (cart.Count <= 0)
            {
                return;
            }

            ModalPaymentScreen modal = new ModalPaymentScreen();

            if (modal.ShowDialog() == DialogResult.OK)
            {
                MetodoPago metodo = modal.MetodoSeleccionado;

                // Para el historial de las ventas
                Ventas venta = new Ventas { Date = DateTime.Now, Items = cart.ToList(), Total = cart.Sum(x => x.totalPrice), MetodoPago = modal.MetodoSeleccionado };
                Ventas.SalesRepository.Sales.Add(venta);

                MessageBox.Show("Pago realizado mediante: " + metodo);

                richTextBoxTicket.Text = generarTicket();

                updateTotal();
                cart.Clear();
                dgvCart.Refresh();

            }



        }

        // =============== METOTH TICKET GENERATOR ================
        public string generarTicket()
        {
            richTextBoxTicket.Clear();
            // ENCABEZADO DEL TICKET
            string ticket = "";

            ticket += "##########################################\n";
            ticket += "         TPV GALO\n";
            ticket += "##########################################\n\n";

            ticket += "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\n\n";

            ticket += "===============================================\n";
            ticket += "Producto    Cant      Precio      Total\n";
            ticket += "===============================================\n";

            // LOGICA DEL TICKET

            for (int i = 0; i < cart.Count; i++)
            {
                var productosEnCarrito = cart[i];

                string nombre = productosEnCarrito.Product.Name.PadRight(12);
                string cantidad = productosEnCarrito.quantity.ToString().PadRight(12);
                string precio = productosEnCarrito.Product.Price.ToString().PadRight(12);
                string total = productosEnCarrito.totalPrice.ToString("0.00");

                ticket += nombre + cantidad + precio + total + "\n";
            }

            ticket += "=============================================\n\n";

            decimal totalFinal = cart.Sum(x => x.totalPrice);

            ticket += "TOTAL: " + totalFinal.ToString("0.00") + " €\n\n";


            ticket += "Método de pago: " + metodoPagoSeleccionado + "\n\n";

            ticket += "##########################################\n";
            ticket += "         GRACIAS POR SU COMPRA\n";
            ticket += "##########################################\n";

            return ticket;
        }

        // ==================== PRODUCTS SEARCH =========================
        private void campoBuscarProductoMain_TextChanged(object sender, EventArgs e)
        {

            string texto = campoBuscarProductoMain.Text.ToLower();

            if (string.IsNullOrWhiteSpace(texto))
            {
                dgvProducts.DataSource = productosBase;
                return;
            }

            var filtrados = productosBase.Where(p => p.Name.ToLower().Contains(texto)).ToList();

            dgvProducts.DataSource = filtrados;
        }

        // ===================== OPEN HISTORY WINDOWS =====================
        private void btnHistorialVentas_Click(object sender, EventArgs e)
        {
            this.Hide();

            HisotrialForm form = new HisotrialForm();

            // Sirve para que el main se oculte y la nueva ventana se vea, y desde la nueva ventana poder volver.
            form.FormClosed += (s, args) =>
            {
                this.Show();
            };

            form.Show();
        }

        // ========================= CLOSE DAY ===============================
        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            var ventasHoy = SalesRepository.Sales.Where(v => v.Date.Date == DateTime.Now.Date).ToList();
            decimal total = ventasHoy.Sum(v => v.Total);
            int numVentas = ventasHoy.Count;

            MessageBox.Show(
                $"VENTAS HOY\n\n" +
                $"Ventas: {numVentas}\n" +
                $"Total: {total:0.00} €"
            );
        }

        //======================== EXPORT TICKET ============================
        private void btnExportarTicket_Click(object sender, EventArgs e)
        {
            var venta = Ventas.SalesRepository.Sales.LastOrDefault();

            if (venta == null) return;
            exportarTicket(venta);
            MessageBox.Show("Ticket exportado en el escritorio");
        }
        private void exportarTicket(Ventas venta)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string ticket = generarTicket();

            File.WriteAllText(Path.Combine(path, $"ticket_{venta.Date:yyyyMMdd_HHmm}.txt"), ticket);
        }



        //======================== EXPORT DAY ===============================

        private void exportarCaja()
        {

        }

        
    }
}
