using common;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form_Agregar_Horario : Form
    {
        BaseDatos DB = new BaseDatos();
        clsAgregar_Horario horario = new clsAgregar_Horario();
        
        public Form_Agregar_Horario()
        {
            InitializeComponent();

            foreach(Control c in this.Controls)
            {
                if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).ShowUpDown = true;
                    ((DateTimePicker)c).Format = DateTimePickerFormat.Time;
                    ((DateTimePicker)c).CustomFormat = "HH:mm";
                }
            }

            limpiarform();
        }

        private void limpiarform()
        {
            check_L_Asis.Checked = false;
            check_M_Asis.Checked = false;
            check_X_Asis.Checked = false;
            check_J_Asis.Checked = false;
            check_V_Asis.Checked = false;
            check_S_Asis.Checked = false;
            check_D_Asis.Checked = false;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Form_VerHorario verHorario = new Form_VerHorario();
            verHorario.Show();
            this.Close();
        }

        private void check_L_Asis_CheckedChanged(object sender, EventArgs e)
        {
            ActivarControlesDia(check_L_Asis.Checked, dtp_L_EnMañana, dtp_L_SaMañana, dtp_L_EnTarde, dtp_L_SaTarde, numUP_L_ToleEn, numUP_L_ToleSa);
        }

        private void check_M_Asis_CheckedChanged(object sender, EventArgs e)
        {
            ActivarControlesDia(check_M_Asis.Checked, dtp_M_EnMañana, dtp_M_SaMañana, dtp_M_EnTarde, dtp_M_SaTarde, numUP_M_ToleEn, numUP_M_ToleSa);
        }

        private void check_X_Asis_CheckedChanged(object sender, EventArgs e)
        {
            ActivarControlesDia(check_X_Asis.Checked, dtp_X_EnMañana, dtp_X_SaMañana, dtp_X_EnTarde, dtp_X_SaTarde, numUP_X_ToleEn, numUP_X_ToleSa);
        }

        private void check_J_Asis_CheckedChanged(object sender, EventArgs e)
        {
            ActivarControlesDia(check_J_Asis.Checked, dtp_J_EnMañana, dtp_J_SaMañana, dtp_J_EnTarde, dtp_J_SaTarde, numUP_J_ToleEn, numUP_J_ToleSa);
        }

        private void check_V_Asis_CheckedChanged(object sender, EventArgs e)
        {
            ActivarControlesDia(check_V_Asis.Checked, dtp_V_EnMañana, dtp_V_SaMañana, dtp_V_EnTarde, dtp_V_SaTarde, numUP_V_ToleEn, numUP_V_ToleSa);
        }

        private void check_S_Asis_CheckedChanged(object sender, EventArgs e)
        {
            ActivarControlesDia(check_S_Asis.Checked, dtp_S_EnMañana, dtp_S_SaMañana, dtp_S_EnTarde, dtp_S_SaTarde, numUP_S_ToleEn, numUP_S_ToleSa);
        }

        private void check_D_Asis_CheckedChanged(object sender, EventArgs e)
        {
            ActivarControlesDia(check_D_Asis.Checked, dtp_D_EnMañana, dtp_D_SaMañana, dtp_D_EnTarde, dtp_D_SaTarde, numUP_D_ToleEn, numUP_D_ToleSa);
        }

        private void ActivarControlesDia(bool habilitar, params Control[] controles)
        {
            foreach (var control in controles)
            {
                control.Enabled = habilitar;
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            try
            {
                Horario hor = new Horario()
                {
                    // Lunes
                    Lunes = check_L_Asis.Checked,
                    L_EntradaMañana = !check_L_Asis.Checked ? TimeSpan.MinValue : dtp_L_EnMañana.Value.TimeOfDay,
                    L_SalidaMañana = !check_L_Asis.Checked ? TimeSpan.MinValue : dtp_L_SaMañana.Value.TimeOfDay,
                    L_EntradaTarde = !check_L_Asis.Checked ? TimeSpan.MinValue : dtp_L_EnTarde.Value.TimeOfDay,
                    L_SalidaTarde = !check_L_Asis.Checked ? TimeSpan.MinValue : dtp_L_SaTarde.Value.TimeOfDay,
                    L_ToleranciaEntrada = (int)numUP_L_ToleEn.Value,
                    L_ToleranciaSalida = (int)numUP_L_ToleSa.Value,

                    // Martes
                    Martes = check_M_Asis.Checked,
                    M_EntradaMañana = dtp_M_EnMañana.Value.TimeOfDay,
                    M_SalidaMañana = dtp_M_SaMañana.Value.TimeOfDay,
                    M_EntradaTarde = dtp_M_EnTarde.Value.TimeOfDay,
                    M_SalidaTarde = dtp_M_SaTarde.Value.TimeOfDay,
                    M_ToleranciaEntrada = (int)numUP_M_ToleEn.Value,
                    M_ToleranciaSalida = (int)numUP_M_ToleSa.Value,

                    // Miércoles
                    Miercoles = check_X_Asis.Checked,
                    X_EntradaMañana = dtp_X_EnMañana.Value.TimeOfDay,
                    X_SalidaMañana = dtp_X_SaMañana.Value.TimeOfDay,
                    X_EntradaTarde = dtp_X_EnTarde.Value.TimeOfDay,
                    X_SalidaTarde = dtp_X_SaTarde.Value.TimeOfDay,
                    X_ToleranciaEntrada = (int)numUP_X_ToleEn.Value,
                    X_ToleranciaSalida = (int)numUP_X_ToleSa.Value,

                    // Jueves
                    Jueves = check_J_Asis.Checked,
                    J_EntradaMañana = dtp_J_EnMañana.Value.TimeOfDay,
                    J_SalidaMañana = dtp_J_SaMañana.Value.TimeOfDay,
                    J_EntradaTarde = dtp_J_EnTarde.Value.TimeOfDay,
                    J_SalidaTarde = dtp_J_SaTarde.Value.TimeOfDay,
                    J_ToleranciaEntrada = (int)numUP_J_ToleEn.Value,
                    J_ToleranciaSalida = (int)numUP_J_ToleSa.Value,

                    // Viernes
                    Viernes = check_V_Asis.Checked,
                    V_EntradaMañana = dtp_V_EnMañana.Value.TimeOfDay,
                    V_SalidaMañana = dtp_V_SaMañana.Value.TimeOfDay,
                    V_EntradaTarde = dtp_V_EnTarde.Value.TimeOfDay,
                    V_SalidaTarde = dtp_V_SaTarde.Value.TimeOfDay,
                    V_ToleranciaEntrada = (int)numUP_V_ToleEn.Value,
                    V_ToleranciaSalida = (int)numUP_V_ToleSa.Value,

                    // Sábado
                    Sabado = check_S_Asis.Checked,
                    S_EntradaMañana = dtp_S_EnMañana.Value.TimeOfDay,
                    S_SalidaMañana = dtp_S_SaMañana.Value.TimeOfDay,
                    S_EntradaTarde = dtp_S_EnTarde.Value.TimeOfDay,
                    S_SalidaTarde = dtp_S_SaTarde.Value.TimeOfDay,
                    S_ToleranciaEntrada = (int)numUP_S_ToleEn.Value,
                    S_ToleranciaSalida = (int)numUP_S_ToleSa.Value,

                    // Domingo
                    Domingo = check_D_Asis.Checked,
                    D_EntradaMañana = dtp_D_EnMañana.Value.TimeOfDay,
                    D_SalidaMañana = dtp_D_SaMañana.Value.TimeOfDay,
                    D_EntradaTarde = dtp_D_EnTarde.Value.TimeOfDay,
                    D_SalidaTarde = dtp_D_SaTarde.Value.TimeOfDay,
                    D_ToleranciaEntrada = (int)numUP_D_ToleEn.Value,
                    D_ToleranciaSalida = (int)numUP_D_ToleSa.Value
                };

                // Calcular las horas totales
                int totalHorasSemanales = horario.CalcularTotalHoras(hor);

                int NextID = horario.ObtenerProximoIdHorario();

                string Dias = horario.MostrarDias(hor);

                string NombreHorario = horario.GenerarNombreHorario(NextID, totalHorasSemanales, Dias);

                // Insertar el horario en la base de datos
                horario.InsertarHorario(hor, totalHorasSemanales);

                MessageBox.Show("Se a agregado un nuevo Horario llamado: " + NombreHorario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Form: " + ex.Message);
            }
        }
    }
}
