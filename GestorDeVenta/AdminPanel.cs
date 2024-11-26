using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.Axes;

namespace GestorDeVenta
{
    public partial class AdminPanel : Form
    {
        private GestorDatos gestorDatos = new GestorDatos();
        private DataGridView dgvLaptops = new DataGridView();

        public AdminPanel()
        {
            InitializeComponent();
            LoadChart();
            ventasAyer.Text = gestorDatos.ContarVentasPorDia(-1).ToString();
            ventasHoy.Text = gestorDatos.ContarVentasPorDia(0).ToString();
            if (int.Parse(ventasAyer.Text) < int.Parse(ventasHoy.Text))
            {
                panelVHoy.BackColor = Color.Chartreuse;
            }
            else if (int.Parse(ventasAyer.Text) > int.Parse(ventasHoy.Text))
            {
                panelVAyer.BackColor = Color.HotPink;
            }
            else
            {
                panelVAyer.BackColor = Color.Wheat;
                panelVHoy.BackColor = Color.Wheat;
            }
            ventasMes.Text = gestorDatos.ContarVentasPorMes(int.Parse(DateTime.Now.Month.ToString()), int.Parse(DateTime.Now.Year.ToString())).ToString();
            ventasAnio.Text = gestorDatos.ContarVentasPorAnio(int.Parse(DateTime.Now.Year.ToString())).ToString();
        }
        private void LoadChart()
        {
            int ventasAyer = gestorDatos.ContarVentasPorDia(-1);
            int ventasHoy = gestorDatos.ContarVentasPorDia(0);

            if (ventasAyer < 0) ventasAyer = 0;
            if (ventasHoy < 0) ventasHoy = 0;

            var plotModel = new PlotModel { Title = "Comparación de Ventas" };

            plotModel.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Días",
                ItemsSource = new[] { "Ayer", "Hoy" }
            });


            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Ventas",
                Minimum = 0,
                Maximum = Math.Max(ventasAyer, ventasHoy) + 10
            });

            // Crear una serie de barras
            var barSeries = new BarSeries
            {
                Title = "Ventas",
                ItemsSource = new[]
                {
            new BarItem { Value = ventasAyer },
            new BarItem { Value = ventasHoy }
        }
            };

            plotModel.Series.Add(barSeries);


            plotView1.Model = plotModel;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) // Eliminar
        {
            FormLaptopsManager formLaptopsManager = new FormLaptopsManager();
            formLaptopsManager.ShowDialog();
        }

        private void modificarLaptopToolStripMenuItem_Click(object sender, EventArgs e) // Modificar
        {
            FormLaptopsManager formLaptopsManager = new FormLaptopsManager();
            formLaptopsManager.ShowDialog();
        }

        private void CargarLaptops()
        {
            dgvLaptops.DataSource = null; // Limpiar la fuente de datos actual
            dgvLaptops.DataSource = gestorDatos.ObtenerLaptops(); // Cargar las laptops
        }

        private void AgregarLaptop_Click(object sender, EventArgs e)
        {
            FormLaptopsManager formLaptopsManager = new FormLaptopsManager();
            formLaptopsManager.ShowDialog();
        }

        private void btnEliminarUsu_Click(object sender, EventArgs e)
        {
            FormUsuariosManager formUsuariosManager = new FormUsuariosManager();
            formUsuariosManager.ShowDialog();
        }
    }
}
