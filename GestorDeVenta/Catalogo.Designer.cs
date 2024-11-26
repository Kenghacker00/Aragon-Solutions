namespace GestorDeVenta
{
    partial class Catalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
            panel1 = new Panel();
            atras = new PictureBox();
            salir = new PictureBox();
            txtBuscador = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pbbBuscar = new PictureBox();
            pbBuscar = new PictureBox();
            panel3 = new Panel();
            btnComprar = new Button();
            txtCantidadCarrito = new Label();
            pbCarrito = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)atras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbbBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBuscar).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCarrito).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(atras);
            panel1.Controls.Add(salir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1251, 35);
            panel1.TabIndex = 0;
            // 
            // atras
            // 
            atras.Image = (Image)resources.GetObject("atras.Image");
            atras.Location = new Point(11, -4);
            atras.Name = "atras";
            atras.Size = new Size(27, 43);
            atras.SizeMode = PictureBoxSizeMode.Zoom;
            atras.TabIndex = 15;
            atras.TabStop = false;
            // 
            // salir
            // 
            salir.Image = (Image)resources.GetObject("salir.Image");
            salir.Location = new Point(1216, -4);
            salir.Name = "salir";
            salir.Size = new Size(27, 43);
            salir.SizeMode = PictureBoxSizeMode.Zoom;
            salir.TabIndex = 14;
            salir.TabStop = false;
            salir.Click += salir_Click;
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(372, 11);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(534, 27);
            txtBuscador.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(163, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pbbBuscar);
            panel2.Controls.Add(pbBuscar);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(txtBuscador);
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(1251, 51);
            panel2.TabIndex = 3;
            // 
            // pbbBuscar
            // 
            pbbBuscar.BackColor = SystemColors.HighlightText;
            pbbBuscar.Image = (Image)resources.GetObject("pbbBuscar.Image");
            pbbBuscar.Location = new Point(912, 14);
            pbbBuscar.Name = "pbbBuscar";
            pbbBuscar.Size = new Size(28, 22);
            pbbBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            pbbBuscar.TabIndex = 4;
            pbbBuscar.TabStop = false;
            pbbBuscar.Click += pbbBuscar_Click;
            pbbBuscar.MouseEnter += pbBuscar_MouseEnter;
            pbbBuscar.MouseLeave += pbBuscar_MouseLeave;
            // 
            // pbBuscar
            // 
            pbBuscar.BackColor = SystemColors.HighlightText;
            pbBuscar.BorderStyle = BorderStyle.FixedSingle;
            pbBuscar.Location = new Point(902, 11);
            pbBuscar.Name = "pbBuscar";
            pbBuscar.Size = new Size(47, 27);
            pbBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            pbBuscar.TabIndex = 5;
            pbBuscar.TabStop = false;
            pbBuscar.MouseEnter += pbBuscar_MouseEnter_1;
            pbBuscar.MouseLeave += pbBuscar_MouseLeave_1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(btnComprar);
            panel3.Controls.Add(txtCantidadCarrito);
            panel3.Controls.Add(pbCarrito);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 612);
            panel3.Name = "panel3";
            panel3.Size = new Size(1251, 63);
            panel3.TabIndex = 4;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(1102, 16);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(94, 29);
            btnComprar.TabIndex = 2;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // txtCantidadCarrito
            // 
            txtCantidadCarrito.AutoSize = true;
            txtCantidadCarrito.Location = new Point(990, 21);
            txtCantidadCarrito.Name = "txtCantidadCarrito";
            txtCantidadCarrito.Size = new Size(0, 20);
            txtCantidadCarrito.TabIndex = 1;
            // 
            // pbCarrito
            // 
            pbCarrito.Image = (Image)resources.GetObject("pbCarrito.Image");
            pbCarrito.Location = new Point(1014, 13);
            pbCarrito.Name = "pbCarrito";
            pbCarrito.Size = new Size(42, 33);
            pbCarrito.SizeMode = PictureBoxSizeMode.Zoom;
            pbCarrito.TabIndex = 0;
            pbCarrito.TabStop = false;
            pbCarrito.Click += pbCarrito_Click;
            pbCarrito.MouseEnter += pbCarrito_MouseEnter;
            pbCarrito.MouseLeave += pbCarrito_MouseLeave;
            // 
            // Catalogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 675);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Catalogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalogo";
            Load += Catalogo_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)atras).EndInit();
            ((System.ComponentModel.ISupportInitialize)salir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbbBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBuscar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCarrito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox salir;
        private PictureBox atras;
        private TextBox txtBuscador;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pbbBuscar;
        private PictureBox pbBuscar;
        private Panel panel3;
        private Label txtCantidadCarrito;
        private PictureBox pbCarrito;
        private Button btnComprar;
    }
}