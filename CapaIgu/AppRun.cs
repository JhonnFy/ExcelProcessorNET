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
        }


        private void dataGridViewExcel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void ConfigurarDataGridView()
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


        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnCreate.Size = new Size(123, 21);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatAppearance.MouseOverBackColor = Color.White;
            btnCreate.FlatAppearance.MouseDownBackColor = Color.White;

            Image original = btnCreate.BackgroundImage;
            btnCreate.BackgroundImage = new Bitmap(original, new Size(40, 20));
            btnCreate.BackgroundImageLayout = ImageLayout.Center;
            btnCreate.ImageAlign = ContentAlignment.MiddleCenter;


            int margenDerecha = 1;
            int margenArriba = 2;

            btnCreate.Location = new Point(
                this.ClientSize.Width - btnCreate.Width - margenDerecha,
                margenArriba
            );

            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            btnImport.Size = new Size(123, 21);
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.UseVisualStyleBackColor = false;
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatAppearance.MouseOverBackColor = Color.White;
            btnImport.FlatAppearance.MouseDownBackColor = Color.White;

            Image original = btnImport.BackgroundImage;
            btnImport.BackgroundImage = new Bitmap(original, new Size(40, 20));
            btnImport.BackgroundImageLayout = ImageLayout.Center;
            btnImport.ImageAlign = ContentAlignment.MiddleCenter;
        }
    }
}
