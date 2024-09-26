﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data.Common;
using System.Runtime.Remoting.Messaging;

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
                            L_EntradaMañana = reader["L_EntradaMañana"] != DBNull.Value ? (TimeSpan)reader["L_EntradaMañana"] : TimeSpan.Zero,
                            L_SalidaMañana = reader["L_SalidaMañana"] != DBNull.Value ? (TimeSpan)reader["L_SalidaMañana"] : TimeSpan.Zero,
                            L_EntradaTarde = reader["L_EntradaTarde"] != DBNull.Value ? (TimeSpan)reader["L_EntradaTarde"] : TimeSpan.Zero,
                            L_SalidaTarde = reader["L_SalidaTarde"] != DBNull.Value ? (TimeSpan)reader["L_SalidaTarde"] : TimeSpan.Zero,
                            L_ToleranciaEntrada = reader["L_ToleranciaEntrada"] != DBNull.Value ? Convert.ToInt32(reader["L_ToleranciaEntrada"]) : 0,
                            L_ToleranciaSalida = reader["L_ToleranciaSalida"] != DBNull.Value ? Convert.ToInt32(reader["L_ToleranciaSalida"]) : 0,

                            // Martes
                            M_EntradaMañana = reader["M_EntradaMañana"] != DBNull.Value ? (TimeSpan)reader["M_EntradaMañana"] : TimeSpan.Zero,
                            M_SalidaMañana = reader["M_SalidaMañana"] != DBNull.Value ? (TimeSpan)reader["M_SalidaMañana"] : TimeSpan.Zero,
                            M_EntradaTarde = reader["M_EntradaTarde"] != DBNull.Value ? (TimeSpan)reader["M_EntradaTarde"] : TimeSpan.Zero,
                            M_SalidaTarde = reader["M_SalidaTarde"] != DBNull.Value ? (TimeSpan)reader["M_SalidaTarde"] : TimeSpan.Zero,
                            M_ToleranciaEntrada = reader["M_ToleranciaEntrada"] != DBNull.Value ? Convert.ToInt32(reader["M_ToleranciaEntrada"]) : 0,
                            M_ToleranciaSalida = reader["M_ToleranciaSalida"] != DBNull.Value ? Convert.ToInt32(reader["M_ToleranciaSalida"]) : 0,

                            // Miércoles
                            X_EntradaMañana = reader["X_EntradaMañana"] != DBNull.Value ? (TimeSpan)reader["X_EntradaMañana"] : TimeSpan.Zero,
                            X_SalidaMañana = reader["X_SalidaMañana"] != DBNull.Value ? (TimeSpan)reader["X_SalidaMañana"] : TimeSpan.Zero,
                            X_EntradaTarde = reader["X_EntradaTarde"] != DBNull.Value ? (TimeSpan)reader["X_EntradaTarde"] : TimeSpan.Zero,
                            X_SalidaTarde = reader["X_SalidaTarde"] != DBNull.Value ? (TimeSpan)reader["X_SalidaTarde"] : TimeSpan.Zero,
                            X_ToleranciaEntrada = reader["X_ToleranciaEntrada"] != DBNull.Value ? Convert.ToInt32(reader["X_ToleranciaEntrada"]) : 0,
                            X_ToleranciaSalida = reader["X_ToleranciaSalida"] != DBNull.Value ? Convert.ToInt32(reader["X_ToleranciaSalida"]) : 0,

                            // Jueves
                            J_EntradaMañana = reader["J_EntradaMañana"] != DBNull.Value ? (TimeSpan)reader["J_EntradaMañana"] : TimeSpan.Zero,
                            J_SalidaMañana = reader["J_SalidaMañana"] != DBNull.Value ? (TimeSpan)reader["J_SalidaMañana"] : TimeSpan.Zero,
                            J_EntradaTarde = reader["J_EntradaTarde"] != DBNull.Value ? (TimeSpan)reader["J_EntradaTarde"] : TimeSpan.Zero,
                            J_SalidaTarde = reader["J_SalidaTarde"] != DBNull.Value ? (TimeSpan)reader["J_SalidaTarde"] : TimeSpan.Zero,
                            J_ToleranciaEntrada = reader["J_ToleranciaEntrada"] != DBNull.Value ? Convert.ToInt32(reader["J_ToleranciaEntrada"]) : 0,
                            J_ToleranciaSalida = reader["J_ToleranciaSalida"] != DBNull.Value ? Convert.ToInt32(reader["J_ToleranciaSalida"]) : 0,

                            // Viernes
                            V_EntradaMañana = reader["V_EntradaMañana"] != DBNull.Value ? (TimeSpan)reader["V_EntradaMañana"] : TimeSpan.Zero,
                            V_SalidaMañana = reader["V_SalidaMañana"] != DBNull.Value ? (TimeSpan)reader["V_SalidaMañana"] : TimeSpan.Zero,
                            V_EntradaTarde = reader["V_EntradaTarde"] != DBNull.Value ? (TimeSpan)reader["V_EntradaTarde"] : TimeSpan.Zero,
                            V_SalidaTarde = reader["V_SalidaTarde"] != DBNull.Value ? (TimeSpan)reader["V_SalidaTarde"] : TimeSpan.Zero,
                            V_ToleranciaEntrada = reader["V_ToleranciaEntrada"] != DBNull.Value ? Convert.ToInt32(reader["V_ToleranciaEntrada"]) : 0,
                            V_ToleranciaSalida = reader["V_ToleranciaSalida"] != DBNull.Value ? Convert.ToInt32(reader["V_ToleranciaSalida"]) : 0,

                            // Sábado
                            S_EntradaMañana = reader["S_EntradaMañana"] != DBNull.Value ? (TimeSpan)reader["S_EntradaMañana"] : TimeSpan.Zero,
                            S_SalidaMañana = reader["S_SalidaMañana"] != DBNull.Value ? (TimeSpan)reader["S_SalidaMañana"] : TimeSpan.Zero,
                            S_EntradaTarde = reader["S_EntradaTarde"] != DBNull.Value ? (TimeSpan)reader["S_EntradaTarde"] : TimeSpan.Zero,
                            S_SalidaTarde = reader["S_SalidaTarde"] != DBNull.Value ? (TimeSpan)reader["S_SalidaTarde"] : TimeSpan.Zero,
                            S_ToleranciaEntrada = reader["S_ToleranciaEntrada"] != DBNull.Value ? Convert.ToInt32(reader["S_ToleranciaEntrada"]) : 0,
                            S_ToleranciaSalida = reader["S_ToleranciaSalida"] != DBNull.Value ? Convert.ToInt32(reader["S_ToleranciaSalida"]) : 0,

                            // Domingo
                            D_EntradaMañana = reader["D_EntradaMañana"] != DBNull.Value ? (TimeSpan)reader["D_EntradaMañana"] : TimeSpan.Zero,
                            D_SalidaMañana = reader["D_SalidaMañana"] != DBNull.Value ? (TimeSpan)reader["D_SalidaMañana"] : TimeSpan.Zero,
                            D_EntradaTarde = reader["D_EntradaTarde"] != DBNull.Value ? (TimeSpan)reader["D_EntradaTarde"] : TimeSpan.Zero,
                            D_SalidaTarde = reader["D_SalidaTarde"] != DBNull.Value ? (TimeSpan)reader["D_SalidaTarde"] : TimeSpan.Zero,
                            D_ToleranciaEntrada = reader["D_ToleranciaEntrada"] != DBNull.Value ? Convert.ToInt32(reader["D_ToleranciaEntrada"]) : 0,
                            D_ToleranciaSalida = reader["D_ToleranciaSalida"] != DBNull.Value ? Convert.ToInt32(reader["D_ToleranciaSalida"]) : 0
                        };
                    }
                }
            }

            return horario;
        }

        // Método para obtener los datos y llenar el DataTable formateado
        public DataTable ObtenerHorarioFormateado(int idHorario)
        {
            Horario horario = ObtenerHorario(idHorario);  // Obtener datos del objeto Horario
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
                // Agregar las filas para cada día con el cálculo de horas trabajadas
                dtFormatted.Rows.Add("Lunes",
                    horario.L_EntradaMañana,
                    horario.L_SalidaMañana,
                    horario.L_EntradaTarde,
                    horario.L_SalidaTarde,
                    horario.L_ToleranciaEntrada,
                    CalcularHorasTrabajadas(
                        horario.L_EntradaMañana.ToString(),
                        horario.L_SalidaMañana.ToString(),
                        horario.L_EntradaTarde.ToString(),
                        horario.L_SalidaTarde.ToString()));

                    dtFormatted.Rows.Add("Martes",
                    horario.M_EntradaMañana,
                    horario.M_SalidaMañana,
                    horario.M_EntradaTarde,
                    horario.M_SalidaTarde,
                    horario.M_ToleranciaEntrada,
                    CalcularHorasTrabajadas(
                        horario.M_EntradaMañana.ToString(),
                        horario.M_SalidaMañana.ToString(),
                        horario.M_EntradaTarde.ToString(),
                        horario.M_SalidaTarde.ToString()));

                    dtFormatted.Rows.Add("Miercoles",
                        horario.X_EntradaMañana,
                        horario.X_SalidaMañana,
                        horario.X_EntradaTarde,
                        horario.X_SalidaTarde,
                        horario.X_ToleranciaEntrada,
                        CalcularHorasTrabajadas(
                            horario.X_EntradaMañana.ToString(),
                            horario.X_SalidaMañana.ToString(),
                            horario.X_EntradaTarde.ToString(),
                            horario.X_SalidaTarde.ToString()));

                    dtFormatted.Rows.Add("Jueves",
                        horario.J_EntradaMañana,
                        horario.J_SalidaMañana,
                        horario.J_EntradaTarde,
                        horario.J_SalidaTarde,
                        horario.J_ToleranciaEntrada,
                        CalcularHorasTrabajadas(
                            horario.J_EntradaMañana.ToString(),
                            horario.J_SalidaMañana.ToString(),
                            horario.J_EntradaTarde.ToString(),
                            horario.J_SalidaTarde.ToString()));

                    dtFormatted.Rows.Add("Viernes",
                        horario.V_EntradaMañana,
                        horario.V_SalidaMañana,
                        horario.V_EntradaTarde,
                        horario.V_SalidaTarde,
                        horario.V_ToleranciaEntrada,
                        CalcularHorasTrabajadas(
                            horario.V_EntradaMañana.ToString(),
                            horario.V_SalidaMañana.ToString(),
                            horario.V_EntradaTarde.ToString(),
                            horario.V_SalidaTarde.ToString()));

                    dtFormatted.Rows.Add("Sabado",
                        horario.S_EntradaMañana,
                        horario.S_SalidaMañana,
                        horario.S_EntradaTarde,
                        horario.S_SalidaTarde,
                        horario.S_ToleranciaEntrada,
                        CalcularHorasTrabajadas(
                            horario.S_EntradaMañana.ToString(),
                            horario.S_SalidaMañana.ToString(),
                            horario.S_EntradaTarde.ToString(),
                            horario.S_SalidaTarde.ToString()));

                    dtFormatted.Rows.Add("Domingo",
                        horario.D_EntradaMañana,
                        horario.D_SalidaMañana,
                        horario.D_EntradaTarde,
                        horario.D_SalidaTarde,
                        horario.D_ToleranciaEntrada,
                        CalcularHorasTrabajadas(
                            horario.D_EntradaMañana.ToString(),
                            horario.D_SalidaMañana.ToString(),
                            horario.D_EntradaTarde.ToString(),
                            horario.D_SalidaTarde.ToString()));

                // Mostrar el total de horas semanales
                dtFormatted.Rows.Add("Total", "--->", "--->", "--->", "--->", "--->", "Total Horas Semanales Aquí");
            }

            return dtFormatted;
        }       

        // Método para calcular las horas trabajadas
        public TimeSpan CalcularHorasTrabajadas(string entradaMañana, string salidaMañana, string entradaTarde, string salidaTarde)
        {
            TimeSpan totalHoras = TimeSpan.Zero;

            if (TimeSpan.TryParse(entradaMañana, out TimeSpan entradaMananaTime) && TimeSpan.TryParse(salidaMañana, out TimeSpan salidaMananaTime))
            {
                totalHoras += salidaMananaTime - entradaMananaTime;
            }

            if (TimeSpan.TryParse(entradaTarde, out TimeSpan entradaTardeTime) && TimeSpan.TryParse(salidaTarde, out TimeSpan salidaTardeTime))
            {
                totalHoras += salidaTardeTime - entradaTardeTime;
            }

            return totalHoras;
        }
    }

}
