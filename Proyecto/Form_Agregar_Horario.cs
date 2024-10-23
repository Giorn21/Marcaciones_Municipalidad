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
            if (check_D_Asis.Checked == false)
            {
                ActivarControlesDia(check_D_Asis.Checked, dtp_D_EnMañana, dtp_D_SaMañana, dtp_D_EnTarde, dtp_D_SaTarde, numUP_D_ToleEn, numUP_D_ToleSa);

            }
            else 
            {
                dtp_D_EnMañana = null;
                dtp_D_SaMañana = null;
                dtp_D_EnTarde = null;
                dtp_D_SaTarde = null;
                numUP_D_ToleEn = null;
                numUP_D_ToleSa = null;
            }
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
                // Variables para el horario
                string descripcion = lbl_Descripcion.Text;

                // Lunes
                string lunes = check_L_Asis.Checked ? "S" : "N";
                string l_EntradaMañana = dtp_L_EnMañana.Value.ToString();
                string l_SalidaMañana = dtp_L_SaMañana.Value.ToString();
                string l_EntradaTarde = dtp_L_EnTarde.Value.ToString();
                string l_SalidaTarde = dtp_L_SaTarde.Value.ToString();
                int l_ToleranciaEntrada = int.Parse(numUP_L_ToleEn.Text);
                int l_ToleranciaSalida = int.Parse(numUP_L_ToleSa.Text);

                // Martes
                string martes = check_M_Asis.Checked ? "S" : "N";
                string m_EntradaMañana = dtp_M_EnMañana.Value.ToString();
                string m_SalidaMañana = dtp_M_SaMañana.Value.ToString();
                string m_EntradaTarde = dtp_M_EnTarde.Value.ToString();
                string m_SalidaTarde = dtp_M_SaTarde.Value.ToString();
                int m_ToleranciaEntrada = int.Parse(numUP_M_ToleEn.Text);
                int m_ToleranciaSalida = int.Parse(numUP_M_ToleSa.Text);

                // Miércoles
                string miercoles = check_X_Asis.Checked ? "S" : "N";
                string x_EntradaMañana = dtp_X_EnMañana.Value.ToString();
                string x_SalidaMañana = dtp_X_SaMañana.Value.ToString();
                string x_EntradaTarde = dtp_X_EnTarde.Value.ToString();
                string x_SalidaTarde = dtp_X_SaTarde.Value.ToString();
                int x_ToleranciaEntrada = int.Parse(numUP_X_ToleEn.Text);
                int x_ToleranciaSalida = int.Parse(numUP_X_ToleSa.Text);

                // Jueves
                string jueves = check_J_Asis.Checked ? "S" : "N";
                string j_EntradaMañana = dtp_J_EnMañana.Value.ToString();
                string j_SalidaMañana = dtp_J_SaMañana.Value.ToString();
                string j_EntradaTarde = dtp_J_EnTarde.Value.ToString();
                string j_SalidaTarde = dtp_J_SaTarde.Value.ToString();
                int j_ToleranciaEntrada = int.Parse(numUP_J_ToleEn.Text);
                int j_ToleranciaSalida = int.Parse(numUP_J_ToleSa.Text);

                // Viernes
                string viernes = check_V_Asis.Checked ? "S" : "N";
                string v_EntradaMañana = dtp_V_EnMañana.Value.ToString();
                string v_SalidaMañana = dtp_V_SaMañana.Value.ToString();
                string v_EntradaTarde = dtp_V_EnTarde.Value.ToString();
                string v_SalidaTarde = dtp_V_SaTarde.Value.ToString();
                int v_ToleranciaEntrada = int.Parse(numUP_V_ToleEn.Text);
                int v_ToleranciaSalida = int.Parse(numUP_V_ToleSa.Text);

                // Sábado
                string sabado = check_S_Asis.Checked ? "S" : "N";
                string s_EntradaMañana = dtp_S_EnMañana.Value.ToString();
                string s_SalidaMañana = dtp_S_SaMañana.Value.ToString();
                string s_EntradaTarde = dtp_S_EnTarde.Value.ToString();
                string s_SalidaTarde = dtp_S_SaTarde.Value.ToString();
                int s_ToleranciaEntrada = int.Parse(numUP_S_ToleEn.Text);
                int s_ToleranciaSalida = int.Parse(numUP_S_ToleSa.Text);

                // Domingo
                string domingo = check_D_Asis.Checked ? "S" : "N";
                string d_EntradaMañana = dtp_D_EnMañana.Value.ToString();
                string d_SalidaMañana = dtp_D_SaMañana.Value.ToString();
                string d_EntradaTarde = dtp_D_EnTarde.Value.ToString();
                string d_SalidaTarde = dtp_D_SaTarde.Value.ToString();
                int d_ToleranciaEntrada = int.Parse(numUP_D_ToleEn.Text);
                int d_ToleranciaSalida = int.Parse(numUP_D_ToleSa.Text);

                // Calcular las horas totales
                int totalHorasSemanales = horario.CalcularTotalHoras(
                    l_EntradaMañana, l_SalidaMañana, l_EntradaTarde, l_SalidaTarde,
                    m_EntradaMañana, m_SalidaMañana, m_EntradaTarde, m_SalidaTarde,
                    x_EntradaMañana, x_SalidaMañana, x_EntradaTarde, x_SalidaTarde,
                    j_EntradaMañana, j_SalidaMañana, j_EntradaTarde, j_SalidaTarde,
                    v_EntradaMañana, v_SalidaMañana, v_EntradaTarde, v_SalidaTarde,
                    s_EntradaMañana, s_SalidaMañana, s_EntradaTarde, s_SalidaTarde,
                    d_EntradaMañana, d_SalidaMañana, d_EntradaTarde, d_SalidaTarde);

                // Insertar el horario en la base de datos
                horario.InsertarHorario(
                    descripcion,
                    lunes, l_EntradaMañana, l_SalidaMañana, l_EntradaTarde, l_SalidaTarde, l_ToleranciaEntrada, l_ToleranciaSalida,
                    martes, m_EntradaMañana, m_SalidaMañana, m_EntradaTarde, m_SalidaTarde, m_ToleranciaEntrada, m_ToleranciaSalida,
                    miercoles, x_EntradaMañana, x_SalidaMañana, x_EntradaTarde, x_SalidaTarde, x_ToleranciaEntrada, x_ToleranciaSalida,
                    jueves, j_EntradaMañana, j_SalidaMañana, j_EntradaTarde, j_SalidaTarde, j_ToleranciaEntrada, j_ToleranciaSalida,
                    viernes, v_EntradaMañana, v_SalidaMañana, v_EntradaTarde, v_SalidaTarde, v_ToleranciaEntrada, v_ToleranciaSalida,
                    sabado, s_EntradaMañana, s_SalidaMañana, s_EntradaTarde, s_SalidaTarde, s_ToleranciaEntrada, s_ToleranciaSalida,
                    domingo, d_EntradaMañana, d_SalidaMañana, d_EntradaTarde, d_SalidaTarde, d_ToleranciaEntrada, d_ToleranciaSalida,
                    totalHorasSemanales);

                MessageBox.Show("Horario guardado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int ObtenerProximoIdHorario()
        {
            DB.Conectar();
            DB.CrearComando("SELECT ISNULL(MAX(IdHorario), 0) + 1 FROM Horario");
            int proximoId = (int)DB.EjecutarEscalar(); // EjecutarEscalar retorna el valor en la consulta.
            DB.Desconectar();
            return proximoId;
        }
    }
}
