namespace GestorDeVenta
{
    partial class Compra
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra));
            btnPagar = new Button();
            lblTotal = new Label();
            label5 = new Label();
            pbTarjeta = new PictureBox();
            label6 = new Label();
            nombre = new TextBox();
            yy = new TextBox();
            label4 = new Label();
            mm = new TextBox();
            label3 = new Label();
            cvv = new TextBox();
            label2 = new Label();
            label1 = new Label();
            numTarjeta = new TextBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            direccion = new TextBox();
            label9 = new Label();
            codPostal = new TextBox();
            label10 = new Label();
            numTel = new TextBox();
            label11 = new Label();
            nombreDest = new TextBox();
            label12 = new Label();
            pagoPorEnvio = new Label();
            InfoTotal = new ToolTip(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbTarjeta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(1017, 9);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(105, 29);
            btnPagar.TabIndex = 31;
            btnPagar.Text = "Pagar ahora";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(1056, 409);
            lblTotal.Name = "lblTotal";
            lblTotal.RightToLeft = RightToLeft.No;
            lblTotal.Size = new Size(0, 19);
            lblTotal.TabIndex = 30;
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(643, 408);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 29;
            label5.Text = "Total a pagar:";
            // 
            // pbTarjeta
            // 
            pbTarjeta.Location = new Point(1008, 124);
            pbTarjeta.Name = "pbTarjeta";
            pbTarjeta.Size = new Size(71, 42);
            pbTarjeta.SizeMode = PictureBoxSizeMode.Zoom;
            pbTarjeta.TabIndex = 28;
            pbTarjeta.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(691, 306);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 27;
            label6.Text = "Nombre de la tarjeta";
            // 
            // nombre
            // 
            nombre.Location = new Point(691, 330);
            nombre.MaxLength = 2000;
            nombre.Name = "nombre";
            nombre.Size = new Size(394, 27);
            nombre.TabIndex = 26;
            nombre.Leave += nombre_Leave;
            // 
            // yy
            // 
            yy.Location = new Point(1017, 234);
            yy.MaxLength = 2;
            yy.Name = "yy";
            yy.PlaceholderText = "yy";
            yy.Size = new Size(68, 27);
            yy.TabIndex = 25;
            yy.Leave += yy_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(923, 211);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 24;
            label4.Text = "Fecha de expiración";
            // 
            // mm
            // 
            mm.Location = new Point(923, 234);
            mm.MaxLength = 2;
            mm.Name = "mm";
            mm.PlaceholderText = "mm";
            mm.Size = new Size(62, 27);
            mm.TabIndex = 23;
            mm.Leave += mm_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(691, 210);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 22;
            label3.Text = "CVV";
            // 
            // cvv
            // 
            cvv.Location = new Point(691, 234);
            cvv.MaxLength = 3;
            cvv.Name = "cvv";
            cvv.PlaceholderText = "000";
            cvv.Size = new Size(136, 27);
            cvv.TabIndex = 21;
            cvv.UseSystemPasswordChar = true;
            cvv.Leave += cvv_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(691, 117);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 20;
            label2.Text = "Número de la tarjeta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(643, 39);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 19;
            label1.Text = "Realizar pago";
            // 
            // numTarjeta
            // 
            numTarjeta.BackColor = SystemColors.Window;
            numTarjeta.ForeColor = Color.Black;
            numTarjeta.Location = new Point(691, 141);
            numTarjeta.MaxLength = 16;
            numTarjeta.Name = "numTarjeta";
            numTarjeta.PlaceholderText = "0000-0000-0000-0000";
            numTarjeta.Size = new Size(294, 27);
            numTarjeta.TabIndex = 18;
            numTarjeta.TextChanged += numTarjeta_TextChanged;
            numTarjeta.Leave += numTarjeta_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(543, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 491);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(54, 39);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 32;
            label7.Text = "Entrega";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(66, 210);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 34;
            label8.Text = "Direccion exacta";
            // 
            // direccion
            // 
            direccion.BackColor = SystemColors.Window;
            direccion.ForeColor = Color.Black;
            direccion.Location = new Point(66, 234);
            direccion.MaxLength = 1000;
            direccion.Name = "direccion";
            direccion.PlaceholderText = "Pais, Ciudad/Estado, Departamento, Calle/Barrio, N° Casa";
            direccion.Size = new Size(404, 27);
            direccion.TabIndex = 33;
            direccion.Leave += direccion_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(66, 306);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 36;
            label9.Text = "Codigo Postal";
            // 
            // codPostal
            // 
            codPostal.Location = new Point(66, 330);
            codPostal.MaxLength = 12;
            codPostal.Name = "codPostal";
            codPostal.PlaceholderText = "00000000";
            codPostal.Size = new Size(147, 27);
            codPostal.TabIndex = 35;
            codPostal.KeyPress += codPostal_KeyPress;
            codPostal.Leave += codPostal_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(301, 306);
            label10.Name = "label10";
            label10.Size = new Size(127, 20);
            label10.TabIndex = 38;
            label10.Text = "Numero/Telefono";
            // 
            // numTel
            // 
            numTel.Location = new Point(301, 330);
            numTel.MaxLength = 15;
            numTel.Name = "numTel";
            numTel.PlaceholderText = "0000 0000";
            numTel.Size = new Size(169, 27);
            numTel.TabIndex = 37;
            numTel.KeyPress += numTel_KeyPress;
            numTel.Leave += numTel_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(66, 117);
            label11.Name = "label11";
            label11.Size = new Size(240, 20);
            label11.TabIndex = 40;
            label11.Text = "Nombre completo del destinatario";
            // 
            // nombreDest
            // 
            nombreDest.BackColor = SystemColors.Window;
            nombreDest.ForeColor = Color.Black;
            nombreDest.Location = new Point(66, 141);
            nombreDest.MaxLength = 1000;
            nombreDest.Name = "nombreDest";
            nombreDest.Size = new Size(404, 27);
            nombreDest.TabIndex = 39;
            nombreDest.Leave += nombreDest_Leave;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(54, 409);
            label12.Name = "label12";
            label12.Size = new Size(118, 20);
            label12.TabIndex = 41;
            label12.Text = "Pago por envio:";
            // 
            // pagoPorEnvio
            // 
            pagoPorEnvio.AutoSize = true;
            pagoPorEnvio.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pagoPorEnvio.Location = new Point(437, 409);
            pagoPorEnvio.Name = "pagoPorEnvio";
            pagoPorEnvio.RightToLeft = RightToLeft.No;
            pagoPorEnvio.Size = new Size(0, 19);
            pagoPorEnvio.TabIndex = 42;
            pagoPorEnvio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnPagar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 475);
            panel1.Name = "panel1";
            panel1.Size = new Size(1165, 49);
            panel1.TabIndex = 43;
            // 
            // Compra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 524);
            Controls.Add(panel1);
            Controls.Add(pagoPorEnvio);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(nombreDest);
            Controls.Add(label10);
            Controls.Add(numTel);
            Controls.Add(label9);
            Controls.Add(codPostal);
            Controls.Add(label8);
            Controls.Add(direccion);
            Controls.Add(label7);
            Controls.Add(lblTotal);
            Controls.Add(label5);
            Controls.Add(pbTarjeta);
            Controls.Add(label6);
            Controls.Add(nombre);
            Controls.Add(yy);
            Controls.Add(label4);
            Controls.Add(mm);
            Controls.Add(label3);
            Controls.Add(cvv);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numTarjeta);
            Controls.Add(pictureBox1);
            Name = "Compra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compra";
            ((System.ComponentModel.ISupportInitialize)pbTarjeta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPagar;
        private Label lblTotal;
        private Label label5;
        private PictureBox pbTarjeta;
        private Label label6;
        private TextBox nombre;
        private TextBox yy;
        private Label label4;
        private TextBox mm;
        private Label label3;
        private TextBox cvv;
        private Label label2;
        private Label label1;
        private TextBox numTarjeta;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
        private TextBox direccion;
        private Label label9;
        private TextBox codPostal;
        private Label label10;
        private TextBox numTel;
        private Label label11;
        private TextBox nombreDest;
        private Label label12;
        private Label pagoPorEnvio;
        private ToolTip InfoTotal;
        private Panel panel1;
    }
}