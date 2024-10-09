using common;
using common.BL;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static common.clsBuscadorLogs;

namespace Proyecto
{
    public partial class Form_buscador_Logs : Form
    {
        private clsBuscarLogs buscador = new clsBuscarLogs();
        private clsDatos_cboxBuscadorLogs cargarDatos = new clsDatos_cboxBuscadorLogs();

        public Form_buscador_Logs()
        {
            InitializeComponent();
            clsBuscarLogs buscador = new clsBuscarLogs();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.Show();
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            DateTime desde = DTP_Desde.Value;
            DateTime hasta = DTP_Hasta.Value;

            string proceso = cbox_Proceso.Text == "Seleccione" ? null : cbox_Proceso.SelectedItem?.ToString();
            string usuario = cbox_Usuario.Text == "Seleccione" ? null : cbox_Usuario.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(proceso))
            {
                proceso = null;
            }

            if (string.IsNullOrEmpty(usuario))
            {
                usuario = null;
            }

            string descripcion = txt_Descripcion.Text.Trim();

            // Llama a la clase de búsqueda
            var logs = buscador.BuscarLogs(desde, hasta, proceso, descripcion, usuario);

            // Abre el formulario con los resultados
            Form_App_Logs formLogs = new Form_App_Logs(logs);
            formLogs.Show();
            this.Close();
        }

        private void btn_FullDate_Click(object sender, EventArgs e)
        {
            DateTime desde = new DateTime(2023, 1, 1);
            DateTime hasta = DateTime.Now;

            var logs = buscador.BuscarLogs(desde, hasta, null, null, null);

            // Abre el formulario con todos los registros
            Form_App_Logs formLogs = new Form_App_Logs(logs);
            formLogs.Show();
            this.Close();
        }

        private void MostrarResultados(List<Logs> logs)
        {
            Form_App_Logs formLogs = new Form_App_Logs(logs);
            formLogs.Show();
            this.Close();
        }

        private clsDatos_cboxBuscadorLogs cargadorDatos = new clsDatos_cboxBuscadorLogs();

        private void Form_buscador_Logs_Load(object sender, EventArgs e)
        {
            DTP_Desde.Value = new DateTime(2024, 9, 30, 8, 0, 0); // 8 AM de hoy
            DTP_Hasta.Value = DateTime.Now.Date; 

            try
            {
                // Cargar datos en los ComboBox
                cbox_Proceso.DataSource = cargadorDatos.CargarProcesos();
                cbox_Usuario.DataSource = cargadorDatos.CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos en ComboBox: " + ex.Message);
            }
        }
    }
}
