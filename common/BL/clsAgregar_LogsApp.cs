using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace common
{
    public class clsAgregar_LogsApp
    {
        BaseDatos DB = new BaseDatos();
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

        public clsAgregar_LogsApp()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        public void InsertarLog(string proceso, string accion, string usuario, string descripcion)
        {
            try
            {
                DB.Conectar();
                DbCommand cmd = DB.CrearComando("sp_AgregarLogApp");
                cmd.CommandType = CommandType.StoredProcedure;

                string host = Environment.MachineName;
                DateTime fecha = DateTime.Now;

                // Añadir los parámetros
                cmd.Parameters.Add(new SqlParameter("@Fecha", fecha));
                cmd.Parameters.Add(new SqlParameter("@Proceso", proceso));
                cmd.Parameters.Add(new SqlParameter("@Accion", accion));
                cmd.Parameters.Add(new SqlParameter("@Usuario", usuario));
                cmd.Parameters.Add(new SqlParameter("@Descripcion", descripcion));
                cmd.Parameters.Add(new SqlParameter("@Host", host));

                // Ejecutar el comando
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al insertar el log: " + ex.Message);
            }
        }
    }
}
