namespace TPV_Galo
{
    partial class ModalPaymentScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTarjeta = new Button();
            btnEfectivo = new Button();
            SuspendLayout();
            // 
            // btnTarjeta
            // 
            btnTarjeta.BackColor = Color.FromArgb(128, 128, 255);
            btnTarjeta.Font = new Font("Segoe UI", 10F);
            btnTarjeta.Location = new Point(242, 59);
            btnTarjeta.Name = "btnTarjeta";
            btnTarjeta.Size = new Size(92, 34);
            btnTarjeta.TabIndex = 0;
            btnTarjeta.Text = "Tarjeta";
            btnTarjeta.UseVisualStyleBackColor = false;
            btnTarjeta.Click += btnTarjeta_Click;
            // 
            // btnEfectivo
            // 
            btnEfectivo.BackColor = Color.FromArgb(128, 128, 255);
            btnEfectivo.Font = new Font("Segoe UI", 10F);
            btnEfectivo.Location = new Point(85, 59);
            btnEfectivo.Name = "btnEfectivo";
            btnEfectivo.Size = new Size(92, 34);
            btnEfectivo.TabIndex = 1;
            btnEfectivo.Text = "Efectivo";
            btnEfectivo.UseVisualStyleBackColor = false;
            btnEfectivo.Click += btnEfectivo_Click;
            // 
            // ModalPaymentScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 162);
            Controls.Add(btnEfectivo);
            Controls.Add(btnTarjeta);
            Name = "ModalPaymentScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModalPaymentScreen";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTarjeta;
        private Button btnEfectivo;
    }
}