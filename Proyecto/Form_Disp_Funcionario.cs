using common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form_Disp_Funcionario : Form
    {
        List<Disp_Funcionario> Disp_funcionarios = new List<Disp_Funcionario>();

        private clsVer_Disp_Funcionario clsDataGrid = new clsVer_Disp_Funcionario();

        public Form_Disp_Funcionario()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //el DataGridView se ajusta a la cantidad de datos
            this.dtv_Disp_Funcionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            try
            {
                // Obtener la lista de Dispositivos funcionarios
                Disp_funcionarios = clsDataGrid.ObtenerDispFuncionarios(1, 19022833);

                // Limpiar las filas, sin modificar las columnas
                dtv_Disp_Funcionarios.Rows.Clear();

                // Iterar la lista y agregar cada uno al DataGridView
                foreach (var Disp_funcionario in Disp_funcionarios)
                {
                    // Crear una nueva fila basada en las columnas ya existentes en el DataGridView
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtv_Disp_Funcionarios);

                    // Asignar valores a las celdas correspondientes
                    row.Cells[0].Value = Disp_funcionario.IdDispositivo;
                    row.Cells[1].Value = Disp_funcionario.IdEmpleado;
                    row.Cells[2].Value = Disp_funcionario.Sync;


                    // Agregar la fila al DataGridView
                    dtv_Disp_Funcionarios.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Form_Menú menu = new Form_Menú();
            menu.Show();
            this.Close();
        }

        private void dtv_Disp_Funcionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
