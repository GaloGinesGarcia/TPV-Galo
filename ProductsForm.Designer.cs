namespace TPV_Galo
{
    partial class ProductsForm
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
            dgvProductsAdmin = new DataGridView();
            btnReturnProductsForm = new Button();
            campoNombreProductsForm = new TextBox();
            campoPrecioProductsForm = new TextBox();
            btnAgregarProductsForm = new Button();
            btnEditarProductsForm = new Button();
            btnEliminarProductsForm = new Button();
            labelNombreProductsForm = new Label();
            labelPrecioProductsForm = new Label();
            btnResetearProductsForm = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductsAdmin).BeginInit();
            SuspendLayout();
            // 
            // dgvProductsAdmin
            // 
            dgvProductsAdmin.AllowUserToAddRows = false;
            dgvProductsAdmin.AllowUserToDeleteRows = false;
            dgvProductsAdmin.AllowUserToResizeColumns = false;
            dgvProductsAdmin.AllowUserToResizeRows = false;
            dgvProductsAdmin.BackgroundColor = Color.White;
            dgvProductsAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductsAdmin.Location = new Point(517, 118);
            dgvProductsAdmin.Name = "dgvProductsAdmin";
            dgvProductsAdmin.Size = new Size(512, 475);
            dgvProductsAdmin.TabIndex = 0;
            // 
            // btnReturnProductsForm
            // 
            btnReturnProductsForm.BackColor = Color.FromArgb(255, 255, 128);
            btnReturnProductsForm.Font = new Font("Segoe UI", 10F);
            btnReturnProductsForm.Location = new Point(385, 148);
            btnReturnProductsForm.Name = "btnReturnProductsForm";
            btnReturnProductsForm.Size = new Size(95, 34);
            btnReturnProductsForm.TabIndex = 1;
            btnReturnProductsForm.Text = "Volver";
            btnReturnProductsForm.UseVisualStyleBackColor = false;
            btnReturnProductsForm.Click += btnReturnProductsForm_Click;
            // 
            // campoNombreProductsForm
            // 
            campoNombreProductsForm.Location = new Point(619, 81);
            campoNombreProductsForm.Name = "campoNombreProductsForm";
            campoNombreProductsForm.Size = new Size(177, 23);
            campoNombreProductsForm.TabIndex = 2;
            campoNombreProductsForm.TextChanged += campoNombreProductsForm_TextChanged;
            // 
            // campoPrecioProductsForm
            // 
            campoPrecioProductsForm.Location = new Point(842, 81);
            campoPrecioProductsForm.Name = "campoPrecioProductsForm";
            campoPrecioProductsForm.Size = new Size(71, 23);
            campoPrecioProductsForm.TabIndex = 3;
            // 
            // btnAgregarProductsForm
            // 
            btnAgregarProductsForm.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregarProductsForm.Font = new Font("Segoe UI", 10F);
            btnAgregarProductsForm.Location = new Point(1074, 81);
            btnAgregarProductsForm.Name = "btnAgregarProductsForm";
            btnAgregarProductsForm.Size = new Size(98, 31);
            btnAgregarProductsForm.TabIndex = 4;
            btnAgregarProductsForm.Text = "Agregar";
            btnAgregarProductsForm.UseVisualStyleBackColor = false;
            btnAgregarProductsForm.Click += btnAgregarProductsForm_Click;
            // 
            // btnEditarProductsForm
            // 
            btnEditarProductsForm.BackColor = Color.FromArgb(255, 255, 128);
            btnEditarProductsForm.Font = new Font("Segoe UI", 10F);
            btnEditarProductsForm.Location = new Point(1074, 137);
            btnEditarProductsForm.Name = "btnEditarProductsForm";
            btnEditarProductsForm.Size = new Size(98, 31);
            btnEditarProductsForm.TabIndex = 5;
            btnEditarProductsForm.Text = "Editar";
            btnEditarProductsForm.UseVisualStyleBackColor = false;
            btnEditarProductsForm.Click += btnEditarProductsForm_Click;
            // 
            // btnEliminarProductsForm
            // 
            btnEliminarProductsForm.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminarProductsForm.Font = new Font("Segoe UI", 10F);
            btnEliminarProductsForm.Location = new Point(1074, 195);
            btnEliminarProductsForm.Name = "btnEliminarProductsForm";
            btnEliminarProductsForm.Size = new Size(98, 31);
            btnEliminarProductsForm.TabIndex = 6;
            btnEliminarProductsForm.Text = "Eliminar";
            btnEliminarProductsForm.UseVisualStyleBackColor = false;
            btnEliminarProductsForm.Click += btnEliminarProductsForm_Click;
            // 
            // labelNombreProductsForm
            // 
            labelNombreProductsForm.AutoSize = true;
            labelNombreProductsForm.Font = new Font("Segoe UI", 10F);
            labelNombreProductsForm.Location = new Point(640, 52);
            labelNombreProductsForm.Name = "labelNombreProductsForm";
            labelNombreProductsForm.Size = new Size(138, 19);
            labelNombreProductsForm.TabIndex = 7;
            labelNombreProductsForm.Text = "Nombre de producto";
            // 
            // labelPrecioProductsForm
            // 
            labelPrecioProductsForm.AutoSize = true;
            labelPrecioProductsForm.Font = new Font("Segoe UI", 10F);
            labelPrecioProductsForm.Location = new Point(823, 52);
            labelPrecioProductsForm.Name = "labelPrecioProductsForm";
            labelPrecioProductsForm.Size = new Size(125, 19);
            labelPrecioProductsForm.TabIndex = 8;
            labelPrecioProductsForm.Text = "Precio de producto";
            // 
            // btnResetearProductsForm
            // 
            btnResetearProductsForm.BackColor = Color.FromArgb(128, 128, 255);
            btnResetearProductsForm.Font = new Font("Segoe UI", 10F);
            btnResetearProductsForm.Location = new Point(1074, 253);
            btnResetearProductsForm.Name = "btnResetearProductsForm";
            btnResetearProductsForm.Size = new Size(98, 31);
            btnResetearProductsForm.TabIndex = 9;
            btnResetearProductsForm.Text = "Cargar Stock";
            btnResetearProductsForm.UseVisualStyleBackColor = false;
            btnResetearProductsForm.Click += btnResetearProductsForm_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1538, 623);
            Controls.Add(btnResetearProductsForm);
            Controls.Add(labelPrecioProductsForm);
            Controls.Add(labelNombreProductsForm);
            Controls.Add(btnEliminarProductsForm);
            Controls.Add(btnEditarProductsForm);
            Controls.Add(btnAgregarProductsForm);
            Controls.Add(campoPrecioProductsForm);
            Controls.Add(campoNombreProductsForm);
            Controls.Add(btnReturnProductsForm);
            Controls.Add(dgvProductsAdmin);
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)dgvProductsAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductsAdmin;
        private Button btnReturnProductsForm;
        private TextBox campoNombreProductsForm;
        private TextBox campoPrecioProductsForm;
        private Button btnAgregarProductsForm;
        private Button btnEditarProductsForm;
        private Button btnEliminarProductsForm;
        private Label labelNombreProductsForm;
        private Label labelPrecioProductsForm;
        private Button btnResetearProductsForm;
    }
}