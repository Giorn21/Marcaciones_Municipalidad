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
    public partial class Form_Dispositivos : Form
    {
        List<Dispositivo> dispositivo = new List<Dispositivo>();

        private clsVer_Dispositivos clsDataGrid = new clsVer_Dispositivos();
        public Form_Dispositivos()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            //el DataGridView se ajusta a la cantidad de datos
            this.dtv_Dispositivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            try
            {
                // Obtener la lista de Dispositivos funcionarios
                dispositivo = clsDataGrid.ObtenerDispositivos(1);

                // Limpiar las filas, sin modificar las columnas
                dtv_Dispositivos.Rows.Clear();

                // Iterar la lista y agregar cada uno al DataGridView
                foreach (var Disp_funcionario in dispositivo)
                {
                    // Crear una nueva fila basada en las columnas ya existentes en el DataGridView
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtv_Dispositivos);

                    // Asignar valores a las celdas correspondientes
                    row.Cells[0].Value = Disp_funcionario.IdDispositivo;
                    row.Cells[1].Value = Disp_funcionario.Descripcion;
                    row.Cells[2].Value = Disp_funcionario.IP;
                    row.Cells[3].Value = Disp_funcionario.Mac;
                    row.Cells[4].Value = Disp_funcionario.Ubicacion;
                    row.Cells[5].Value = Disp_funcionario.PushProtocol;
                    row.Cells[6].Value = Disp_funcionario.UploadFlag;
                    row.Cells[7].Value = Disp_funcionario.LastActivityLog;
                    row.Cells[8].Value = Disp_funcionario.LastActivityOP;


                    // Agregar la fila al DataGridView
                    dtv_Dispositivos.Rows.Add(row);
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
            Form_Menu menu = new Form_Menu();
            menu.Show();
            this.Close();
        }
    }
}
