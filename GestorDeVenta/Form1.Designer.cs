namespace GestorDeVenta
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelLogin = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblBienvenida = new Label();
            btnRegistrar = new Button();
            txtEmail = new TextBox();
            btnIniciar = new Button();
            txtContra = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelLogin.BackColor = Color.WhiteSmoke;
            panelLogin.Controls.Add(pictureBox3);
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Controls.Add(panel1);
            panelLogin.Controls.Add(txtEmail);
            panelLogin.Controls.Add(btnIniciar);
            panelLogin.Controls.Add(txtContra);
            panelLogin.Location = new Point(66, 69);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(927, 527);
            panelLogin.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(748, 367);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            pictureBox3.MouseEnter += pictureBox3_MouseEnter;
            pictureBox3.MouseLeave += pictureBox3_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(546, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblBienvenida);
            panel1.Controls.Add(btnRegistrar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 570);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(58, 260);
            label2.Name = "label2";
            label2.Size = new Size(256, 28);
            label2.TabIndex = 9;
            label2.Text = "con tecnologia de punta.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 227);
            label1.Name = "label1";
            label1.Size = new Size(296, 28);
            label1.TabIndex = 8;
            label1.Text = "Impulsando tu productividad";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.White;
            lblBienvenida.Location = new Point(102, 109);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(160, 34);
            lblBienvenida.TabIndex = 7;
            lblBienvenida.Text = "BIENVENIDO !";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.SteelBlue;
            btnRegistrar.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(116, 379);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(146, 39);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            btnRegistrar.MouseEnter += btnRegistrar_MouseEnter;
            btnRegistrar.MouseLeave += btnRegistrar_MouseLeave;
            // 
            // txtEmail
            // 
            txtEmail.AccessibleName = "";
            txtEmail.Location = new Point(562, 300);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.Size = new Size(189, 27);
            txtEmail.TabIndex = 7;
            txtEmail.Tag = "";
            txtEmail.Leave += txtEmail_Leave;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.WhiteSmoke;
            btnIniciar.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.SteelBlue;
            btnIniciar.Location = new Point(593, 432);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(127, 39);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            btnIniciar.MouseEnter += btnIniciar_MouseEnter;
            btnIniciar.MouseLeave += btnIniciar_MouseLeave;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(562, 367);
            txtContra.Name = "txtContra";
            txtContra.PlaceholderText = "Contraseña";
            txtContra.Size = new Size(189, 27);
            txtContra.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(-1, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1055, 39);
            panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1013, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Lavender;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1049, 626);
            Controls.Add(panel2);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO";
            Load += Form1_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Button btnRegistrar;
        private Button btnIniciar;
        private TextBox txtContra;
        private TextBox txtEmail;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblBienvenida;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
