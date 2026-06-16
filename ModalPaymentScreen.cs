using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TPV_Galo
{
    public partial class ModalPaymentScreen : Form
    {
        public MetodoPago MetodoSeleccionado { get; private set; }
        public ModalPaymentScreen()
        {
            InitializeComponent();
        }

        

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            MetodoSeleccionado = MetodoPago.Efectivo;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            MetodoSeleccionado = MetodoPago.Tarjeta;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
