namespace TPV_Galo
{
    partial class HisotrialForm
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
            dgvHistorial = new DataGridView();
            richHistorial = new RichTextBox();
            btnVolverHistorial = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AllowUserToResizeColumns = false;
            dgvHistorial.AllowUserToResizeRows = false;
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(73, 141);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.Size = new Size(344, 314);
            dgvHistorial.TabIndex = 0;
            dgvHistorial.CellContentClick += dgvHistorial_CellContentClick;
            // 
            // richHistorial
            // 
            richHistorial.Location = new Point(506, 141);
            richHistorial.Name = "richHistorial";
            richHistorial.Size = new Size(354, 314);
            richHistorial.TabIndex = 1;
            richHistorial.Text = "";
            // 
            // btnVolverHistorial
            // 
            btnVolverHistorial.BackColor = Color.FromArgb(128, 128, 255);
            btnVolverHistorial.Font = new Font("Segoe UI", 10F);
            btnVolverHistorial.Location = new Point(73, 62);
            btnVolverHistorial.Name = "btnVolverHistorial";
            btnVolverHistorial.Size = new Size(98, 36);
            btnVolverHistorial.TabIndex = 2;
            btnVolverHistorial.Text = "Volver";
            btnVolverHistorial.UseVisualStyleBackColor = false;
            btnVolverHistorial.Click += btnVolverHistorial_Click;
            // 
            // HisotrialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 566);
            Controls.Add(btnVolverHistorial);
            Controls.Add(richHistorial);
            Controls.Add(dgvHistorial);
            Name = "HisotrialForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HisotrialForm";
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistorial;
        private RichTextBox richHistorial;
        private Button btnVolverHistorial;
    }
}