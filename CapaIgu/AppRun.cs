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
using System.IO.Compression;


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

        private void InsertarDatosDataGridView(List<ModeloCodigoDeBarrasOrigen> lista)
        {
            try
            {
                dataGridViewExcel.Rows.Clear();

                foreach (var atributo in lista)
                {
                    dataGridViewExcel.Rows.Add(
                        atributo.Radicado,
                        atributo.Id,
                        atributo.Empleado,
                        atributo.Identificacion,
                        atributo.TipoDocumental,
                        atributo.CodigoDeBarrasRecepcion,
                        atributo.CbDocumento,
                        atributo.CbExpediente,
                        atributo.CbCaja,
                        "",
                        ""
                    );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [InsertarDatosDataGridView] " + ex.Message);
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


                //Evento Click
                objBtnImport.Click += (s, e) =>
                {
                    try
                    {
                        OpenFileDialog dialog = new OpenFileDialog
                        {
                            Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*",
                            Title = "Seleccionar Archivo Excel"
                        };

                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            string rutaArchivo = dialog.FileName;

                            //Enviar Al Controlador
                            var controlador = new CapaControladorOrigen();
                            //var lista = controlador.ImportarDesdeExcel(rutaArchivo);
                            //InsertarDatosDataGridView(lista);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error En Evento Click Del Btn Import " +ex.Message);
                    }
                };


                objBtnImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                this.Controls.Add(objBtnImport);
                objBtnImport.BringToFront();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el botón [ConstruirBtnImport] " + ex.Message);
            }
        }


        

    }
}
