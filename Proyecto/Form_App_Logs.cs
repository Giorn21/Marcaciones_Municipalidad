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
    public partial class Form_App_Logs : Form
    {
        private clsVer_LogsApp VerLogsApp = new clsVer_LogsApp();

        List<Logs> LogsApp = new List<Logs>();
        public Form_App_Logs()
        {
            InitializeComponent();

        }

        private void Form_App_Logs_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dtv_LogsApp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                LogsApp = VerLogsApp.Ver_LogsApp();
                dtv_LogsApp.Rows.Clear();

                foreach (var log in LogsApp)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtv_LogsApp);

                    // Asignar valores a las celdas correspondientes
                    row.Cells[0].Value = log.Fecha.ToString("dd/MM/yyyy HH:mm:ss");
                    row.Cells[1].Value = log.Proceso;
                    row.Cells[2].Value = log.Accion;
                    row.Cells[3].Value = log.Descripcion;
                    row.Cells[4].Value = log.Usuario;
                    row.Cells[5].Value = log.Host;

                    dtv_LogsApp.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
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
