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

        public void InsertarHorario(Horario horario, int totalHorasSemanales)
        {
            DB.Conectar();

            try
            {
                DB.ComenzarTransaccion();

                DB.CrearComando("HorarioInsProc @Descripcion, " +
                    "@Lunes, @L_EntradaMañana, @L_SalidaMañana, @L_EntradaTarde, @L_SalidaTarde, @L_ToleranciaEntrada, @L_ToleranciaSalida, " +
                    "@Martes, @M_EntradaMañana, @M_SalidaMañana, @M_EntradaTarde, @M_SalidaTarde, @M_ToleranciaEntrada, @M_ToleranciaSalida, " +
                    "@Miercoles, @X_EntradaMañana, @X_SalidaMañana, @X_EntradaTarde, @X_SalidaTarde, @X_ToleranciaEntrada, @X_ToleranciaSalida, " +
                    "@Jueves, @J_EntradaMañana, @J_SalidaMañana, @J_EntradaTarde, @J_SalidaTarde, @J_ToleranciaEntrada, @J_ToleranciaSalida, " +
                    "@Viernes, @V_EntradaMañana, @V_SalidaMañana, @V_EntradaTarde, @V_SalidaTarde, @V_ToleranciaEntrada, @V_ToleranciaSalida, " +
                    "@Sabado, @S_EntradaMañana, @S_SalidaMañana, @S_EntradaTarde, @S_SalidaTarde, @S_ToleranciaEntrada, @S_ToleranciaSalida, " +
                    "@Domingo, @D_EntradaMañana, @D_SalidaMañana, @D_EntradaTarde, @D_SalidaTarde, @D_ToleranciaEntrada, @D_ToleranciaSalida, " +
                    "@TotalHorasSemanales");

                DB.AsignarParametroCadena("@Descripcion", "");

                DB.AsignarParametroBoolean("@Lunes", horario.Lunes);
                DB.AsignarParametroCadena("@L_EntradaMañana", horario.L_EntradaMañana == TimeSpan.MinValue ? null : horario.L_EntradaMañana.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@L_SalidaMañana", horario.L_SalidaMañana == TimeSpan.MinValue ? null : horario.L_SalidaMañana.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@L_EntradaTarde", horario.L_EntradaTarde == TimeSpan.MinValue ? null : horario.L_EntradaTarde.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@L_SalidaTarde", horario.L_SalidaTarde == TimeSpan.MinValue ? null : horario.L_SalidaTarde.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroEntero("@L_ToleranciaEntrada", horario.L_ToleranciaEntrada);
                DB.AsignarParametroEntero("@L_ToleranciaSalida", horario.L_ToleranciaSalida);
                

                DB.AsignarParametroBoolean("@Martes", horario.Martes);
                DB.AsignarParametroCadena("@M_EntradaMañana", horario.M_EntradaMañana.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@M_SalidaMañana", horario.M_SalidaMañana.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@M_EntradaTarde", horario.M_EntradaTarde.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@M_SalidaTarde", horario.M_SalidaTarde.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroEntero("@M_ToleranciaEntrada", horario.M_ToleranciaEntrada);
                DB.AsignarParametroEntero("@M_ToleranciaSalida", horario.M_ToleranciaSalida);

                DB.AsignarParametroBoolean("@Miercoles", horario.Miercoles);
                DB.AsignarParametroCadena("@X_EntradaMañana", horario.X_EntradaMañana.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@X_SalidaMañana", horario.X_SalidaMañana.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@X_EntradaTarde", horario.X_EntradaTarde.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@X_SalidaTarde", horario.X_SalidaTarde.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroEntero("@X_ToleranciaEntrada", horario.X_ToleranciaEntrada);
                DB.AsignarParametroEntero("@X_ToleranciaSalida", horario.X_ToleranciaSalida);

                DB.AsignarParametroBoolean("@Jueves", horario.Jueves);
                DB.AsignarParametroCadena("@J_EntradaMañana", horario.J_EntradaMañana.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@J_SalidaMañana", horario.J_SalidaMañana.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@J_EntradaTarde", horario.J_EntradaTarde.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@J_SalidaTarde", horario.J_SalidaTarde.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroEntero("@J_ToleranciaEntrada", horario.J_ToleranciaEntrada);
                DB.AsignarParametroEntero("@J_ToleranciaSalida", horario.J_ToleranciaSalida);

                DB.AsignarParametroBoolean("@Viernes", horario.Viernes);
                DB.AsignarParametroCadena("@V_EntradaMañana", horario.V_EntradaMañana.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@V_SalidaMañana", horario.V_SalidaMañana.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@V_EntradaTarde", horario.V_EntradaTarde.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@V_SalidaTarde", horario.V_SalidaTarde.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroEntero("@V_ToleranciaEntrada", horario.V_ToleranciaEntrada);
                DB.AsignarParametroEntero("@V_ToleranciaSalida", horario.V_ToleranciaSalida);

                DB.AsignarParametroBoolean("@Sabado", horario.Sabado);
                DB.AsignarParametroCadena("@S_EntradaMañana", horario.S_EntradaMañana.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@S_SalidaMañana", horario.S_SalidaMañana.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@S_EntradaTarde", horario.S_EntradaTarde.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@S_SalidaTarde", horario.S_SalidaTarde.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroEntero("@S_ToleranciaEntrada", horario.S_ToleranciaEntrada);
                DB.AsignarParametroEntero("@S_ToleranciaSalida", horario.S_ToleranciaSalida);

                DB.AsignarParametroBoolean("@Domingo", horario.Domingo);
                DB.AsignarParametroCadena("@D_EntradaMañana", horario.D_EntradaMañana.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@D_SalidaMañana", horario.D_SalidaMañana.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@D_EntradaTarde", horario.D_EntradaTarde.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroCadena("@D_SalidaTarde", horario.D_SalidaTarde.ToString(@"hh\:mm\:ss"));
                DB.AsignarParametroEntero("@D_ToleranciaEntrada", horario.D_ToleranciaEntrada);
                DB.AsignarParametroEntero("@D_ToleranciaSalida", horario.D_ToleranciaSalida);

                DB.AsignarParametroEntero("@TotalHorasSemanales", totalHorasSemanales);

                // Ejecutar el procedimiento almacenado
                DB.EjecutarComando();

                DB.ConfirmarTransaccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cls : " + ex.Message);
                DB.CancelarTransaccion();
            }
            DB.Desconectar();
        }

        public string GenerarNombreHorario(int idHorario, int totalHoras, string Dias)
        {
            // Generar un nombre único para el horario basado en el ID y las horas totales
            return $"HORARIO{idHorario} - {totalHoras}HRS {Dias}";
        }

        public int ObtenerProximoIdHorario()
        {
            DB.Conectar();
            DB.CrearComando("SELECT ISNULL(MAX(IdHorario), 0) + 1 FROM Horario");
            int proximoId = (int)DB.EjecutarEscalar(); // EjecutarEscalar retorna el valor en la consulta.
            DB.Desconectar();
            return proximoId;
        }

        public int CalcularTotalHoras(Horario horario)
        {
            // Calcular las horas para cada día que tiene asistencia
            int totalHoras = 0;

            // Función para calcular horas de un turno
            int CalcularHoras(TimeSpan entrada, TimeSpan salida)
            {
                // Calcular la diferencia en horas
                return (int)(salida - entrada).TotalHours;
            }

            
            // Lunes
            totalHoras += CalcularHoras(horario.L_EntradaMañana, horario.L_SalidaMañana);
            totalHoras += CalcularHoras(horario.L_EntradaTarde, horario.L_SalidaTarde);

            // Martes
            totalHoras += CalcularHoras(horario.M_EntradaMañana, horario.M_SalidaMañana);
            totalHoras += CalcularHoras(horario.M_EntradaTarde, horario.M_SalidaTarde);

            // Miércoles
            totalHoras += CalcularHoras(horario.X_EntradaMañana, horario.X_SalidaMañana);
            totalHoras += CalcularHoras(horario.X_EntradaTarde, horario.X_SalidaTarde);

            // Jueves
            totalHoras += CalcularHoras(horario.J_EntradaMañana, horario.J_SalidaMañana);
            totalHoras += CalcularHoras(horario.J_EntradaTarde, horario.J_SalidaTarde);

            // Viernes
            totalHoras += CalcularHoras(horario.V_EntradaMañana, horario.V_SalidaMañana);
            totalHoras += CalcularHoras(horario.V_EntradaTarde, horario.V_SalidaTarde);

            // Sábado
            totalHoras += CalcularHoras(horario.S_EntradaMañana, horario.S_SalidaMañana);
            totalHoras += CalcularHoras(horario.S_EntradaTarde, horario.S_SalidaTarde);

            // Domingo
            totalHoras += CalcularHoras(horario.D_EntradaMañana, horario.D_SalidaMañana);
            totalHoras += CalcularHoras(horario.D_EntradaTarde, horario.D_SalidaTarde);

            return totalHoras;
        }

        public string MostrarDias(Horario horario) 
        {
            StringBuilder dias = new StringBuilder();

            // Función auxiliar para formatear la hora
            string FormatearHora(TimeSpan hora)
            {
                return hora.ToString(@"hh\:mm");
            }

            // Lunes
            if (horario.Lunes)
            {
                if (horario.L_SalidaMañana > horario.L_SalidaTarde)
                {
                    dias.Append($"L-{FormatearHora(horario.L_EntradaMañana)}_{FormatearHora(horario.L_SalidaMañana)} ");
                }
                else if (horario.L_SalidaMañana < horario.L_SalidaTarde) 
                {
                    dias.Append($"L-{FormatearHora(horario.L_EntradaMañana)}_{FormatearHora(horario.L_SalidaTarde)} ");
                }
            }
            // Martes
            if (horario.Martes)
            {
                if (horario.M_SalidaMañana > horario.M_SalidaTarde)
                {
                    dias.Append($"M-{FormatearHora(horario.M_EntradaMañana)}_{FormatearHora(horario.M_SalidaMañana)} ");
                }
                else if (horario.M_SalidaMañana < horario.M_SalidaTarde)
                {
                    dias.Append($"M-{FormatearHora(horario.M_EntradaMañana)}_{FormatearHora(horario.M_SalidaTarde)} ");
                }
            }

            // Miércoles
            if (horario.Miercoles)
            {
                if (horario.X_SalidaMañana > horario.X_SalidaTarde)
                {
                    dias.Append($"X-{FormatearHora(horario.X_EntradaMañana)}_{FormatearHora(horario.X_SalidaMañana)} ");
                }
                else if (horario.X_SalidaMañana < horario.X_SalidaTarde)
                {
                    dias.Append($"X-{FormatearHora(horario.X_EntradaMañana)}_{FormatearHora(horario.X_SalidaTarde)} ");
                }
            }

            // Jueves
            if (horario.Jueves)
            {
                if (horario.J_SalidaMañana > horario.J_SalidaTarde)
                {
                    dias.Append($"J-{FormatearHora(horario.J_EntradaMañana)}_{FormatearHora(horario.J_SalidaMañana)} ");
                }
                else if (horario.J_SalidaMañana < horario.J_SalidaTarde)
                {
                    dias.Append($"J-{FormatearHora(horario.J_EntradaMañana)}_{FormatearHora(horario.J_SalidaTarde)} ");
                }
            }

            // Viernes
            if (horario.Viernes)
            {
                if (horario.V_SalidaMañana > horario.V_SalidaTarde)
                {
                    dias.Append($"V-{FormatearHora(horario.V_EntradaMañana)}_{FormatearHora(horario.V_SalidaMañana)} ");
                }
                else if (horario.V_SalidaMañana < horario.V_SalidaTarde)
                {
                    dias.Append($"V-{FormatearHora(horario.L_EntradaMañana)}_{FormatearHora(horario.V_SalidaTarde)} ");
                }
            }

            // Sábado
            if (horario.Sabado)
            {
                if (horario.S_SalidaMañana > horario.S_SalidaTarde)
                {
                    dias.Append($"S-{FormatearHora(horario.S_EntradaMañana)}_{FormatearHora(horario.S_SalidaMañana)} ");
                }
                else if (horario.S_SalidaMañana < horario.S_SalidaTarde)
                {
                    dias.Append($"S-{FormatearHora(horario.S_EntradaMañana)}_{FormatearHora(horario.S_SalidaTarde)} ");
                }
            }

            // Domingo
            if (horario.Domingo)
            {
                if (horario.D_SalidaMañana > horario.D_SalidaTarde)
                {
                    dias.Append($"D-{FormatearHora(horario.D_EntradaMañana)}_{FormatearHora(horario.D_SalidaMañana)} ");
                }
                else if (horario.D_SalidaMañana < horario.D_SalidaTarde)
                {
                    dias.Append($"D-{FormatearHora(horario.D_EntradaMañana)}_{FormatearHora(horario.D_SalidaTarde)} ");
                }
            }

            // Devolver el string completo sin espacios sobrantes
            return dias.ToString().Trim();
        }

    }
}
