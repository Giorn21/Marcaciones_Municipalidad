using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class clsBuscadorLogs
    {
        private BaseDatos DB = new BaseDatos();

        public List<Logs> BuscarLogs(DateTime desde, DateTime hasta, string proceso = null, string descripcion = null, string usuario = null)
        {
            var logsList = new List<Logs>();

            try
            {
                // Crear comando para ejecutar el procedimiento almacenado
                DB.CrearComando("sp_buscador_Logs");

                // Asignar parámetros
                DB.AgregarParametro("@Desde", desde.ToString("dd-MM-yyyy"));
                DB.AgregarParametro("@Hasta", hasta.ToString("dd-MM-yyyy"));
                DB.AgregarParametro("@Proceso", (string)(proceso ?? (object)DBNull.Value.ToString()));
                DB.AgregarParametro("@Descripcion", (string)(descripcion ?? (object)DBNull.Value.ToString()));
                DB.AgregarParametro("@Usuario", (string)(usuario ?? (object)DBNull.Value.ToString()));

                // Ejecutar consulta
                DbDataReader dr = DB.EjecutarConsulta();
                DataTable dt = new DataTable();
                dt.Load(dr);

                foreach (DataRow row in dt.Rows)
                {
                    Logs logApp = new Logs
                    {
                        Fecha = row["Fecha"] != DBNull.Value ? Convert.ToDateTime(row["Fecha"]) : DateTime.MinValue,
                        Proceso = row["Proceso"] != DBNull.Value ? row["Proceso"].ToString() : "Sin Proceso",
                        Accion = row["Accion"] != DBNull.Value ? row["Accion"].ToString() : "Sin Acción",
                        Usuario = row["Usuario"] != DBNull.Value ? row["Usuario"].ToString() : "Desconocido",
                        Descripcion = row["Descripcion"] != DBNull.Value ? row["Descripcion"].ToString() : "Sin Descripción",
                        Host = row["Host"] != DBNull.Value ? row["Host"].ToString() : "Sin Host"
                    };

                    logsList.Add(logApp);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar logs: " + ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }

            return logsList;
        }
    }
}



