using System;
using System.Windows.Forms;

namespace GestorDeVenta
{
    public partial class FormLaptop : Form
    {
        public Laptop Laptop { get; private set; }
        private bool isEditMode;

        public FormLaptop()
        {
            InitializeComponent();
            isEditMode = false; // Modo agregar

            // Establecer límites para NumericUpDown
            numRAM.Minimum = 0;
            numRAM.Maximum = 128; // Ajusta según lo que consideres necesario
            numPrecio.Minimum = 0; // Asegúrate de que el precio no sea negativo
            numStock.Minimum = 0; // Asegúrate de que el stock no sea negativo
        }

        public FormLaptop(Laptop laptop) : this()
        {
            Laptop = laptop;
            isEditMode = true; // Modo editar
            CargarDatosLaptop();
        }

        private void CargarDatosLaptop()
        {
            if (Laptop != null)
            {
                txtMarca.Text = Laptop.Marca;
                txtModelo.Text = Laptop.Modelo;
                txtProcesador.Text = Laptop.Procesador;
                numRAM.Value = Laptop.RAM > numRAM.Maximum ? numRAM.Maximum : Laptop.RAM; // Asegúrate de que esté dentro del rango
                txtAlmacenamiento.Text = Laptop.Almacenamiento;
                numPrecio.Value = Laptop.Precio > numPrecio.Maximum ? numPrecio.Maximum : (decimal)Laptop.Precio; // Asegúrate de que esté dentro del rango
                txtImagenUrl.Text = Laptop.ImagenUrl;
                numStock.Value = Laptop.Stock > numStock.Maximum ? numStock.Maximum : Laptop.Stock; // Asegúrate de que esté dentro del rango
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones básicas
                if (string.IsNullOrWhiteSpace(txtMarca.Text) ||
                    string.IsNullOrWhiteSpace(txtModelo.Text) ||
                    string.IsNullOrWhiteSpace(txtProcesador.Text) ||
                    string.IsNullOrWhiteSpace(txtAlmacenamiento.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.",
                                    "Campos incompletos",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                var gestor = new GestorDatos();

                if (isEditMode) // Modo editar
                {
                    Laptop.Marca = txtMarca.Text;
                    Laptop.Modelo = txtModelo.Text;
                    Laptop.Procesador = txtProcesador.Text;
                    Laptop.RAM = (int)numRAM.Value;
                    Laptop.Almacenamiento = txtAlmacenamiento.Text;
                    Laptop.Precio = numPrecio.Value;
                    Laptop.ImagenUrl = txtImagenUrl.Text;
                    Laptop.Stock = (int)numStock.Value;

                    gestor.ActualizarLaptop(Laptop); // Actualizar en Excel
                    MessageBox.Show("Laptop modificada exitosamente!",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else // Modo agregar
                {
                    Laptop = new Laptop
                    {
                        Marca = txtMarca.Text,
                        Modelo = txtModelo.Text,
                        Procesador = txtProcesador.Text,
                        RAM = (int)numRAM.Value,
                        Almacenamiento = txtAlmacenamiento.Text,
                        Precio = numPrecio.Value,
                        ImagenUrl = txtImagenUrl.Text,
                        Stock = (int)numStock.Value
                    };

                    gestor.AgregarLaptop(Laptop); // Agregar en Excel
                    MessageBox.Show("Laptop guardada exitosamente!",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void FormLaptop_Load(object sender, EventArgs e)
        {
            // Este método puede quedar vacío si no necesitas realizar ninguna acción específica al cargar el formulario
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Llama al método que maneja la lógica de aceptar
            BtnAceptar_Click(sender, e);
        }
    }
}