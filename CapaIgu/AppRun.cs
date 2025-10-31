using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using CapaControlador;
using System.IO;
using OfficeOpenXml;


namespace CapaIgu
{
    public partial class AppRun : Form
    {
        public AppRun()
        {
            InitializeComponent();
        }

        private void AppRun_Load(object sender, EventArgs e)
        {
            var conexion = new Conexion();

            var resultado = conexion.ProbarConexion();

            MessageBox.Show(
                resultado.mensaje,
                resultado.estado ? "Conexión exitosa" : "Error de conexión",
                MessageBoxButtons.OK,
                resultado.estado ? MessageBoxIcon.Information : MessageBoxIcon.Error
            );


            this.BeginInvoke((Action)(() => this.ActiveControl = null));
            ConfigurarDataGridView();
            ConstruirBtnCreate();
            ConstruirBtnImport();
        }


        private void dataGridViewExcel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void ConfigurarDataGridView()
        {
            try
            {
                dataGridViewExcel.Columns.Clear();
                dataGridViewExcel.AutoGenerateColumns = false;
                dataGridViewExcel.AllowUserToAddRows = false;
                dataGridViewExcel.ReadOnly = true;
                dataGridViewExcel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dataGridViewExcel.Columns.Add("Radicado", "Radicado");
                dataGridViewExcel.Columns.Add("Id", "Id");
                dataGridViewExcel.Columns.Add("Empleado", "Empleado");
                dataGridViewExcel.Columns.Add("Identificacion", "Identificacion");
                dataGridViewExcel.Columns.Add("Tipo Documental", "Tipo Documental");
                dataGridViewExcel.Columns.Add("Codigo De Barras", "Codigo De Barras");
                dataGridViewExcel.Columns.Add("Cb Documento", "Cb Documento");
                dataGridViewExcel.Columns.Add("CB Expediente", "CB Expediente");
                dataGridViewExcel.Columns.Add("CB Caja", "CB Caja");
                dataGridViewExcel.Columns.Add("Btn_IMPORT", "");
                dataGridViewExcel.Columns.Add("Btn_CREATE", "");
                dataGridViewExcel.RowHeadersVisible = false;
                dataGridViewExcel.AllowUserToResizeColumns = false;
                dataGridViewExcel.ScrollBars = ScrollBars.Vertical;
                dataGridViewExcel.BackgroundColor = Color.White;

                foreach (DataGridViewColumn column in dataGridViewExcel.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.Width = 124;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error En El DataGridView " + ex.Message);
            }

        }

        private void ConstruirBtnCreate()
        {
            try
            {
                Button objBtnCreate = new Button();

                objBtnCreate.Size = new Size(123, 21);
                objBtnCreate.FlatStyle = FlatStyle.Flat;
                objBtnCreate.UseVisualStyleBackColor = false;
                objBtnCreate.FlatAppearance.BorderSize = 0;
                objBtnCreate.FlatAppearance.MouseOverBackColor = Color.White;
                objBtnCreate.FlatAppearance.MouseDownBackColor = Color.White;

                string rutaImagen = @"C:\Developer\ExcelProcessorNET\Icons\btnCreate.jpg";

                if (System.IO.File.Exists(rutaImagen))
                {
                    Image original = Image.FromFile(rutaImagen);

                    objBtnCreate.BackgroundImage = new Bitmap(original, new Size(40, 20));
                    objBtnCreate.BackgroundImageLayout = ImageLayout.Center;
                    objBtnCreate.ImageAlign = ContentAlignment.MiddleCenter;
                }
                else
                {
                    MessageBox.Show("La imagen no se encontró en la ruta especificada: " + rutaImagen);
                }


                int margenDerecha = 1;
                int margenArriba = 2;

                objBtnCreate.Location = new Point(
                     this.ClientSize.Width - objBtnCreate.Width - margenDerecha,
                     margenArriba
                 );

                objBtnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                this.Controls.Add(objBtnCreate);
                objBtnCreate.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el botón [ConstruirBtnCreate] " + ex.Message);
            }
        }


        public void ConstruirBtnImport()
        {
            try
            {
                Button objBtnImport = new Button();

                objBtnImport.Size = new Size(123, 21);
                objBtnImport.FlatStyle = FlatStyle.Flat;
                objBtnImport.UseVisualStyleBackColor = false;
                objBtnImport.FlatAppearance.BorderSize = 0;
                objBtnImport.FlatAppearance.MouseOverBackColor = Color.White;
                objBtnImport.FlatAppearance.MouseDownBackColor = Color.White;

                string rutaImagen = @"C:\Developer\ExcelProcessorNET\Icons\btnImport.jpg";

                if (System.IO.File.Exists(rutaImagen))
                {
                    Image original = Image.FromFile(rutaImagen);

                    objBtnImport.BackgroundImage = new Bitmap(original, new Size(40, 20));
                    objBtnImport.BackgroundImageLayout = ImageLayout.Center;
                    objBtnImport.ImageAlign = ContentAlignment.MiddleCenter;
                }
                else
                {
                    MessageBox.Show("La imagen no se encontró en la ruta especificada: " + rutaImagen);
                }

                int margenDerecha = 120 + 5;
                int margenArriba = 2;

                objBtnImport.Location = new Point(
                    this.ClientSize.Width - objBtnImport.Width - margenDerecha,
                    margenArriba
                );

                objBtnImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                this.Controls.Add(objBtnImport);
                objBtnImport.BringToFront();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el botón [ConstruirBtnImport] " + ex.Message);
            }
        }


        public void ImportarDatosExcel()
        {
            try
            {
                OpenFileDialog objOpenfile = new OpenFileDialog();
                objOpenfile.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
                objOpenfile.Title = "Seleccionar archivo de Excel";

                if (objOpenfile.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = objOpenfile.FileName;
                    var listaExcel = new List<ModeloCodigoDeBarrasOrigen>();

                    // Abrir el archivo con EPPlus
                    using (var package = new ExcelPackage(new FileInfo(rutaArchivo)))
                    {
                        ExcelWorksheet hoja = package.Workbook.Worksheets[0];
                        int filas = hoja.Dimension.End.Row;
                        int columnas = hoja.Dimension.End.Column;

                        for (int row = 2; row <=filas; row++)
                        {
                            var obj = new ModeloCodigoDeBarrasOrigen
                            {
                                Radicado = Convert.ToInt64(hoja.Cells[row,1].Value ?? 0),
                                Id = Convert.ToInt64(hoja.Cells[row, 2].Value ?? 0),
                                Empleado = hoja.Cells[row, 3].Value?.ToString() ?? "",
                                Identificacion = hoja.Cells[row,4].Value?.ToString() ?? "",
                                TipoDocumental = hoja.Cells[row,5].Value?.ToString() ?? "",
                                CodigoDeBarrasRecepcion = hoja.Cells[row,6].Value?.ToString() ?? "",
                                CbDocumento = hoja.Cells[row,7].Value?.ToString() ?? "",
                                CbExpediente = hoja.Cells[row, 8].Value?.ToString() ?? "",
                                CbCaja = hoja.Cells[row, 9].Value?.ToString() ?? ""
                            };

                            listaExcel.Add(obj);
                        }
                    }

                    // Mostrar los datos en el DataGridView
                    dataGridViewExcel.Rows.Clear();
                    foreach (var item in listaExcel)
                    {
                        dataGridViewExcel.Rows.Add(
                            item.Radicado,
                            item.Id,
                            item.Empleado,
                            item.Identificacion,
                            item.TipoDocumental,
                            item.CodigoDeBarrasRecepcion,
                            item.CbDocumento,
                            item.CbExpediente,
                            item.CbCaja,
                            "", // Celda vacía para el botón IMPORT
                            "" // Celda vacía para el botón CREATE
                        );
                    }

                    // Enviar al controlador para guardar en la DB
                    CapaControladorOrigen controlador = new CapaControladorOrigen();
                    int totalGuardados = controlador .GuardarRegistrosOrigen(listaExcel);
                    MessageBox.Show($"Total de registros guardados: {totalGuardados}", "Importación completa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al importar datos desde Excel [ImportarDatosExcel]: " + ex.Message);
            }
        }


    }
}
