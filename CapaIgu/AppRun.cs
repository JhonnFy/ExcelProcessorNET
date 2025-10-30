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


            //Evita que cualquier control reciba foco al cargar
            this.BeginInvoke((Action)(() => this.ActiveControl = null));
            ConfigurarDataGridView();
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

            //Cordenadas De Las Columas
            Rectangle rctImport = dataGridViewExcel.GetCellDisplayRectangle(
                dataGridViewExcel.Columns["Btn_IMPORT"].Index, -1, true);
            Rectangle objCreate = dataGridViewExcel.GetCellDisplayRectangle(
                dataGridViewExcel.Columns["Btn_CREATE"].Index, -1, true
            );

            foreach (DataGridViewColumn column in dataGridViewExcel.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.Width = 124;
            }
                    
        }

        private void dataGridViewExcel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    }
}
