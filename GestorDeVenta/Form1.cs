using System.Text.RegularExpressions;

namespace GestorDeVenta
{
    public partial class Form1 : Form
    {
        GestorDatos gestorDatos = new GestorDatos();
        private bool isShowPass;
        Usuario usuario = new Usuario();

        public Form1()
        {
            InitializeComponent();
            panelLogin.Tag = "Center";
            panel2.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            isShowPass = true;
            txtContra.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            gestorDatos.CargarUsuarios();
            string contrasenia = txtContra.Text;
            string e_mail = txtEmail.Text;

            usuario.Email = e_mail;
            usuario.Contraseña = contrasenia;

            if (gestorDatos.EsAdmin(e_mail, contrasenia))
            {
                VerificarClaveAdmin();
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
            }

            else if (gestorDatos.UsuarioRegistrado(e_mail, contrasenia))
            {
                MessageBox.Show("Inicio de sesión exitoso!");
                
                Catalogo catalogo = new Catalogo();
                catalogo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email o contraseña no validos");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.Show();
            this.Hide();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string patron = @"^[\w-\.]+@aragonsolutions\.net$";
            Regex rgx = new Regex(patron);
            if (!rgx.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("El correo debe terminar en '@aragonsolutions.net'");
            }
        }

        private void VerificarClaveAdmin()
        {
            int intentos = 0;
            while (intentos < 3)
            {
                string clave = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la clave secreta de administrador:", "Verificación de Administrador", "");
                if (clave == "proyectfinal")
                {
                    MessageBox.Show("Inicio de sesión de administrador exitoso!");
                    return;
                }
                intentos++;
                if (intentos < 3)
                {
                    MessageBox.Show($"Clave incorrecta. Intentos restantes: {3 - intentos}");
                }
            }
            MessageBox.Show("Número máximo de intentos alcanzado. Acceso denegado.");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(31, 46);

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(27, 43);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(45, 28);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(44, 27);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (isShowPass)
            {
                pictureBox3.Image = Image.FromFile("images/eye.png");
                txtContra.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox3.Image = Image.FromFile("images/view.png");
                txtContra.UseSystemPasswordChar = true;
            }

            isShowPass = !isShowPass;

        }

        private void btnRegistrar_MouseEnter(object sender, EventArgs e)
        {
            btnRegistrar.BackColor = Color.White;
            btnRegistrar.ForeColor = Color.SteelBlue;
        }

        private void btnRegistrar_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrar.BackColor = Color.SteelBlue;
            btnRegistrar.ForeColor = Color.White;
        }

        private void btnIniciar_MouseEnter(object sender, EventArgs e)
        {
            btnIniciar.BackColor = Color.SteelBlue;
            btnIniciar.ForeColor = Color.White;
        }

        private void btnIniciar_MouseLeave(object sender, EventArgs e)
        {
            btnIniciar.BackColor = Color.Transparent;
            btnIniciar.ForeColor = Color.SteelBlue;
        }
    }
}
