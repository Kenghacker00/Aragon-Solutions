namespace GestorDeVenta
{
    partial class Carrito
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
            listBoxCarrito = new ListBox();
            btnEliminar = new Button();
            pictureBoxLaptop = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLaptop).BeginInit();
            SuspendLayout();
            // 
            // listBoxCarrito
            // 
            listBoxCarrito.FormattingEnabled = true;
            listBoxCarrito.Location = new Point(236, 26);
            listBoxCarrito.Name = "listBoxCarrito";
            listBoxCarrito.Size = new Size(150, 64);
            listBoxCarrito.TabIndex = 0;
            listBoxCarrito.SelectedIndexChanged += ListBoxCarrito_SelectedIndexChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(429, 43);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pictureBoxLaptop
            // 
            pictureBoxLaptop.Location = new Point(212, 142);
            pictureBoxLaptop.Name = "pictureBoxLaptop";
            pictureBoxLaptop.Size = new Size(333, 265);
            pictureBoxLaptop.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLaptop.TabIndex = 2;
            pictureBoxLaptop.TabStop = false;
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxLaptop);
            Controls.Add(btnEliminar);
            Controls.Add(listBoxCarrito);
            Name = "Carrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carrito";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLaptop).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxCarrito;
        private Button btnEliminar;
        private PictureBox pictureBoxLaptop;
    }
}