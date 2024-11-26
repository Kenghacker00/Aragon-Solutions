using System;
using System.Linq;
using System.Windows.Forms;

namespace GestorDeVenta
{
    public partial class FormLaptopsManager : Form
    {
        private GestorDatos gestorDatos = new GestorDatos();
        private List<Laptop> laptops; // Almacenar la lista de laptops

        public FormLaptopsManager()
        {
            InitializeComponent();
            CargarLaptops();
        }

        private void CargarLaptops()
        {
            laptops = gestorDatos.ObtenerLaptops(); // Obtener la lista de laptops
            dgvLaptops.DataSource = null; // Limpiar la fuente de datos actual
            dgvLaptops.DataSource = laptops; // Cargar las laptops
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormLaptop formLaptop = new FormLaptop();
            if (formLaptop.ShowDialog() == DialogResult.OK)
            {
                CargarLaptops();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvLaptops.SelectedRows.Count > 0)
            {
                var selectedRow = dgvLaptops.SelectedRows[0];
                var laptop = new Laptop
                {
                    Id = (int)selectedRow.Cells["ID"].Value,
                    Marca = selectedRow.Cells["Marca"].Value.ToString(),
                    Modelo = selectedRow.Cells["Modelo"].Value.ToString(),
                    Procesador = selectedRow.Cells["Procesador"].Value.ToString(),
                    RAM = (int)selectedRow.Cells["RAM"].Value,
                    Almacenamiento = selectedRow.Cells["Almacenamiento"].Value.ToString(),
                    Precio = (decimal)selectedRow.Cells["Precio"].Value,
                    ImagenUrl = selectedRow.Cells["ImagenURL"].Value.ToString(),
                    Stock = (int)selectedRow.Cells["Stock"].Value
                };

                FormLaptop formLaptop = new FormLaptop(laptop);
                if (formLaptop.ShowDialog() == DialogResult.OK)
                {
                    gestorDatos.ActualizarLaptop(formLaptop.Laptop);
                    CargarLaptops();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una laptop para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLaptops.SelectedRows.Count > 0)
            {
                var selectedRow = dgvLaptops.SelectedRows[0];
                int laptopId = (int)selectedRow.Cells["ID"].Value;

                var result = MessageBox.Show("¿Está seguro de que desea eliminar esta laptop?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    gestorDatos.EliminarLaptop(laptopId);
                    MessageBox.Show("Laptop eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLaptops();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una laptop para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarLaptop_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscarLaptop.Text;
            var laptopsFiltradas = laptops.Where(l => l.Marca.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                                                       l.Modelo.Contains(busqueda, StringComparison.OrdinalIgnoreCase)).ToList();

            if (laptopsFiltradas.Count == 0)
            {
                MessageBox.Show("No se encontraron laptops que coincidan con su búsqueda.", "Búsqueda sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvLaptops.DataSource = laptopsFiltradas; // Actualiza el DataGridView con las laptops filtradas
        }
    }
}