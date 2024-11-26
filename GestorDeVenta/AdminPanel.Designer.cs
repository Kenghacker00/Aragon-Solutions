namespace GestorDeVenta
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            UsuarioOp = new MenuStrip();
            hToolStripMenuItem = new ToolStripMenuItem();
            btnEliminarUsu = new ToolStripMenuItem();
            LaptopOp = new MenuStrip();
            laptopsToolStripMenuItem = new ToolStripMenuItem();
            Opciones = new ToolStripMenuItem();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            panelVAyer = new Panel();
            ventasAyer = new Label();
            panelVHoy = new Panel();
            ventasHoy = new Label();
            panel3 = new Panel();
            ventasMes = new Label();
            panel4 = new Panel();
            ventasAnio = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            UsuarioOp.SuspendLayout();
            LaptopOp.SuspendLayout();
            panelVAyer.SuspendLayout();
            panelVHoy.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(UsuarioOp);
            panel1.Controls.Add(LaptopOp);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 450);
            panel1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(69, 34);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 102);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(49, 280);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 183);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // UsuarioOp
            // 
            UsuarioOp.BackColor = Color.Transparent;
            UsuarioOp.Dock = DockStyle.None;
            UsuarioOp.ImageScalingSize = new Size(20, 20);
            UsuarioOp.Items.AddRange(new ToolStripItem[] { hToolStripMenuItem });
            UsuarioOp.Location = new Point(99, 190);
            UsuarioOp.Name = "UsuarioOp";
            UsuarioOp.Size = new Size(257, 28);
            UsuarioOp.TabIndex = 6;
            UsuarioOp.Text = "menuStrip1";
            // 
            // hToolStripMenuItem
            // 
            hToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnEliminarUsu });
            hToolStripMenuItem.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hToolStripMenuItem.Name = "hToolStripMenuItem";
            hToolStripMenuItem.Size = new Size(99, 24);
            hToolStripMenuItem.Text = "Usuarios";
            // 
            // btnEliminarUsu
            // 
            btnEliminarUsu.BackColor = SystemColors.ButtonFace;
            btnEliminarUsu.Name = "btnEliminarUsu";
            btnEliminarUsu.Size = new Size(224, 26);
            btnEliminarUsu.Text = "Ver Opciones";
            btnEliminarUsu.Click += btnEliminarUsu_Click;
            // 
            // LaptopOp
            // 
            LaptopOp.BackColor = Color.Transparent;
            LaptopOp.Dock = DockStyle.None;
            LaptopOp.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaptopOp.ImageScalingSize = new Size(20, 20);
            LaptopOp.Items.AddRange(new ToolStripItem[] { laptopsToolStripMenuItem });
            LaptopOp.Location = new Point(99, 287);
            LaptopOp.Name = "LaptopOp";
            LaptopOp.Size = new Size(100, 28);
            LaptopOp.TabIndex = 7;
            LaptopOp.Text = "menuStrip1";
            // 
            // laptopsToolStripMenuItem
            // 
            laptopsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Opciones });
            laptopsToolStripMenuItem.Name = "laptopsToolStripMenuItem";
            laptopsToolStripMenuItem.Size = new Size(92, 24);
            laptopsToolStripMenuItem.Text = "Laptops";
            // 
            // Opciones
            // 
            Opciones.Name = "Opciones";
            Opciones.Size = new Size(224, 26);
            Opciones.Text = "Ver Opciones";
            Opciones.Click += AgregarLaptop_Click;
            // 
            // plotView1
            // 
            plotView1.Location = new Point(283, 87);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(362, 327);
            plotView1.TabIndex = 5;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // panelVAyer
            // 
            panelVAyer.BackColor = Color.Wheat;
            panelVAyer.Controls.Add(ventasAyer);
            panelVAyer.Location = new Point(651, 95);
            panelVAyer.Name = "panelVAyer";
            panelVAyer.Size = new Size(146, 49);
            panelVAyer.TabIndex = 6;
            // 
            // ventasAyer
            // 
            ventasAyer.AutoSize = true;
            ventasAyer.Location = new Point(63, 14);
            ventasAyer.Name = "ventasAyer";
            ventasAyer.Size = new Size(50, 20);
            ventasAyer.TabIndex = 0;
            ventasAyer.Text = "label1";
            // 
            // panelVHoy
            // 
            panelVHoy.BackColor = Color.Wheat;
            panelVHoy.Controls.Add(ventasHoy);
            panelVHoy.Location = new Point(827, 95);
            panelVHoy.Name = "panelVHoy";
            panelVHoy.Size = new Size(146, 49);
            panelVHoy.TabIndex = 7;
            // 
            // ventasHoy
            // 
            ventasHoy.AutoSize = true;
            ventasHoy.Location = new Point(59, 15);
            ventasHoy.Name = "ventasHoy";
            ventasHoy.Size = new Size(50, 20);
            ventasHoy.TabIndex = 0;
            ventasHoy.Text = "label1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Wheat;
            panel3.Controls.Add(ventasMes);
            panel3.Location = new Point(743, 184);
            panel3.Name = "panel3";
            panel3.Size = new Size(146, 49);
            panel3.TabIndex = 7;
            // 
            // ventasMes
            // 
            ventasMes.AutoSize = true;
            ventasMes.Location = new Point(61, 15);
            ventasMes.Name = "ventasMes";
            ventasMes.Size = new Size(50, 20);
            ventasMes.TabIndex = 0;
            ventasMes.Text = "label1";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Wheat;
            panel4.Controls.Add(ventasAnio);
            panel4.Location = new Point(743, 271);
            panel4.Name = "panel4";
            panel4.Size = new Size(146, 49);
            panel4.TabIndex = 7;
            // 
            // ventasAnio
            // 
            ventasAnio.AutoSize = true;
            ventasAnio.Location = new Point(58, 15);
            ventasAnio.Name = "ventasAnio";
            ventasAnio.Size = new Size(50, 20);
            ventasAnio.TabIndex = 0;
            ventasAnio.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(671, 71);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 1;
            label1.Text = "Ventas de ayer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(850, 71);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 8;
            label2.Text = "Ventas de hoy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(762, 161);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 9;
            label3.Text = "Ventas del mes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(762, 248);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 10;
            label4.Text = "Ventas de año";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panelVHoy);
            Controls.Add(panelVAyer);
            Controls.Add(plotView1);
            Controls.Add(panel1);
            MainMenuStrip = UsuarioOp;
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Opciones";
            Load += AdminPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            UsuarioOp.ResumeLayout(false);
            UsuarioOp.PerformLayout();
            LaptopOp.ResumeLayout(false);
            LaptopOp.PerformLayout();
            panelVAyer.ResumeLayout(false);
            panelVAyer.PerformLayout();
            panelVHoy.ResumeLayout(false);
            panelVHoy.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label btnAgregarLp;
        private Panel panel1;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private MenuStrip UsuarioOp;
        private ToolStripMenuItem hToolStripMenuItem;
        private ToolStripMenuItem btnEliminarUsu;
        private MenuStrip LaptopOp;
        private ToolStripMenuItem laptopsToolStripMenuItem;
        private ToolStripMenuItem agregarLaptopToolStripMenuItem;
        private ToolStripMenuItem editarLaptopToolStripMenuItem;
        private ToolStripMenuItem eliminarLaptopToolStripMenuItem;
        private Button btnEliminarLp;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Panel panelVAyer;
        private Label ventasAyer;
        private Panel panelVHoy;
        private Label ventasHoy;
        private Panel panel3;
        private Label ventasMes;
        private Panel panel4;
        private Label ventasAnio;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolStripMenuItem Opciones;
    }
}