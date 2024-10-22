using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data.Common;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace common
{
    public class clsVer_Horarios
    {
        readonly BaseDatos DB = new BaseDatos();

        clsVer_Horarios current = null;

        #region Propiedades;
        string toxml;
        int count;
        public int Count
        {
            get { return count; }
        }
        #endregion

        #region Tipo Datos
        #endregion

        #region Metodos Publicos

        private string usuario;
        private string host;

        public string Host
        {
            get { return host; }
            set { host = value; }
        }

        public List<Horario> DataSource { get; set; }

        public clsVer_Horarios()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion


        private string connectionString = "Data Source=APOLO;Initial Catalog=SGM1;Persist Security Info=True;User ID=greyesmarcaciones;Password=1234;Encrypt=True;TrustServerCertificate=True;";

        // Método para obtener los datos desde la base de datos y mapear a la clase Horario
        public Horario ObtenerHorario(int idHorario)
        {
            Horario horario = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Horario WHERE IdHorario = @IdHorario";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdHorario", idHorario);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        horario = new Horario
                        {
                            IdHorario = idHorario,
                            Descripcion = reader["Descripcion"].ToString(),

                            // Lunes
                            L_EntradaMañana = !string.IsNullOrEmpty(reader["L_EntradaMañana"].ToString()) ? (TimeSpan)reader["L_EntradaMañana"] : TimeSpan.MinValue,
                            L_SalidaMañana = !string.IsNullOrEmpty(reader["L_SalidaMañana"].ToString()) ? (TimeSpan)reader["L_SalidaMañana"] : TimeSpan.MinValue,
                            L_EntradaTarde = !string.IsNullOrEmpty(reader["L_EntradaTarde"].ToString()) ? (TimeSpan)reader["L_EntradaTarde"] : TimeSpan.MinValue,
                            L_SalidaTarde = !string.IsNullOrEmpty(reader["L_SalidaTarde"].ToString()) ? (TimeSpan)reader["L_SalidaTarde"] : TimeSpan.MinValue,
                            L_ToleranciaEntrada = !string.IsNullOrEmpty(reader["L_ToleranciaEntrada"].ToString()) ? Convert.ToInt32(reader["L_ToleranciaEntrada"]) : 0,
                            L_ToleranciaSalida = !string.IsNullOrEmpty(reader["L_ToleranciaSalida"].ToString()) ? Convert.ToInt32(reader["L_ToleranciaSalida"]) : 0,

                            // Martes
                            M_EntradaMañana = !string.IsNullOrEmpty(reader["M_EntradaMañana"].ToString()) ? (TimeSpan)reader["M_EntradaMañana"] : TimeSpan.MinValue,
                            M_SalidaMañana = !string.IsNullOrEmpty(reader["M_SalidaMañana"].ToString()) ? (TimeSpan)reader["M_SalidaMañana"] : TimeSpan.MinValue,
                            M_EntradaTarde = !string.IsNullOrEmpty(reader["M_EntradaTarde"].ToString()) ? (TimeSpan)reader["M_EntradaTarde"] : TimeSpan.MinValue,
                            M_SalidaTarde = !string.IsNullOrEmpty(reader["M_SalidaTarde"].ToString()) ? (TimeSpan)reader["M_SalidaTarde"] : TimeSpan.MinValue,
                            M_ToleranciaEntrada = !string.IsNullOrEmpty(reader["M_ToleranciaEntrada"].ToString()) ? Convert.ToInt32(reader["M_ToleranciaEntrada"]) : 0,
                            M_ToleranciaSalida = !string.IsNullOrEmpty(reader["M_ToleranciaSalida"].ToString()) ? Convert.ToInt32(reader["M_ToleranciaSalida"]) : 0,

                            // Miércoles
                            X_EntradaMañana = !string.IsNullOrEmpty(reader["X_EntradaMañana"].ToString()) ? (TimeSpan)reader["X_EntradaMañana"] : TimeSpan.MinValue,
                            X_SalidaMañana = !string.IsNullOrEmpty(reader["X_SalidaMañana"].ToString()) ? (TimeSpan)reader["X_SalidaMañana"] : TimeSpan.MinValue,
                            X_EntradaTarde = !string.IsNullOrEmpty(reader["X_EntradaTarde"].ToString()) ? (TimeSpan)reader["X_EntradaTarde"] : TimeSpan.MinValue,
                            X_SalidaTarde = !string.IsNullOrEmpty(reader["X_SalidaTarde"].ToString()) ? (TimeSpan)reader["X_SalidaTarde"] : TimeSpan.MinValue,
                            X_ToleranciaEntrada = !string.IsNullOrEmpty(reader["X_ToleranciaEntrada"].ToString()) ? Convert.ToInt32(reader["X_ToleranciaEntrada"]) : 0,
                            X_ToleranciaSalida = !string.IsNullOrEmpty(reader["X_ToleranciaSalida"].ToString()) ? Convert.ToInt32(reader["X_ToleranciaSalida"]) : 0,

                            // Jueves
                            J_EntradaMañana = !string.IsNullOrEmpty(reader["J_EntradaMañana"].ToString()) ? (TimeSpan)reader["J_EntradaMañana"] : TimeSpan.MinValue,
                            J_SalidaMañana = !string.IsNullOrEmpty(reader["J_SalidaMañana"].ToString()) ? (TimeSpan)reader["J_SalidaMañana"] : TimeSpan.MinValue,
                            J_EntradaTarde = !string.IsNullOrEmpty(reader["J_EntradaTarde"].ToString()) ? (TimeSpan)reader["J_EntradaTarde"] : TimeSpan.MinValue,
                            J_SalidaTarde = !string.IsNullOrEmpty(reader["J_SalidaTarde"].ToString()) ? (TimeSpan)reader["J_SalidaTarde"] : TimeSpan.MinValue,
                            J_ToleranciaEntrada = !string.IsNullOrEmpty(reader["J_ToleranciaEntrada"].ToString()) ? Convert.ToInt32(reader["J_ToleranciaEntrada"]) : 0,
                            J_ToleranciaSalida = !string.IsNullOrEmpty(reader["J_ToleranciaSalida"].ToString()) ? Convert.ToInt32(reader["J_ToleranciaSalida"]) : 0,

                            // Viernes
                            V_EntradaMañana = !string.IsNullOrEmpty(reader["V_EntradaMañana"].ToString()) ? (TimeSpan)reader["V_EntradaMañana"] : TimeSpan.MinValue,
                            V_SalidaMañana = !string.IsNullOrEmpty(reader["V_SalidaMañana"].ToString()) ? (TimeSpan)reader["V_SalidaMañana"] : TimeSpan.MinValue,
                            V_EntradaTarde = !string.IsNullOrEmpty(reader["V_EntradaTarde"].ToString()) ? (TimeSpan)reader["V_EntradaTarde"] : TimeSpan.MinValue,
                            V_SalidaTarde = !string.IsNullOrEmpty(reader["V_SalidaTarde"].ToString()) ? (TimeSpan)reader["V_SalidaTarde"] : TimeSpan.MinValue,
                            V_ToleranciaEntrada = !string.IsNullOrEmpty(reader["V_ToleranciaEntrada"].ToString()) ? Convert.ToInt32(reader["V_ToleranciaEntrada"]) : 0,
                            V_ToleranciaSalida = !string.IsNullOrEmpty(reader["V_ToleranciaSalida"].ToString()) ? Convert.ToInt32(reader["V_ToleranciaSalida"]) : 0,

                            // Sábado
                            S_EntradaMañana = !string.IsNullOrEmpty(reader["S_EntradaMañana"].ToString()) ? (TimeSpan)reader["S_EntradaMañana"] : TimeSpan.MinValue,
                            S_SalidaMañana = !string.IsNullOrEmpty(reader["S_SalidaMañana"].ToString()) ? (TimeSpan)reader["S_SalidaMañana"] : TimeSpan.MinValue,
                            S_EntradaTarde = !string.IsNullOrEmpty(reader["S_EntradaTarde"].ToString()) ? (TimeSpan)reader["S_EntradaTarde"] : TimeSpan.MinValue,
                            S_SalidaTarde = !string.IsNullOrEmpty(reader["S_SalidaTarde"].ToString()) ? (TimeSpan)reader["S_SalidaTarde"] : TimeSpan.MinValue,
                            S_ToleranciaEntrada = !string.IsNullOrEmpty(reader["S_ToleranciaEntrada"].ToString()) ? Convert.ToInt32(reader["S_ToleranciaEntrada"]) : 0,
                            S_ToleranciaSalida = !string.IsNullOrEmpty(reader["S_ToleranciaSalida"].ToString()) ? Convert.ToInt32(reader["S_ToleranciaSalida"]) : 0,

                            // Domingo
                            D_EntradaMañana = !string.IsNullOrEmpty(reader["D_EntradaMañana"].ToString()) ? (TimeSpan)reader["D_EntradaMañana"] : TimeSpan.MinValue,
                            D_SalidaMañana = !string.IsNullOrEmpty(reader["D_SalidaMañana"].ToString()) ? (TimeSpan)reader["D_SalidaMañana"] : TimeSpan.MinValue,
                            D_EntradaTarde = !string.IsNullOrEmpty(reader["D_EntradaTarde"].ToString()) ? (TimeSpan)reader["D_EntradaTarde"] : TimeSpan.MinValue,
                            D_SalidaTarde = !string.IsNullOrEmpty(reader["D_SalidaTarde"].ToString()) ? (TimeSpan)reader["D_SalidaTarde"] : TimeSpan.MinValue,
                            D_ToleranciaEntrada = !string.IsNullOrEmpty(reader["D_ToleranciaEntrada"].ToString()) ? Convert.ToInt32(reader["D_ToleranciaEntrada"]) : 0,
                            D_ToleranciaSalida = !string.IsNullOrEmpty(reader["D_ToleranciaSalida"].ToString()) ? Convert.ToInt32(reader["D_ToleranciaSalida"]) : 0,

                            // Total de Horas semanales
                            TotalHorasSemanales = reader["TotalHorasSemanales"] != DBNull.Value ? Convert.ToInt32(reader["TotalHorasSemanales"]) : 0
                        };
                    }
                }
            }

            return horario;
        }

        // Método para obtener los datos y llenar el DataTable formateado
        public DataTable ObtenerHorarioFormateado(int idHorario)
        {
            Horario horario = ObtenerHorario(idHorario);
            DataTable dtFormatted = new DataTable();
            dtFormatted.Columns.Add("Dia");
            dtFormatted.Columns.Add("EntradaMañana");
            dtFormatted.Columns.Add("SalidaMañana");
            dtFormatted.Columns.Add("EntradaTarde");
            dtFormatted.Columns.Add("SalidaTarde");
            dtFormatted.Columns.Add("ToleranciaEntrada");
            dtFormatted.Columns.Add("TotalHoras");

            if (horario != null)
            {
                dtFormatted.Rows.Add("Lunes",
                horario.L_EntradaMañana == TimeSpan.MinValue ? null : (object)horario.L_EntradaMañana,
                horario.L_SalidaMañana == TimeSpan.MinValue ? null : (object)horario.L_SalidaMañana,
                horario.L_EntradaTarde == TimeSpan.MinValue ? null : (object)horario.L_EntradaTarde,
                horario.L_SalidaTarde == TimeSpan.MinValue ? null : (object)horario.L_SalidaTarde,
                horario.L_ToleranciaEntrada != 0 ? (object)horario.L_ToleranciaEntrada : 0,
                CalcularHorasTrabajadas(
                    horario.L_EntradaMañana.ToString(),
                    horario.L_SalidaMañana.ToString(),
                    horario.L_EntradaTarde.ToString(),
                    horario.L_SalidaTarde.ToString()));

                dtFormatted.Rows.Add("Martes",
                    horario.M_EntradaMañana == TimeSpan.MinValue ? null : (object)horario.M_EntradaMañana ,
                    horario.M_SalidaMañana == TimeSpan.MinValue ? null : (object)horario.M_SalidaMañana ,
                    horario.M_EntradaTarde == TimeSpan.MinValue ? null : (object)horario.M_EntradaTarde ,
                    horario.M_SalidaTarde == TimeSpan.MinValue ? null : (object)horario.M_SalidaTarde ,
                    horario.M_ToleranciaEntrada != 0 ? (object)horario.M_ToleranciaEntrada : 0,
                    CalcularHorasTrabajadas(
                        horario.M_EntradaMañana.ToString(),
                        horario.M_SalidaMañana.ToString(),
                        horario.M_EntradaTarde.ToString(),
                        horario.M_SalidaTarde.ToString()));

                dtFormatted.Rows.Add("Miercoles",
                    horario.X_EntradaMañana == TimeSpan.MinValue ? null : (object)horario.X_EntradaMañana ,
                    horario.X_SalidaMañana == TimeSpan.MinValue ? null : (object)horario.X_SalidaMañana ,
                    horario.X_EntradaTarde == TimeSpan.MinValue ? null : (object)horario.X_EntradaTarde ,
                    horario.X_SalidaTarde == TimeSpan.MinValue ? null : (object)horario.X_SalidaTarde ,
                    horario.X_ToleranciaEntrada != 0 ? (object)horario.X_ToleranciaEntrada : 0,
                    CalcularHorasTrabajadas(
                        horario.X_EntradaMañana.ToString(),
                        horario.X_SalidaMañana.ToString(),
                        horario.X_EntradaTarde.ToString(),
                        horario.X_SalidaTarde.ToString()));

                dtFormatted.Rows.Add("Jueves",
                    horario.J_EntradaMañana == TimeSpan.MinValue ? null : (object)horario.J_EntradaMañana ,
                    horario.J_SalidaMañana == TimeSpan.MinValue ? null : (object)horario.J_SalidaMañana ,
                    horario.J_EntradaTarde == TimeSpan.MinValue ? null : (object)horario.J_EntradaTarde ,
                    horario.J_SalidaTarde == TimeSpan.MinValue ? null : (object)horario.J_SalidaTarde ,
                    horario.J_ToleranciaEntrada != 0 ? (object)horario.J_ToleranciaEntrada : 0,
                    CalcularHorasTrabajadas(
                        horario.J_EntradaMañana.ToString(),
                        horario.J_SalidaMañana.ToString(),
                        horario.J_EntradaTarde.ToString(),
                        horario.J_SalidaTarde.ToString()));

                dtFormatted.Rows.Add("Viernes",
                    horario.V_EntradaMañana == TimeSpan.MinValue ? null : (object)horario.V_EntradaMañana ,
                    horario.V_SalidaMañana == TimeSpan.MinValue ? null : (object)horario.V_SalidaMañana ,
                    horario.V_EntradaTarde == TimeSpan.MinValue ? null : (object)horario.V_EntradaTarde ,
                    horario.V_SalidaTarde == TimeSpan.MinValue ? null : (object)horario.V_SalidaTarde ,
                    horario.V_ToleranciaEntrada != 0 ? (object)horario.V_ToleranciaEntrada : 0,
                    CalcularHorasTrabajadas(
                        horario.V_EntradaMañana.ToString(),
                        horario.V_SalidaMañana.ToString(),
                        horario.V_EntradaTarde.ToString(),
                        horario.V_SalidaTarde.ToString()));

                dtFormatted.Rows.Add("Sabado",
                    horario.S_EntradaMañana == TimeSpan.MinValue ? null : (object)horario.S_EntradaMañana,
                    horario.S_SalidaMañana == TimeSpan.MinValue ? null : (object)horario.S_SalidaMañana ,
                    horario.S_EntradaTarde == TimeSpan.MinValue ? null : (object)horario.S_EntradaTarde ,
                    horario.S_SalidaTarde == TimeSpan.MinValue ? null : (object)horario.S_SalidaTarde ,
                    horario.S_ToleranciaEntrada != 0 ? (object)horario.S_ToleranciaEntrada : 0,
                    CalcularHorasTrabajadas(
                        horario.S_EntradaMañana.ToString(),
                        horario.S_SalidaMañana.ToString(),
                        horario.S_EntradaTarde.ToString(),
                        horario.S_SalidaTarde.ToString()));

                dtFormatted.Rows.Add("Domingo",
                    horario.D_EntradaMañana == TimeSpan.MinValue ? null : (object)horario.D_EntradaMañana ,
                    horario.D_SalidaMañana == TimeSpan.MinValue ? null : (object)horario.D_SalidaMañana ,
                    horario.D_EntradaTarde == TimeSpan.MinValue ? null : (object)horario.D_EntradaTarde ,
                    horario.D_SalidaTarde == TimeSpan.MinValue ? null : (object)horario.D_SalidaTarde ,
                    horario.D_ToleranciaEntrada != 0 ? (object)horario.D_ToleranciaEntrada : 0,
                    CalcularHorasTrabajadas(
                        horario.D_EntradaMañana.ToString(),
                        horario.D_SalidaMañana.ToString(),
                        horario.D_EntradaTarde.ToString(),
                        horario.D_SalidaTarde.ToString()));

                // Mostrar el total de horas semanales
                dtFormatted.Rows.Add("Total Horas Semanales", "--->", "--->", "--->", "--->", "--->", CalcularTotalHoras(horario));
            }

            return dtFormatted;
        }

        public int CalcularTotalHoras(Horario horario)
        {
            // Suma las horas de todos los días de la semana para obtener el total semanal.
            double totalHoras = 0;

            totalHoras += CalcularHorasTrabajadas(horario.L_EntradaMañana.ToString(), horario.L_SalidaMañana.ToString(), horario.L_EntradaTarde.ToString(), horario.L_SalidaTarde.ToString()).TotalHours;
            totalHoras += CalcularHorasTrabajadas(horario.M_EntradaMañana.ToString(), horario.M_SalidaMañana.ToString(), horario.M_EntradaTarde.ToString(), horario.M_SalidaTarde.ToString()).TotalHours;
            totalHoras += CalcularHorasTrabajadas(horario.X_EntradaMañana.ToString(), horario.X_SalidaMañana.ToString(), horario.X_EntradaTarde.ToString(), horario.X_SalidaTarde.ToString()).TotalHours;
            totalHoras += CalcularHorasTrabajadas(horario.J_EntradaMañana.ToString(), horario.J_SalidaMañana.ToString(), horario.J_EntradaTarde.ToString(), horario.J_SalidaTarde.ToString()).TotalHours;
            totalHoras += CalcularHorasTrabajadas(horario.V_EntradaMañana.ToString(), horario.V_SalidaMañana.ToString(), horario.V_EntradaTarde.ToString(), horario.V_SalidaTarde.ToString()).TotalHours;
            totalHoras += CalcularHorasTrabajadas(horario.S_EntradaMañana.ToString(), horario.S_SalidaMañana.ToString(), horario.S_EntradaTarde.ToString(), horario.S_SalidaTarde.ToString()).TotalHours;
            totalHoras += CalcularHorasTrabajadas(horario.D_EntradaMañana.ToString(), horario.D_SalidaMañana.ToString(), horario.D_EntradaTarde.ToString(), horario.D_SalidaTarde.ToString()).TotalHours;

            // Convertir el total de horas a int redondeando
            return (int)Math.Round(totalHoras);
        }

        //calcula la horas trabajadas
        public TimeSpan CalcularHorasTrabajadas(string entradaMañana, string salidaMañana, string entradaTarde, string salidaTarde)
        {
            TimeSpan totalHoras = TimeSpan.Zero;

            // Verificación para entrada y salida de la mañana
            if (!string.IsNullOrEmpty(entradaMañana) && !string.IsNullOrEmpty(salidaMañana))
            {
                if (TimeSpan.TryParse(entradaMañana, out TimeSpan entradaMananaTime) && TimeSpan.TryParse(salidaMañana, out TimeSpan salidaMananaTime))
                {
                    if (salidaMananaTime > entradaMananaTime) // Verificación de que la salida sea posterior a la entrada
                    {
                        totalHoras += salidaMananaTime - entradaMananaTime;
                    }
                }
            }

            // Verificación para entrada y salida de la tarde
            if (!string.IsNullOrEmpty(entradaTarde) && !string.IsNullOrEmpty(salidaTarde))
            {
                if (TimeSpan.TryParse(entradaTarde, out TimeSpan entradaTardeTime) && TimeSpan.TryParse(salidaTarde, out TimeSpan salidaTardeTime))
                {
                    if (salidaTardeTime > entradaTardeTime) // Verificación de que la salida sea posterior a la entrada
                    {
                        totalHoras += salidaTardeTime - entradaTardeTime;
                    }
                }
            }
            
            return totalHoras;

        }
    }
}
