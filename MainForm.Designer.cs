namespace TPV_Galo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            dgvCart = new DataGridView();
            labelTotal = new Label();
            btnAddToCart = new Button();
            btnRemoveToCart = new Button();
            btnAdminProducts = new Button();
            btnFinalizarVenta = new Button();
            richTextBoxTicket = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(92, 70);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(406, 326);
            dgvProducts.TabIndex = 0;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToResizeColumns = false;
            dgvCart.AllowUserToResizeRows = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.White;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(1010, 70);
            dgvCart.Name = "dgvCart";
            dgvCart.Size = new Size(407, 326);
            dgvCart.TabIndex = 1;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(1311, 491);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(96, 30);
            labelTotal.TabIndex = 2;
            labelTotal.Text = "Total: 0 €";
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.FromArgb(128, 255, 128);
            btnAddToCart.Font = new Font("Segoe UI", 10F);
            btnAddToCart.Location = new Point(529, 70);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(120, 51);
            btnAddToCart.TabIndex = 3;
            btnAddToCart.Text = "Añadir al carrito";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnRemoveToCart
            // 
            btnRemoveToCart.BackColor = Color.FromArgb(255, 128, 128);
            btnRemoveToCart.Font = new Font("Segoe UI", 10F);
            btnRemoveToCart.Location = new Point(855, 70);
            btnRemoveToCart.Name = "btnRemoveToCart";
            btnRemoveToCart.Size = new Size(128, 51);
            btnRemoveToCart.TabIndex = 4;
            btnRemoveToCart.Text = "Quitar del carrito";
            btnRemoveToCart.UseVisualStyleBackColor = false;
            btnRemoveToCart.Click += btnRemoveToCart_Click;
            // 
            // btnAdminProducts
            // 
            btnAdminProducts.BackColor = Color.FromArgb(255, 255, 128);
            btnAdminProducts.Font = new Font("Segoe UI", 10F);
            btnAdminProducts.Location = new Point(529, 138);
            btnAdminProducts.Name = "btnAdminProducts";
            btnAdminProducts.Size = new Size(120, 47);
            btnAdminProducts.TabIndex = 5;
            btnAdminProducts.Text = "Administradior de productos";
            btnAdminProducts.UseVisualStyleBackColor = false;
            btnAdminProducts.Click += btnAdminProducts_Click;
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.BackColor = Color.FromArgb(128, 255, 128);
            btnFinalizarVenta.Font = new Font("Segoe UI", 10F);
            btnFinalizarVenta.Location = new Point(1289, 415);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(128, 51);
            btnFinalizarVenta.TabIndex = 6;
            btnFinalizarVenta.Text = "Finalizar venta";
            btnFinalizarVenta.UseVisualStyleBackColor = false;
            btnFinalizarVenta.Click += btnFinalizarVenta_Click;
            // 
            // richTextBoxTicket
            // 
            richTextBoxTicket.BackColor = Color.White;
            richTextBoxTicket.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxTicket.Location = new Point(561, 207);
            richTextBoxTicket.Name = "richTextBoxTicket";
            richTextBoxTicket.ReadOnly = true;
            richTextBoxTicket.Size = new Size(407, 376);
            richTextBoxTicket.TabIndex = 7;
            richTextBoxTicket.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 820);
            Controls.Add(richTextBoxTicket);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(btnAdminProducts);
            Controls.Add(btnRemoveToCart);
            Controls.Add(btnAddToCart);
            Controls.Add(labelTotal);
            Controls.Add(dgvCart);
            Controls.Add(dgvProducts);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private DataGridView dgvProducts;
        private DataGridView dgvCart;
        private Label labelTotal;
        private Button btnAddToCart;
        private Button btnRemoveToCart;
        private Button btnAdminProducts;
        private Button btnFinalizarVenta;
        private RichTextBox richTextBoxTicket;
    }
}
