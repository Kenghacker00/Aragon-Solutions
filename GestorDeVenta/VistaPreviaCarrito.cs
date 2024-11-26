using iText.Kernel.Pdf;  
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Colors;      
using iText.Kernel.Font;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using iText.IO.Image;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout.Borders;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestorDeVenta
{
    public partial class VistaPreviaCarrito : Form
    {
        private Laptop laptop;
        Catalogo catalogo = new Catalogo();
        
        public VistaPreviaCarrito(Laptop laptop, Catalogo catalogo)
        {
            InitializeComponent();
            this.Text = $"Especificaciones de {laptop.Marca} {laptop.Modelo}";
            this.laptop = laptop;
            this.catalogo = catalogo;
            PictureBox pb = new PictureBox
            {
                Width = 420,
                Height = 420,
                SizeMode = PictureBoxSizeMode.Zoom,
                ImageLocation = laptop.ImagenUrl,
                Margin = new Padding()
            };
            pb.Top = ((this.ClientSize.Height - pb.Height) / 2) - 20;
            pb.Left = 55;
            this.Controls.Add(pb);

            System.Windows.Forms.Label especificaciones = new System.Windows.Forms.Label
            {
                Text = $"Marca: {laptop.Marca}\n\nModelo: {laptop.Modelo}\n\nProcesador: {laptop.Procesador}\n\nRAM: {laptop.RAM}\n\nAlmacenamiento: {laptop.Almacenamiento} GB\n\nPrecio: {laptop.Precio:C2}",
                Height = pb.Height,
                Width = pb.Width,
                Font = new System.Drawing.Font("Arial Rounded MT Bold", 13),

            };
            especificaciones.Location = new System.Drawing.Point(680, 100);
            this.Controls.Add(especificaciones);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GestorDatos.Instance.laptops.Add(laptop);
            catalogo.CantidadCarrito.Text = GestorDatos.Instance.laptops.Count.ToString();
            this.Close();
            
        }
    }
}

