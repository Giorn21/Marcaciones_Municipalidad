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
    public class clsVer_LogsApp
    {
        readonly BaseDatos DB = new BaseDatos();

        Logs current = null;

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

        public List<Logs> DataSource { get; set; }

        public clsVer_LogsApp()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        public List<Logs> Ver_LogsApp()
        {
            var logsList = new List<Logs>();

            DB.Conectar();

            try
            {
                // Crear comando para ejecutar el procedimiento almacenado
                DB.CrearComando("sp_LogAppSelec");
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
                throw new Exception("Error al obtener logs: " + ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }

            return logsList;
        }
    }
}
