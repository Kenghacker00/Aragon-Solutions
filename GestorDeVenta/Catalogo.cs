using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GestorDeVenta
{
    public partial class Catalogo : Form
    {
        private FlowLayoutPanel flowLayoutPanel1;
        private GestorDatos gestorDatos = new GestorDatos();

        public Label CantidadCarrito = new Label();

        public Catalogo()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            InitializeComponent();
            gestorDatos.ArchivoLaptop();
            inicializarInterfaz();
            ActualizarCantidadCarrito(GestorDatos.Instance.laptops.Count);
            this.CantidadCarrito = txtCantidadCarrito;
        }

        private void inicializarInterfaz()
        {
            flowLayoutPanel1 = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            this.Controls.Add(flowLayoutPanel1);
        }

        private void CargarLaptops()
        {
            flowLayoutPanel1.Controls.Clear();
            var laptops = gestorDatos.FiltrarCatalogo(txtBuscador.Text);

            foreach (var laptop in laptops)
            {
                Panel laptopPanel = CrearPanelLaptop(laptop);
                flowLayoutPanel1.Controls.Add(laptopPanel);
            }
        }

        private Panel CrearPanelLaptop(Laptop laptop)
        {
            Panel panel = new Panel
            {
                Width = 300,
                Height = 400,
                Margin = new Padding(72, 110, 20, 0),
                BorderStyle = BorderStyle.FixedSingle

            };
            panel.MouseEnter += (s, e) =>
            {
                panel.BackColor = Color.Gainsboro;
                panel.BorderStyle = BorderStyle.None;
            };

            panel.MouseLeave += (s, e) =>
            {
                panel.BackColor = Color.Transparent;
                panel.BorderStyle = BorderStyle.FixedSingle;
            };

            PictureBox pictureBox = new PictureBox
            {
                Width = 210,
                Height = 210,
                SizeMode = PictureBoxSizeMode.Zoom,
                ImageLocation = laptop.ImagenUrl,
                Margin = new Padding()
            };

            pictureBox.MouseEnter += (s, e) => panel.BackColor = Color.Gainsboro;
            pictureBox.MouseLeave += (s, e) => panel.BackColor = Color.Transparent;

            Label lblInfo = new Label
            {
                Text = $"{laptop.Marca} {laptop.Modelo}\n" +
                       $"   Procesador: {laptop.Procesador}\n" +
                       $"   Precio: ${laptop.Precio}\n",
                AutoSize = true,
                Location = new Point(14, 220)
            };

            lblInfo.MouseEnter += (s, e) => panel.BackColor = Color.Gainsboro;
            lblInfo.MouseLeave += (s, e) => panel.BackColor = Color.Transparent;

            Button agregarCarrito = new Button
            {
                Text = "Agregar al carrito",
                Location = new Point(10, 320),
                Size = new Size(150, 32)
            };
            agregarCarrito.Click += (s, e) => VistaPrevia(laptop);


            panel.Controls.AddRange(new Control[] { pictureBox, lblInfo, agregarCarrito });
            pictureBox.Left = (panel.ClientSize.Width - pictureBox.Width) / 2;
            agregarCarrito.Left = (panel.ClientSize.Width - agregarCarrito.Width) / 2;
            return panel;
        }

        private void VistaPrevia(Laptop laptop)
        {
            if (laptop.Stock > 0)
            {
                if (MessageBox.Show($"¿Desea agregar al carrito {laptop.Marca} {laptop.Modelo} por ${laptop.Precio}?", "Confirmar Compra",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    VistaPreviaCarrito vistaPrevia = new VistaPreviaCarrito(laptop, this);

                    vistaPrevia.Show();
                }
            }
            else
            {
                MessageBox.Show("Lo sentimos, este producto está agotado.");
            }
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            CargarLaptops();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbBuscar_MouseEnter(object sender, EventArgs e)
        {
            pbbBuscar.BackColor = Color.Gainsboro;
            pbBuscar.BackColor = Color.Gainsboro;
        }

        private void pbBuscar_MouseLeave(object sender, EventArgs e)
        {
            pbbBuscar.BackColor = Color.White;
            pbBuscar.BackColor = Color.White;
        }

        private void pbBuscar_MouseEnter_1(object sender, EventArgs e)
        {
            pbBuscar.BackColor = Color.Gainsboro;
            pbbBuscar.BackColor = Color.Gainsboro;
        }

        private void pbBuscar_MouseLeave_1(object sender, EventArgs e)
        {
            pbBuscar.BackColor = Color.White;
            pbbBuscar.BackColor = Color.White;
        }

        private void pbbBuscar_Click(object sender, EventArgs e)
        {
            CargarLaptops();
        }

        private void pbCarrito_MouseEnter(object sender, EventArgs e)
        {
            pbCarrito.Width = 36;
            pbCarrito.Height = 45;
        }

        private void pbCarrito_MouseLeave(object sender, EventArgs e)
        {
            pbCarrito.Width = 33;
            pbCarrito.Height = 42;
        }

        private void pbCarrito_Click(object sender, EventArgs e)
        {
            Carrito carrito = new Carrito(this);
            carrito.Show();
        }

        public void ActualizarCantidadCarrito(int cantidad)
        {
            txtCantidadCarrito.Text = $"{cantidad}";
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra(this);
            compra.Show();
        }
    }
}
