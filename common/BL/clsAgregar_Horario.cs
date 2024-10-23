using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace common
{
    public class clsAgregar_Horario
    {
        private BaseDatos DB = new BaseDatos();

        public void InsertarHorario(string descripcion,
            string lunes, string l_EntradaMañana, string l_SalidaMañana, string l_EntradaTarde, string l_SalidaTarde, int l_ToleranciaEntrada, int l_ToleranciaSalida,
            string Martes, string M_EntradaMañana, string M_SalidaMañana, string M_EntradaTarde, string M_SalidaTarde, int M_ToleranciaEntrada, int M_ToleranciaSalida,
            string Miercoles, string X_EntradaMañana, string X_SalidaMañana, string X_EntradaTarde, string X_SalidaTarde, int X_ToleranciaEntrada, int X_ToleranciaSalida,
            string Jueves, string J_EntradaMañana, string J_SalidaMañana, string J_EntradaTarde, string J_SalidaTarde, int J_ToleranciaEntrada, int J_ToleranciaSalida,
            string Viernes, string V_EntradaMañana, string V_SalidaMañana, string V_EntradaTarde, string V_SalidaTarde, int V_ToleranciaEntrada, int V_ToleranciaSalida,
            string Sabado, string S_EntradaMañana, string S_SalidaMañana, string S_EntradaTarde, string S_SalidaTarde, int S_ToleranciaEntrada, int S_ToleranciaSalida,
            string Domingo, string D_EntradaMañana, string D_SalidaMañana, string D_EntradaTarde, string D_SalidaTarde, int D_ToleranciaEntrada, int D_ToleranciaSalida,
            int totalHorasSemanales)
        {
            DB.Conectar();

            try
            {
                DB.CrearComando("HorarioInsProc @Descripcion, " +
                    "@Lunes, @L_EntradaMañana, @L_SalidaMañana, @L_EntradaTarde, @L_SalidaTarde, @L_ToletanciaEntrada, @L_ToleranciaSalida, " +
                    "@Martes, @M_EntradaMañana, @M_SalidaMañana, @M_EntradaTarde, @M_SalidaTarde, @M_ToletanciaEntrada, @M_ToleranciaSalida, " +
                    "@Miercoles, @X_EntradaMañana, @X_SalidaMañana, @X_EntradaTarde, @X_SalidaTarde, @X_ToletanciaEntrada, @X_ToleranciaSalida, " +
                    "@Jueves, @J_EntradaMañana, @J_SalidaMañana, @J_EntradaTarde, @J_SalidaTarde, @J_ToletanciaEntrada, @J_ToleranciaSalida, " +
                    "@Viernes, @V_EntradaMañana, @V_SalidaMañana, @V_EntradaTarde, @V_SalidaTarde, @V_ToletanciaEntrada, @V_ToleranciaSalida, " +
                    "@Sabado, @S_EntradaMañana, @S_SalidaMañana, @S_EntradaTarde, @S_SalidaTarde, @S_ToletanciaEntrada, @S_ToleranciaSalida, " +
                    "@Domingo, @D_EntradaMañana, @D_SalidaMañana, @D_EntradaTarde, @D_SalidaTarde, @D_ToletanciaEntrada, @D_ToleranciaSalida, ");

                DB.AgregarParametro("@Descripcion", descripcion);

                DB.AgregarParametro("@Lunes", lunes);
                DB.AgregarParametro("@L_EntradaMañana", l_EntradaMañana);
                DB.AgregarParametro("@L_SalidaMañana", l_SalidaMañana);
                DB.AgregarParametro("@L_EntradaTarde", l_EntradaTarde);
                DB.AgregarParametro("@L_SalidaTarde", l_SalidaTarde);
                DB.AgregarParametro("@L_ToleranciaEntrada", l_ToleranciaEntrada);
                DB.AgregarParametro("@L_ToleranciaSalida", l_ToleranciaSalida);
                

                DB.AgregarParametro("@Martes", Martes);
                DB.AgregarParametro("@M_EntradaMañana", M_EntradaMañana);
                DB.AgregarParametro("@M_SalidaMañana", M_SalidaMañana);
                DB.AgregarParametro("@M_EntradaTarde", M_EntradaTarde);
                DB.AgregarParametro("@M_SalidaTarde", M_SalidaTarde);
                DB.AsignarParametroEntero("@M_ToleranciaEntrada", M_ToleranciaEntrada);
                DB.AsignarParametroEntero("@M_ToleranciaSalida", M_ToleranciaSalida);

                DB.AgregarParametro("@Miercoles", Miercoles);
                DB.AgregarParametro("@X_EntradaMañana", X_EntradaMañana);
                DB.AgregarParametro("@X_SalidaMañana", X_SalidaMañana);
                DB.AgregarParametro("@X_EntradaTarde", X_EntradaTarde);
                DB.AgregarParametro("@X_SalidaTarde", X_SalidaTarde);
                DB.AsignarParametroEntero("@X_ToleranciaEntrada", X_ToleranciaEntrada);
                DB.AsignarParametroEntero("@X_ToleranciaSalida", X_ToleranciaSalida);

                DB.AgregarParametro("@Jueves", Jueves);
                DB.AgregarParametro("@J_EntradaMañana", J_EntradaMañana);
                DB.AgregarParametro("@J_SalidaMañana", J_SalidaMañana);
                DB.AgregarParametro("@J_EntradaTarde", J_EntradaTarde);
                DB.AgregarParametro("@J_SalidaTarde", J_SalidaTarde);
                DB.AsignarParametroEntero("@J_ToleranciaEntrada", J_ToleranciaEntrada);
                DB.AsignarParametroEntero("@J_ToleranciaSalida", J_ToleranciaSalida);

                DB.AgregarParametro("@Viernes", Viernes);
                DB.AgregarParametro("@V_EntradaMañana", V_EntradaMañana);
                DB.AgregarParametro("@V_SalidaMañana", V_SalidaMañana);
                DB.AgregarParametro("@V_EntradaTarde", V_EntradaTarde);
                DB.AgregarParametro("@V_SalidaTarde", V_SalidaTarde);
                DB.AsignarParametroEntero("@V_ToleranciaEntrada", V_ToleranciaEntrada);
                DB.AsignarParametroEntero("@V_ToleranciaSalida", V_ToleranciaSalida);

                DB.AgregarParametro("@Sabado", Sabado);
                DB.AgregarParametro("@S_EntradaMañana", S_EntradaMañana);
                DB.AgregarParametro("@S_SalidaMañana", S_SalidaMañana);
                DB.AgregarParametro("@S_EntradaTarde", S_EntradaTarde);
                DB.AgregarParametro("@S_SalidaTarde", S_SalidaTarde);
                DB.AsignarParametroEntero("@S_ToleranciaEntrada", S_ToleranciaEntrada);
                DB.AsignarParametroEntero("@S_ToleranciaSalida", S_ToleranciaSalida);

                DB.AgregarParametro("@Domingo", Domingo);
                DB.AgregarParametro("@D_EntradaMañana", D_EntradaMañana);
                DB.AgregarParametro("@D_SalidaMañana", D_SalidaMañana);
                DB.AgregarParametro("@D_EntradaTarde", D_EntradaTarde);
                DB.AgregarParametro("@D_SalidaTarde", D_SalidaTarde);
                DB.AsignarParametroEntero("@D_ToleranciaEntrada", D_ToleranciaEntrada);
                DB.AsignarParametroEntero("@D_ToleranciaSalida", D_ToleranciaSalida);

                DB.AgregarParametro("@TotalHorasSemanales", totalHorasSemanales);

                // Ejecutar el procedimiento almacenado
                DB.EjecutarComando();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cls : " + ex.Message);
            }
            DB.Desconectar();
        }

        public string GenerarNombreHorario(int idHorario, int totalHoras)
        {
            // Generar un nombre único para el horario basado en el ID y las horas totales
            return $"Horario_{idHorario}_Horas{totalHoras}";
        }

        public int CalcularTotalHoras(
        string l_EntradaMañana, string l_SalidaMañana, string l_EntradaTarde, string l_SalidaTarde,
        string m_EntradaMañana, string m_SalidaMañana, string m_EntradaTarde, string m_SalidaTarde,
        string x_EntradaMañana, string x_SalidaMañana, string x_EntradaTarde, string x_SalidaTarde,
        string j_EntradaMañana, string j_SalidaMañana, string j_EntradaTarde, string j_SalidaTarde,
        string v_EntradaMañana, string v_SalidaMañana, string v_EntradaTarde, string v_SalidaTarde,
        string s_EntradaMañana, string s_SalidaMañana, string s_EntradaTarde, string s_SalidaTarde,
        string d_EntradaMañana, string d_SalidaMañana, string d_EntradaTarde, string d_SalidaTarde)
        {
            // Calcular las horas para cada día que tiene asistencia
            int totalHoras = 0;

            // Lunes
            totalHoras += (int)(l_SalidaMañana - l_EntradaMañana).TotalHours;
            totalHoras += (int)(l_SalidaTarde - l_EntradaTarde).TotalHours;

            // Martes
            totalHoras += (int)(m_SalidaMañana - m_EntradaMañana).TotalHours;
            totalHoras += (int)(m_SalidaTarde - m_EntradaTarde).TotalHours;

            // Miércoles
            totalHoras += (int)(x_SalidaMañana - x_EntradaMañana).TotalHours;
            totalHoras += (int)(x_SalidaTarde - x_EntradaTarde).TotalHours;

            // Jueves
            totalHoras += (int)(j_SalidaMañana - j_EntradaMañana).TotalHours;
            totalHoras += (int)(j_SalidaTarde - j_EntradaTarde).TotalHours;

            // Viernes
            totalHoras += (int)(v_SalidaMañana - v_EntradaMañana).TotalHours;
            totalHoras += (int)(v_SalidaTarde - v_EntradaTarde).TotalHours;

            // Sábado
            totalHoras += (int)(s_SalidaMañana - s_EntradaMañana).TotalHours;
            totalHoras += (int)(s_SalidaTarde - s_EntradaTarde).TotalHours;

            totalHoras += (int)(d_SalidaMañana - d_EntradaMañana).TotalHours;
            totalHoras += (int)(d_SalidaTarde - d_EntradaTarde).TotalHours;

            return totalHoras;
        }
    }
}
