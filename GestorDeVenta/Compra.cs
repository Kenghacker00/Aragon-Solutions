using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Layout;


namespace GestorDeVenta
{
    public partial class Compra : Form
    {
        Catalogo catalogo;
        
        public Compra(Catalogo catalogo)
        {
            InitializeComponent();
            pagoPorEnvio.Text = CalcularMontoEnvio().ToString("C2");
            lblTotal.Text = (CalcularMontoEnvio() + GestorDatos.Instance.laptops.Sum(laptop => laptop.Precio)).ToString("C2");
            InfoTotal.SetToolTip(lblTotal, ObtenerPrecios());
            this.catalogo = catalogo;
        }
        private GestorDatos gestorDatos = new GestorDatos();

        private void numTarjeta_TextChanged(object sender, EventArgs e)
        {
            
            if (numTarjeta.Text.StartsWith("4"))
            {
                pbTarjeta.ImageLocation = "images/visa.png";
            }
            else if (numTarjeta.Text.StartsWith("5"))
            {
                pbTarjeta.ImageLocation = "images/mastercard.png";
            }
            else
            {
                pbTarjeta.Image = null;
            }
        }

        private void numTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numTel_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numTel.Text))
            {
                numTel.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                numTel.BackColor = SystemColors.Window;
            }
        }

        private void codPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void codPostal_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codPostal.Text) || codPostal.Text.Length != 5)
            {
                codPostal.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                codPostal.BackColor = SystemColors.Window;
            }
        }

        private void nombreDest_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreDest.Text))
            {
                nombreDest.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                nombreDest.BackColor = SystemColors.Window;
            }
        }

        private void direccion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(direccion.Text))
            {
                direccion.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                direccion.BackColor = SystemColors.Window;
            }
        }

        private void numTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numTarjeta_Leave(object sender, EventArgs e)
        {
            if (!(numTarjeta.Text.StartsWith("4") || numTarjeta.Text.StartsWith("5")))
            {
                numTarjeta.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                numTarjeta.BackColor = SystemColors.Window;
            }
        }

        private void cvv_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cvv.Text))
            {
                cvv.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                cvv.BackColor = SystemColors.Window;
            }
        }

        private void mm_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mm.Text))
            {
                mm.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                mm.BackColor = SystemColors.Window;
            }
        }

        private void yy_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(yy.Text))
            {
                yy.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                yy.BackColor = SystemColors.Window;
            }
        }

        private void nombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombre.Text))
            {
                nombre.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                nombre.BackColor = SystemColors.Window;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (numTarjeta.Text == "" || cvv.Text == "" || mm.Text == "" || yy.Text == "" || nombre.Text == "" ||
    numTel.Text == "" || codPostal.Text == "" || nombreDest.Text == "" || direccion.Text == "")

            {
                MessageBox.Show("Debes completar todos los campos requeridos");
                return;
            }

            if (numTarjeta.Text.Length != 16)
            {
                MessageBox.Show("El número de tarjeta debe tener 16 dígitos");
                return;
            }

            if (cvv.Text.Length != 3)
            {
                MessageBox.Show("El CVV debe tener 3 dígitos");
                return;
            }

            int mesIngresado = int.Parse(mm.Text);
            int anioIngresado = int.Parse(yy.Text);
            int anioActual = DateTime.Now.Year % 100;
            int mesActual = DateTime.Now.Month;

            if (anioIngresado < anioActual || (anioIngresado == anioActual && mesIngresado < mesActual))
            {
                MessageBox.Show("La tarjeta ha expirado");
                return;
            }
            GestorDatos.Instance.RegistrarVenta();
            MessageBox.Show("Pago exitoso!");
            GestorDatos.Instance.FiltrarCatalogo("");
            GestorDatos.Instance.GenerarFactura(nombreDest.Text.ToString(),direccion.Text.ToString(),int.Parse(numTel.Text),int.Parse(codPostal.Text),CalcularMontoEnvio());
            catalogo.ActualizarCantidadCarrito(GestorDatos.Instance.laptops.Count);
            this.Close();
        }
        public decimal CalcularMontoEnvio()
        {
            decimal costo_paquete = 15; 
            int capacidad_paquete = 3; 

            int cantidadProductos = GestorDatos.Instance.laptops.Count;

            int numeroPaquetes = (cantidadProductos + capacidad_paquete - 1) / capacidad_paquete;

            decimal montoEnvio = numeroPaquetes * costo_paquete;

            return montoEnvio;
        }

        public string ObtenerPrecios()
        {
            StringBuilder precios = new StringBuilder();

            foreach (var laptop in GestorDatos.Instance.laptops)
            {
                precios.AppendLine($"{laptop.Marca}: ${laptop.Precio}");
            }

            return precios.ToString();
        }
    }
}

