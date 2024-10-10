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

        public Form_App_Logs(List<Logs> logs)
        {
            InitializeComponent();
            this.LogsApp = logs;
        }

        private void Form_App_Logs_Load(object sender, EventArgs e)
        {
            CargarDatos();
            check_Login.Checked = true;
        }

        private void CargarDatos()
        {
            dtv_LogsApp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Form_buscador_Logs buscador_Logs = new Form_buscador_Logs();
            buscador_Logs.Show();
            this.Close();
        }

        private void check_Login_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Login.Checked)
            {
                // Llamamos a la función para ocultar procesos de login
                FiltrarLoginEnDataGridView(true);
            }
            else
            {
                // Si no está marcado, mostramos todas las filas
                FiltrarLoginEnDataGridView(false);
            }
        }
        private void FiltrarLoginEnDataGridView(bool ocultarLogin)
        {
            foreach (DataGridViewRow fila in dtv_LogsApp.Rows)
            {

                if (ocultarLogin)
                {

                    if (fila.Cells["col_Accion"].Value != null && fila.Cells["col_Accion"].Value.ToString().ToLower().Contains("login"))
                    {
                        fila.Visible = false;
                    }
                }
                else
                {
                    fila.Visible = true;
                }
            }
        }
    }
}
