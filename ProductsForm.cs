using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TPV_Galo
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            dvgConfiguration();
        }
        private void dvgConfiguration()
        {
            dgvProductsAdmin.RowHeadersVisible = false;
            dgvProductsAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductsAdmin.AllowUserToAddRows = false;
            dgvProductsAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductsAdmin.DataSource = ProductsRepository.Products;
        }
        //================= BUTTONS =================
        private void btnReturnProductsForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAgregarProductsForm_Click(object sender, EventArgs e)
        {
            //Id = ProductsRepository.Products.Count + 1 (Se puede hacer esto, pero mejor el de abajo para evitar duplicados)
            if(string.IsNullOrEmpty(campoNombreProductsForm.Text) || string.IsNullOrEmpty(campoPrecioProductsForm.Text)) {
                MessageBox.Show("Debes rellenar todos los campos con Nombre y Precio en formato correcto.");
                return;
            }
            decimal precio;
            if (!decimal.TryParse(campoPrecioProductsForm.Text, out precio))
            {
                MessageBox.Show("El precio debe ser un numero decimal");
                return;
            }
            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que 0.");
                return;
            }
            ProductsRepository.Products.Add(new Product { Id = ProductsRepository.Products.Max(p => p.Id) + 1, Name = campoNombreProductsForm.Text, Price = decimal.Parse(campoPrecioProductsForm.Text)});
        }
        


        private void btnEditarProductsForm_Click(object sender, EventArgs e)
        {
            if (dgvProductsAdmin.CurrentRow == null)
            {
                return;
            }
            
            
                
                Product selected = dgvProductsAdmin.CurrentRow.DataBoundItem as Product;
                if(selected == null)
                {
                    return;
                }
                if (string.IsNullOrWhiteSpace(campoNombreProductsForm.Text) || string.IsNullOrWhiteSpace(campoPrecioProductsForm.Text))
                {
                    MessageBox.Show("Debes rellenar todos los campos con Nombre y Precio en formato correcto.");
                    return;
                }
                decimal precio;
                if (!decimal.TryParse(campoPrecioProductsForm.Text, out precio))
                {
                    MessageBox.Show("El precio debe ser un número decimal.");
                    return;
                }
            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que 0.");
                return;
            }
            selected.Name = campoNombreProductsForm.Text;
            selected.Price = decimal.Parse(campoPrecioProductsForm.Text);
            dgvProductsAdmin.Refresh();
                
            
        }

        private void btnEliminarProductsForm_Click(object sender, EventArgs e)
        {
            if (dgvProductsAdmin.CurrentRow == null)
            {
                return;
            }
            else
            {
                Product selected = dgvProductsAdmin.CurrentRow.DataBoundItem as Product;
                if (selected != null)
                {
                    ProductsRepository.Products.Remove(selected);
                }
            }
        }
        //================= DATAGRIDVIEW PRODUCTS CHARGED =================
        private void dgvProductsAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
