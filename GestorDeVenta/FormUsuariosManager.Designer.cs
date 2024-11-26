namespace GestorDeVenta
{
    partial class FormUsuariosManager
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
            btnBuscar = new Button();
            btnEliminar = new Button();
            dgvUsuarios = new DataGridView();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(195, 45);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(67, 27);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar Usuarios";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(594, 36);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(148, 36);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar Usuario";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 104);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(776, 334);
            dgvUsuarios.TabIndex = 2;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(53, 45);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Busca un usuario...";
            txtBuscar.Size = new Size(136, 27);
            txtBuscar.TabIndex = 3;
            // 
            // FormUsuariosManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBuscar);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Name = "FormUsuariosManager";
            Text = "Sistema de usuarios";
            Load += FormUsuariosManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnEliminar;
        private DataGridView dgvUsuarios;
        private TextBox txtBuscar;
    }
}