namespace GestorDeVenta
{
    partial class FormLaptop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaptop));
            button1 = new Button();
            label9 = new Label();
            numPrecio = new NumericUpDown();
            numStock = new NumericUpDown();
            numRAM = new NumericUpDown();
            txtImagenUrl = new TextBox();
            txtAlmacenamiento = new TextBox();
            txtProcesador = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRAM).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(232, 472);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 38;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(264, 303);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 37;
            label9.Text = "$";
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(287, 301);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(150, 27);
            numPrecio.TabIndex = 36;
            // 
            // numStock
            // 
            numStock.Location = new Point(287, 399);
            numStock.Name = "numStock";
            numStock.Size = new Size(150, 27);
            numStock.TabIndex = 35;
            // 
            // numRAM
            // 
            numRAM.Location = new Point(287, 206);
            numRAM.Name = "numRAM";
            numRAM.Size = new Size(150, 27);
            numRAM.TabIndex = 34;
            // 
            // txtImagenUrl
            // 
            txtImagenUrl.Location = new Point(287, 346);
            txtImagenUrl.Name = "txtImagenUrl";
            txtImagenUrl.Size = new Size(182, 27);
            txtImagenUrl.TabIndex = 33;
            // 
            // txtAlmacenamiento
            // 
            txtAlmacenamiento.Location = new Point(287, 252);
            txtAlmacenamiento.Name = "txtAlmacenamiento";
            txtAlmacenamiento.Size = new Size(182, 27);
            txtAlmacenamiento.TabIndex = 32;
            // 
            // txtProcesador
            // 
            txtProcesador.Location = new Point(287, 156);
            txtProcesador.Name = "txtProcesador";
            txtProcesador.Size = new Size(182, 27);
            txtProcesador.TabIndex = 31;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(287, 108);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(182, 27);
            txtModelo.TabIndex = 30;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(287, 62);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(182, 27);
            txtMarca.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(82, 303);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 28;
            label8.Text = "Precio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 349);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 27;
            label7.Text = "URL de imagen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 401);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 26;
            label6.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 255);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 25;
            label5.Text = "Almacenamiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 111);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 24;
            label4.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 159);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 23;
            label3.Text = "Procesador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 208);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 22;
            label2.Text = "RAM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Location = new Point(82, 65);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 21;
            label1.Text = "Marca";
            // 
            // FormLaptop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(559, 585);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(numPrecio);
            Controls.Add(numStock);
            Controls.Add(numRAM);
            Controls.Add(txtImagenUrl);
            Controls.Add(txtAlmacenamiento);
            Controls.Add(txtProcesador);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLaptop";
            Text = "FormLaptop";
            Load += FormLaptop_Load;
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRAM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label9;
        private NumericUpDown numPrecio;
        private NumericUpDown numStock;
        private NumericUpDown numRAM;
        private TextBox txtImagenUrl;
        private TextBox txtAlmacenamiento;
        private TextBox txtProcesador;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}