using System;
using System.Windows.Forms;

namespace GestorDeVenta
{
    public partial class Carrito : Form
    {
        private Catalogo catalogo;

        public Carrito(Catalogo catalogo)
        {
            InitializeComponent();
            this.catalogo = catalogo;
            CargarElementosCarrito();
        }

        private void CargarElementosCarrito()
        {
            listBoxCarrito.Items.Clear();
            var laptops = GestorDatos.Instance.laptops; 

            if (laptops.Count == 0)
            {
                MessageBox.Show("No hay laptops en el carrito.");
                return;
            }

            foreach (var laptop in laptops)
            {
                listBoxCarrito.Items.Add($"{laptop.Marca} {laptop.Modelo}"); 
            }
        }

        private void ListBoxCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCarrito.SelectedIndex != -1)
            {
                var selectedLaptop = GestorDatos.Instance.laptops[listBoxCarrito.SelectedIndex]; 
                pictureBoxLaptop.ImageLocation = selectedLaptop.ImagenUrl; 
                pictureBoxLaptop.Load(); 
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxCarrito.SelectedIndex != -1)
            {
                GestorDatos.Instance.laptops.RemoveAt(listBoxCarrito.SelectedIndex); // Eliminar la laptop seleccionada
                CargarElementosCarrito(); // Actualizar el ListBox
                pictureBoxLaptop.Image = null; // Limpiar la imagen si se elimina
                catalogo.ActualizarCantidadCarrito(GestorDatos.Instance.laptops.Count);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un elemento para eliminar.");
            }
        }
    }
}
