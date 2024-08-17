namespace PruebaForms.Interfaz
{
    partial class datosClientes
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
            dgvClientes = new DataGridView();
            lblClientes = new Label();
            btnResumen = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 63);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(722, 228);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientes.Location = new Point(269, 9);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(182, 30);
            lblClientes.TabIndex = 1;
            lblClientes.Text = "Datos de Clientes";
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(12, 297);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(130, 23);
            btnResumen.TabIndex = 2;
            btnResumen.Text = "Resumen de Cuenta";
            btnResumen.UseVisualStyleBackColor = true;
            // 
            // datosClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(746, 332);
            Controls.Add(btnResumen);
            Controls.Add(lblClientes);
            Controls.Add(dgvClientes);
            Name = "datosClientes";
            Text = "Datos de Clientes";
            Load += datosClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private Label lblClientes;
        private Button btnResumen;
    }
}