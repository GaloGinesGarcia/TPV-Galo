using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TPV_Galo
{
    public partial class HisotrialForm : Form
    {
        public HisotrialForm()
        {
            InitializeComponent();
            configurarGrids();
            
        }

        private void configurarGrids()
        {
            dgvHistorial.DataSource = Ventas.SalesRepository.Sales;
            dgvHistorial.AutoGenerateColumns = true;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHistorial.CurrentRow == null) return;

            Ventas ventas = dgvHistorial.CurrentRow.DataBoundItem as Ventas;

            if (ventas == null) return;

            string ticket = generarTicketDesdeVenta(ventas);

            richHistorial.Text = ticket;

        }
        private string generarTicketDesdeVenta(Ventas ventas)
        {
            string ticket = "";

            ticket += "##############################\n";
            ticket += "         TPV GALO\n";
            ticket += "##############################\n\n";

            ticket += $"Fecha: {ventas.Date:dd/MM/yyyy HH:mm}\n\n";

            ticket += "Producto    Cant    Precio    Total\n";
            ticket += "=================================\n";

            foreach (var item in ventas.Items)
            {
                ticket +=
                    $"{item.Product.Name,-12}" +
                    $"{item.quantity,-8}" +
                    $"{item.Product.Price,-10:0.00}" +
                    $"{item.totalPrice:0.00}\n";
            }

            ticket += "=================================\n\n";
            ticket += $"TOTAL: {ventas.Total:0.00} €\n";
            ticket += $"Pago: {ventas.MetodoPago}\n";

            return ticket;
        }

        private void btnVolverHistorial_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
