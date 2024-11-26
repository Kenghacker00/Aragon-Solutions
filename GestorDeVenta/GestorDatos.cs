using OfficeOpenXml;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
using System.Globalization;
using System.Security.Cryptography;


namespace GestorDeVenta
{
    public class GestorDatos
    {
        private const string Usuarios = "users.xlsx";
        private const string ArchivoLaptops = "laptops.xlsx";
        public static GestorDatos Instance { get; } = new GestorDatos();
        public GestorDatos() { ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; }

        public Usuario usuario { get; set; } = new Usuario();
        public List<Laptop> laptops = new List<Laptop>();

        public void CargarUsuarios()
        {
            if (!File.Exists(Usuarios))
            {
                var file = new FileInfo(Usuarios);

                using (var package = new ExcelPackage(file))
                {
                    var hojatrabajo = package.Workbook.Worksheets.Add("Usuarios");
                    hojatrabajo.Cells[1, 1].Value = "Nombre";
                    hojatrabajo.Cells[1, 2].Value = "Edad";
                    hojatrabajo.Cells[1, 3].Value = "Email";
                    hojatrabajo.Cells[1, 4].Value = "Contraseña";
                    hojatrabajo.Cells[1, 5].Value = "Fecha de registro";
                    package.Save();
                }
            }
        }

        public void RegistrarUsuarios(Usuario us)
        {
            if (File.Exists(Usuarios))
            {
                var file = new FileInfo(Usuarios);

                using (var package = new ExcelPackage(file))
                {
                    var hojatrabajo = package.Workbook.Worksheets.First();
                    int cantfilas = hojatrabajo.Dimension.Rows;
                    for (int fila = 2; fila <= cantfilas; fila++)
                    {
                        if (us.Nombre == hojatrabajo.Cells[fila, 1].Text && us.Contraseña == hojatrabajo.Cells[fila, 4].Text || us.Email == hojatrabajo.Cells[fila, 3].Text && us.Edad == int.Parse(hojatrabajo.Cells[fila, 2].Text))
                        {
                            MessageBox.Show("Este usuario ya existe");
                            return;
                        }
                        if (us.Email == hojatrabajo.Cells[fila, 4].Text)
                        {
                            MessageBox.Show("Este correo ya esta registrado");
                            return;
                        }
                    }
                    hojatrabajo.Cells[cantfilas + 1, 1].Value = us.Nombre;
                    hojatrabajo.Cells[cantfilas + 1, 2].Value = us.Edad;
                    hojatrabajo.Cells[cantfilas + 1, 3].Value = us.Email;
                    hojatrabajo.Cells[cantfilas + 1, 4].Value = us.Contraseña;
                    hojatrabajo.Cells[cantfilas + 1, 5].Value = DateTime.Today.ToString("dd/MM/yyyy");
                    package.Save();
                    MessageBox.Show("Usuario registrado con éxito!", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                return;
            }
        }

        public bool UsuarioRegistrado(string nombre, string contraseña)
        {
            if (File.Exists(Usuarios))
            {
                var file = new FileInfo(Usuarios);

                using (var package = new ExcelPackage(file))
                {
                    var hojaTrabajo = package.Workbook.Worksheets.First();

                    for (int fila = 2; fila <= hojaTrabajo.Dimension.Rows; fila++)
                    {
                        var Nombre = hojaTrabajo.Cells[fila, 3].Text;
                        var Contraseña = hojaTrabajo.Cells[fila, 4].Text;

                        if (Nombre == nombre && Contraseña == contraseña)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool EsAdmin(string email, string password)
        {
            return email == "a" && password == "Asdfghj1";
            //return email == "juanaragoncruz@aragonsolutions.net" && password == "juan35";

        }

        public void ArchivoLaptop()
        {
            if (!File.Exists(ArchivoLaptops))
            {
                var file = new FileInfo(ArchivoLaptops);

                using (var package = new ExcelPackage(file))
                {
                    var hojatrabajo = package.Workbook.Worksheets.Add("Laptops");
                    hojatrabajo.Cells[1, 1].Value = "ID";
                    hojatrabajo.Cells[1, 2].Value = "Marca";
                    hojatrabajo.Cells[1, 3].Value = "Modelo";
                    hojatrabajo.Cells[1, 4].Value = "Procesador";
                    hojatrabajo.Cells[1, 5].Value = "RAM";
                    hojatrabajo.Cells[1, 6].Value = "Almacenamiento";
                    hojatrabajo.Cells[1, 7].Value = "Precio";
                    hojatrabajo.Cells[1, 8].Value = "ImagenURL";
                    hojatrabajo.Cells[1, 9].Value = "Stock";

                    var hojaventas = package.Workbook.Worksheets.Add("Ventas");
                    hojatrabajo.Cells[1, 1].Value = "ID";
                    hojatrabajo.Cells[1, 2].Value = "Marca";
                    hojatrabajo.Cells[1, 3].Value = "Precio";
                    hojatrabajo.Cells[1, 4].Value = "Fecha de venta";
                    package.Save();
                }
            }
        }

        public List<Laptop> ObtenerLaptops()
        {
            List<Laptop> laptops = new List<Laptop>();

            using (var package = new ExcelPackage(new FileInfo(ArchivoLaptops)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                if (worksheet.Dimension == null)
                {
                   
                    return laptops;
                }

                int rows = worksheet.Dimension.Rows;

                if (rows > 1) 
                {
                    for (int row = 2; row <= rows; row++)
                    {
                        Laptop laptop = new Laptop
                        {
                            Id = worksheet.Cells[row, 1].Value != null ? int.Parse(worksheet.Cells[row, 1].Value.ToString()) : 0,
                            Marca = worksheet.Cells[row, 2].Value != null ? worksheet.Cells[row, 2].Value.ToString() : string.Empty,
                            Modelo = worksheet.Cells[row, 3].Value != null ? worksheet.Cells[row, 3].Value.ToString() : string.Empty,
                            Procesador = worksheet.Cells[row, 4].Value != null ? worksheet.Cells[row, 4].Value.ToString() : string.Empty,
                            RAM = worksheet.Cells[row, 5].Value != null ? int.Parse(worksheet.Cells[row, 5].Value.ToString()) : 0,
                            Almacenamiento = worksheet.Cells[row, 6].Value != null ? worksheet.Cells[row, 6].Value.ToString() : string.Empty,
                            Precio = worksheet.Cells[row, 7].Value != null ? decimal.Parse(worksheet.Cells[row, 7].Value.ToString()) : 0.0m,
                            ImagenUrl = worksheet.Cells[row, 8].Value != null ? worksheet.Cells[row, 8].Value.ToString() : string.Empty,
                            Stock = worksheet.Cells[row, 9].Value != null ? int.Parse(worksheet.Cells[row, 9].Value.ToString()) : 0
                        };
                        laptops.Add(laptop);
                    }
                }
            }
            return laptops;
        }

        public List<Laptop> FiltrarCatalogo(string busqueda)
        {
            List<Laptop> laptops = ObtenerLaptops();

            if (string.IsNullOrEmpty(busqueda))
            {
                return laptops;
            }
            else
            {
                return laptops.Where(l => l.Marca.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                               l.Modelo.Contains(busqueda, StringComparison.OrdinalIgnoreCase)).ToList();
            }
        }


        public void AgregarLaptop(Laptop laptop)
        {
            try
            {
                

                using (var package = new ExcelPackage(new FileInfo(ArchivoLaptops)))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    int row = (worksheet.Dimension?.Rows ?? 1) + 1;

                    if (laptop.Id == 0)
                    {
                        laptop.Id = GenerarNuevoId(worksheet);
                    }

                    worksheet.Cells[row, 1].Value = laptop.Id;
                    worksheet.Cells[row, 2].Value = laptop.Marca;
                    worksheet.Cells[row, 3].Value = laptop.Modelo;
                    worksheet.Cells[row, 4].Value = laptop.Procesador;
                    worksheet.Cells[row, 5].Value = laptop.RAM;
                    worksheet.Cells[row, 6].Value = laptop.Almacenamiento;
                    worksheet.Cells[row, 7].Value = laptop.Precio;
                    worksheet.Cells[row, 8].Value = laptop.ImagenUrl;
                    worksheet.Cells[row, 9].Value = laptop.Stock;

                    package.Save();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar laptop: {ex.Message}");
            }
        }

        private int GenerarNuevoId(ExcelWorksheet worksheet)
        {
            if (worksheet.Dimension == null)
                return 1;

            int maxId = 0;
            for (int row = 2; row <= worksheet.Dimension.Rows; row++)
            {
                if (int.TryParse(worksheet.Cells[row, 1].Value?.ToString(), out int id))
                {
                    maxId = Math.Max(maxId, id);
                }
            }
            return maxId + 1;
        }

        public void ActualizarLaptop(Laptop laptop)
        {
            using (var package = new ExcelPackage(new FileInfo(ArchivoLaptops)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int rows = worksheet.Dimension.Rows;

                for (int row = 2; row <= rows; row++)
                {
                    if (int.Parse(worksheet.Cells[row, 1].Value.ToString()) == laptop.Id)
                    {
                        worksheet.Cells[row, 2].Value = laptop.Marca;
                        worksheet.Cells[row, 3].Value = laptop.Modelo;
                        worksheet.Cells[row, 4].Value = laptop.Procesador;
                        worksheet.Cells[row, 5].Value = laptop.RAM;
                        worksheet.Cells[row, 6].Value = laptop.Almacenamiento;
                        worksheet.Cells[row, 7].Value = laptop.Precio;
                        worksheet.Cells[row, 8].Value = laptop.ImagenUrl;
                        worksheet.Cells[row, 9].Value = laptop.Stock;
                        break;
                    }
                }

                package.Save();
            }

        }

        public void EliminarLaptop(int id)
        {
            using (var package = new ExcelPackage(new FileInfo(ArchivoLaptops)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int rows = worksheet.Dimension.Rows;

                for (int row = 2; row <= rows; row++)
                {
                    if (int.Parse(worksheet.Cells[row, 1].Value.ToString()) == id)
                    {
                        worksheet.DeleteRow(row);
                        break;
                    }
                }

                package.Save();
            }
        }

        public void RegistrarVenta()
        {
            var file = new FileInfo(ArchivoLaptops);

            using (var package = new ExcelPackage(file))
            {
                var hojaventas = package.Workbook.Worksheets[1];
                int cantfilas = hojaventas.Dimension.Rows;
                foreach (var laptop in this.laptops)
                {
                    hojaventas.Cells[cantfilas + 1, 1].Value = laptop.Id;
                    hojaventas.Cells[cantfilas + 1, 2].Value = laptop.Marca;
                    hojaventas.Cells[cantfilas + 1, 3].Value = laptop.Precio;
                    hojaventas.Cells[cantfilas + 1, 4].Value = DateTime.Today.ToString("dd/MM/yyyy");
                    cantfilas++;
                    var hojalaptops = package.Workbook.Worksheets[0];
                    int rows = hojalaptops.Dimension.Rows;
                    for (int row = 2; row <= rows; row++)
                    {

                        if (int.Parse(hojalaptops.Cells[row, 1].Text) == laptop.Id)
                        {
                            hojalaptops.Cells[row, 9].Value = int.Parse(hojalaptops.Cells[row, 9].Text) - 1;
                        }
                    }
                }
                package.Save();
            }
        }
        public void GenerarFactura(string nombrecom, string direccion, int numero, int codigopostal, decimal envio)
        {

            try
            { 
                string fechaActual = DateTime.Now.ToString("yyMMdd");
                Random random = new Random();
                int codigoAleatorio = random.Next(0, 1000);
                string nombreArchivo = $"Factura{fechaActual}_{codigoAleatorio:D3}.pdf";
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nombreArchivo);

                PdfWriter writer = new PdfWriter(filePath);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                PdfFont standardFont = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA);

                iText.Layout.Element.Image logo = new iText.Layout.Element.Image(ImageDataFactory.Create("images//Logo.png"));
                logo.SetFixedPosition(110, 720);
                logo.ScaleToFit(90, 90);
                document.Add(logo);

                Paragraph head = new Paragraph("Aragon Solutions S.A         \ncontactoAragon_S.A@aragonsolutions.net     ").SetFont(standardFont)
                    .SetFontSize(14)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT);

                document.Add(head);

                document.Add(new Paragraph("\n\n"));

                Paragraph header = new Paragraph("Factura")
                    .SetFont(standardFont)
                    .SetFontSize(20)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                    .SetMarginBottom(20);
                document.Add(header);
                LineSeparator separator1 = new LineSeparator(new SolidLine());
                separator1.SetWidth(520);
                separator1.SetMarginTop(20);
                document.Add(separator1);
                document.Add(new Paragraph(" "));


                Paragraph invoiceNumber = new Paragraph($"Número de factura: \t \t{codigoAleatorio}")
                .SetFont(standardFont)
                    .SetFontSize(13);
                Paragraph invoiceDate = new Paragraph("Fecha: \t\t \t" + DateTime.Now.ToString("dd/MM/yyyy"))
                    .SetFont(standardFont)
                    .SetFontSize(13);
                Paragraph customerName = new Paragraph($"Cliente: \t\t \t{nombrecom}")
                    .SetFont(standardFont)
                    .SetFontSize(13);
                Paragraph customerAddress = new Paragraph($"Dirección: \t\t {direccion}")
                    .SetFont(standardFont)
                    .SetFontSize(13);
                Paragraph customerNumber = new Paragraph($"Numero/telefono: \t\t {numero}")
                    .SetFont(standardFont)
                    .SetFontSize(13);
                Paragraph customerPostal = new Paragraph($"Codigo Postal: \t\t {codigopostal}")
                    .SetFont(standardFont)
                    .SetFontSize(13);
                

                document.Add(invoiceNumber);
                document.Add(invoiceDate);
                document.Add(customerName);
                document.Add(customerAddress);
                document.Add(customerPostal);

                document.Add(new Paragraph(" "));


                Table table = new Table(4);
                table.SetWidth(520);

                table.AddCell(new Cell().Add(new Paragraph("Cantidad"))
                    .SetBorder(new SolidBorder(1f))
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY));
                table.AddCell(new Cell().Add(new Paragraph("Descripción"))
                    .SetBorder(new SolidBorder(1f))
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY));
                table.AddCell(new Cell().Add(new Paragraph("Precio Unitario"))
                    .SetBorder(new SolidBorder(1f))
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY));
                table.AddCell(new Cell().Add(new Paragraph("Total"))
                    .SetBorder(new SolidBorder(1f))
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY));

                foreach (var laptop in this.laptops)
                {
                    table.AddCell(new Cell().Add(new Paragraph("1").SetFont(standardFont).SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT)));
                    table.AddCell(new Cell().Add(new Paragraph($"{laptop.Marca} {laptop.Modelo}").SetFont(standardFont)));
                    table.AddCell(new Cell().Add(new Paragraph($"{laptop.Precio:C}").SetFont(standardFont).SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT)));
                    table.AddCell(new Cell().Add(new Paragraph($"{laptop.Precio}").SetFont(standardFont).SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT)));

                }

                document.Add(table);


                document.Add(new Paragraph("\n\n"));
                Paragraph subtotal = new Paragraph($"Subtotal: \t ${this.laptops.Sum(laptop => laptop.Precio)}\nEnvio:   \t ${envio}")
                    .SetFont(standardFont)
                    .SetFontSize(10)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT);
                document.Add(subtotal);
                LineSeparator separator2 = new LineSeparator(new SolidLine());
                separator2.SetWidth(520);
                separator2.SetMarginTop(20);
                document.Add(separator2);

                Paragraph total = new Paragraph($"Total: \t ${this.laptops.Sum(laptop => laptop.Precio)+envio}")
                    .SetFont(standardFont)
                    .SetFontSize(10)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT);
                document.Add(total);

                Paragraph footer = new Paragraph("www.aragonsolutions.net | Términos y condiciones aplicables")
                    .SetFontSize(8)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFixedPosition(50, 50, 500);
                document.Add(footer);

                document.Close();
                this.laptops.Clear();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        // Para admin
        public int ContarVentasPorDia(int dia)
        {
            DateTime fechaConsulta = DateTime.Today.AddDays(dia);
            int contadorVentas = 0;

            using (var package = new ExcelPackage(new FileInfo(ArchivoLaptops)))
            {
                var hojaVentas = package.Workbook.Worksheets[1]; 
                int filas = hojaVentas.Dimension.Rows;

                for (int fila = 2; fila <= filas; fila++) 
                {
                    
                    var fechaVentaStr = hojaVentas.Cells[fila, 4].Text; 
                    DateTime fechaVenta;

                    
                    if (DateTime.TryParseExact(fechaVentaStr, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaVenta))
                    {

                        if (fechaVenta.Date == fechaConsulta.Date)
                        {
                            contadorVentas++;
                        }
                    }
                }
            }

            return contadorVentas;
        }
        public int ContarVentasPorMes(int mes, int anio)
        {
            DateTime fechaConsulta = new DateTime(anio, mes, 1);
            int contadorVentas = 0;

            using (var package = new ExcelPackage(new FileInfo(ArchivoLaptops)))
            {
                var hojaVentas = package.Workbook.Worksheets[1];
                int filas = hojaVentas.Dimension.Rows;

                for (int fila = 2; fila <= filas; fila++)
                {
                    var fechaVentaStr = hojaVentas.Cells[fila, 4].Text; 
                    DateTime fechaVenta;

                    if (DateTime.TryParseExact(fechaVentaStr, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaVenta))
                    {
                        
                        if (fechaVenta.Month == mes && fechaVenta.Year == anio)
                        {
                            contadorVentas++;
                        }
                    }
                }
            }

            return contadorVentas;
        }
        public int ContarVentasPorAnio(int anio)
        {
            int contadorVentas = 0;

            using (var package = new ExcelPackage(new FileInfo(ArchivoLaptops)))
            {
                var hojaVentas = package.Workbook.Worksheets[1];
                int filas = hojaVentas.Dimension.Rows;

                for (int fila = 2; fila <= filas; fila++)
                {
                    var fechaVentaStr = hojaVentas.Cells[fila, 4].Text; 
                    DateTime fechaVenta;

                    if (DateTime.TryParseExact(fechaVentaStr, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaVenta))
                    {
                        if (fechaVenta.Year == anio)
                        {
                            contadorVentas++;
                        }
                    }
                }
            }

            return contadorVentas;
        }
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (var package = new ExcelPackage(new FileInfo(Usuarios)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                if (worksheet.Dimension == null)
                {
                    return usuarios;
                }

                int rows = worksheet.Dimension.Rows;

                for (int row = 2; row <= rows; row++)
                {
                    Usuario usuario = new Usuario
                    {
                        Nombre = worksheet.Cells[row, 1].Value?.ToString(),
                        Edad = int.Parse(worksheet.Cells[row, 2].Value?.ToString() ?? "0"),
                        Email = worksheet.Cells[row, 3].Value?.ToString(),
                        Contraseña = worksheet.Cells[row, 4].Value?.ToString()
                    };
                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }

        public void EliminarUsuario(string email)
        {
            using (var package = new ExcelPackage(new FileInfo(Usuarios)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int rows = worksheet.Dimension.Rows;

                for (int row = 2; row <= rows; row++)
                {
                    if (worksheet.Cells[row, 3].Value?.ToString() == email)
                    {
                        worksheet.DeleteRow(row);
                        break;
                    }
                }

                package.Save();
            }
        }

    }
}
