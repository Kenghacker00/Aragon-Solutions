namespace GestorDeVenta
{
    partial class FormLaptopsManager
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
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            dgvLaptops = new DataGridView();
            btnBuscarLaptop = new Button();
            txtBuscarLaptop = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLaptops).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(307, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(145, 40);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Laptops";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(609, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(154, 40);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar Laptops";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(458, 12);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(145, 40);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar Laptops";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // dgvLaptops
            // 
            dgvLaptops.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaptops.Location = new Point(12, 118);
            dgvLaptops.Name = "dgvLaptops";
            dgvLaptops.RowHeadersWidth = 51;
            dgvLaptops.Size = new Size(776, 320);
            dgvLaptops.TabIndex = 3;
            // 
            // btnBuscarLaptop
            // 
            btnBuscarLaptop.Location = new Point(171, 67);
            btnBuscarLaptop.Name = "btnBuscarLaptop";
            btnBuscarLaptop.Size = new Size(76, 27);
            btnBuscarLaptop.TabIndex = 4;
            btnBuscarLaptop.Text = "Buscar";
            btnBuscarLaptop.UseVisualStyleBackColor = true;
            btnBuscarLaptop.Click += btnBuscarLaptop_Click;
            // 
            // txtBuscarLaptop
            // 
            txtBuscarLaptop.Location = new Point(32, 67);
            txtBuscarLaptop.Name = "txtBuscarLaptop";
            txtBuscarLaptop.PlaceholderText = "Busca una laptop...";
            txtBuscarLaptop.Size = new Size(133, 27);
            txtBuscarLaptop.TabIndex = 5;
            // 
            // FormLaptopsManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBuscarLaptop);
            Controls.Add(btnBuscarLaptop);
            Controls.Add(dgvLaptops);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Name = "FormLaptopsManager";
            Text = "Sistema de laptops";
            ((System.ComponentModel.ISupportInitialize)dgvLaptops).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private DataGridView dgvLaptops;
        private Button btnBuscarLaptop;
        private TextBox txtBuscarLaptop;
    }
}