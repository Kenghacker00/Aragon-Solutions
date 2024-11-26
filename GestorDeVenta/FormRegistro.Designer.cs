namespace GestorDeVenta
{
    partial class FormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            panelRegistro = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            lblBienvenida = new Label();
            label1 = new Label();
            btnIniciar = new Button();
            pictureBox1 = new PictureBox();
            txtEdad = new TextBox();
            txtEmail = new TextBox();
            btnRegistrar = new Button();
            txtConfirmarContra = new TextBox();
            txtContra = new TextBox();
            txtUsuario = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            atras = new PictureBox();
            salir = new PictureBox();
            panelRegistro.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)atras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salir).BeginInit();
            SuspendLayout();
            // 
            // panelRegistro
            // 
            panelRegistro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelRegistro.BackColor = Color.WhiteSmoke;
            panelRegistro.Controls.Add(panel1);
            panelRegistro.Controls.Add(pictureBox1);
            panelRegistro.Controls.Add(txtEdad);
            panelRegistro.Controls.Add(txtEmail);
            panelRegistro.Controls.Add(btnRegistrar);
            panelRegistro.Controls.Add(txtConfirmarContra);
            panelRegistro.Controls.Add(txtContra);
            panelRegistro.Controls.Add(txtUsuario);
            panelRegistro.Location = new Point(65, 59);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Size = new Size(922, 541);
            panelRegistro.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblBienvenida);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnIniciar);
            panel1.Location = new Point(530, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 540);
            panel1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(73, 268);
            label2.Name = "label2";
            label2.Size = new Size(256, 28);
            label2.TabIndex = 16;
            label2.Text = "con tecnologia de punta.";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.White;
            lblBienvenida.Location = new Point(117, 117);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(160, 34);
            lblBienvenida.TabIndex = 14;
            lblBienvenida.Text = "BIENVENIDO !";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 235);
            label1.Name = "label1";
            label1.Size = new Size(296, 28);
            label1.TabIndex = 15;
            label1.Text = "Impulsando tu productividad";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.SteelBlue;
            btnIniciar.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(131, 387);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(146, 39);
            btnIniciar.TabIndex = 13;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.MouseEnter += btnIniciar_MouseEnter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(167, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // txtEdad
            // 
            txtEdad.AccessibleName = "";
            txtEdad.Location = new Point(174, 266);
            txtEdad.Name = "txtEdad";
            txtEdad.PlaceholderText = "Edad";
            txtEdad.Size = new Size(189, 27);
            txtEdad.TabIndex = 9;
            txtEdad.Tag = "";
            // 
            // txtEmail
            // 
            txtEmail.AccessibleName = "";
            txtEmail.Location = new Point(174, 311);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(189, 27);
            txtEmail.TabIndex = 8;
            txtEmail.Tag = "";
            txtEmail.Leave += txtEmail_Leave;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.SteelBlue;
            btnRegistrar.Location = new Point(193, 457);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(146, 39);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            btnRegistrar.MouseEnter += btnRegistrar_MouseEnter;
            btnRegistrar.MouseLeave += btnRegistrar_MouseLeave;
            // 
            // txtConfirmarContra
            // 
            txtConfirmarContra.Location = new Point(174, 403);
            txtConfirmarContra.Name = "txtConfirmarContra";
            txtConfirmarContra.PlaceholderText = "Confirmar Contraseña";
            txtConfirmarContra.Size = new Size(189, 27);
            txtConfirmarContra.TabIndex = 5;
            txtConfirmarContra.UseSystemPasswordChar = true;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(174, 358);
            txtContra.Name = "txtContra";
            txtContra.PlaceholderText = "Contraseña";
            txtContra.Size = new Size(189, 27);
            txtContra.TabIndex = 4;
            txtContra.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.AccessibleName = "";
            txtUsuario.Location = new Point(174, 220);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre";
            txtUsuario.Size = new Size(189, 27);
            txtUsuario.TabIndex = 3;
            txtUsuario.Tag = "";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(atras);
            panel2.Controls.Add(salir);
            panel2.Location = new Point(-11, -9);
            panel2.Name = "panel2";
            panel2.Size = new Size(1063, 48);
            panel2.TabIndex = 12;
            // 
            // atras
            // 
            atras.Image = (Image)resources.GetObject("atras.Image");
            atras.Location = new Point(25, 8);
            atras.Name = "atras";
            atras.Size = new Size(27, 43);
            atras.SizeMode = PictureBoxSizeMode.Zoom;
            atras.TabIndex = 14;
            atras.TabStop = false;
            atras.Click += atras_Click;
            atras.MouseEnter += atras_MouseEnter;
            atras.MouseLeave += atras_MouseLeave;
            // 
            // salir
            // 
            salir.Image = (Image)resources.GetObject("salir.Image");
            salir.Location = new Point(1025, 7);
            salir.Name = "salir";
            salir.Size = new Size(27, 43);
            salir.SizeMode = PictureBoxSizeMode.Zoom;
            salir.TabIndex = 13;
            salir.TabStop = false;
            salir.Click += pictureBox2_Click;
            salir.MouseEnter += salir_MouseEnter;
            salir.MouseLeave += salir_MouseLeave;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Teal;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1049, 626);
            Controls.Add(panel2);
            Controls.Add(panelRegistro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRO";
            panelRegistro.ResumeLayout(false);
            panelRegistro.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)atras).EndInit();
            ((System.ComponentModel.ISupportInitialize)salir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRegistro;
        private TextBox txtUsuario;
        private Button btnRegistrar;
        private TextBox txtContra;
        private TextBox txtConfirmarContra;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtEmail;
        private TextBox txtEdad;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox salir;
        private PictureBox atras;
        private Label label2;
        private Label lblBienvenida;
        private Label label1;
        private Button btnIniciar;
    }
}