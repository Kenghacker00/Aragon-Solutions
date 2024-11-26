using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestorDeVenta
{
    public partial class FormRegistro : Form
    {
        private GestorDatos gestorDatos = new GestorDatos();

        public FormRegistro()
        {
            InitializeComponent();
            panel2.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!txtEmail.Text.EndsWith("@aragonsolutions.net"))
            {
                MessageBox.Show("El correo debe terminar en '@aragonsolutions.net'");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContra.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarContra.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtContra.Text != txtConfirmarContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Usuario nuevoUsuario = new Usuario
                {
                    Nombre = txtUsuario.Text,
                    Email = txtEmail.Text,
                    Contraseña = txtContra.Text,
                    Edad = int.Parse(txtEdad.Text)

                };
                gestorDatos.RegistrarUsuarios(nuevoUsuario);
                Form1 f = new Form1();
                f.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salir_MouseEnter(object sender, EventArgs e)
        {
            salir.Size = new Size(31, 46);
        }

        private void salir_MouseLeave(object sender, EventArgs e)
        {
            salir.Size = new Size(27, 43);
        }

        private void atras_MouseEnter(object sender, EventArgs e)
        {
            atras.Size = new Size(30, 45);
        }

        private void atras_MouseLeave(object sender, EventArgs e)
        {
            atras.Size = new Size(27, 43);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void btnRegistrar_MouseEnter(object sender, EventArgs e)
        {
            btnRegistrar.BackColor = Color.SteelBlue;
            btnRegistrar.ForeColor = Color.White;
        }

        private void btnRegistrar_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrar.BackColor = Color.White;
            btnRegistrar.BackColor = Color.SteelBlue;
        }

        private void btnIniciar_MouseEnter(object sender, EventArgs e)
        {
            btnIniciar.BackColor = Color.SteelBlue;

        }
    }
}