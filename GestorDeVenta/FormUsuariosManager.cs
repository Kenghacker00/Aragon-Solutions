using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestorDeVenta
{
    public partial class FormUsuariosManager : Form
    {
        private GestorDatos gestorDatos = new GestorDatos();
        private List<Usuario> usuarios;

        public FormUsuariosManager()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            usuarios = gestorDatos.ObtenerUsuarios(); // Método que debes implementar en GestorDatos
            dgvUsuarios.DataSource = usuarios.ToList();
        }
        private void FormUsuariosManager_Load(object sender, EventArgs e)
        {

        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            var usuariosFiltrados = usuarios.Where(u => u.Nombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase)).ToList();

            if (usuariosFiltrados.Count == 0)
            {
                MessageBox.Show("No se encontraron usuarios que coincidan con su búsqueda.", "Búsqueda sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvUsuarios.DataSource = usuariosFiltrados; // Actualiza el DataGridView con los usuarios filtrados
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var usuarioSeleccionado = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show($"¿Está seguro que desea eliminar a {usuarioSeleccionado.Nombre}?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gestorDatos.EliminarUsuario(usuarioSeleccionado.Email); // Método que debes implementar en GestorDatos
                    CargarUsuarios(); // Recargar la lista de usuarios
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
            }
        }
    }
}
