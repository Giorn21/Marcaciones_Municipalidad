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
    public class clsVer_Dispositivos
    {
        readonly BaseDatos DB = new BaseDatos();

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

        public List<Dispositivo> DataSource { get; set; }

        public clsVer_Dispositivos()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        public List<Dispositivo> ObtenerDispositivos()
        {
            var dispositivos = new List<Dispositivo>();
            DB.Conectar();  // Abre la conexión a la base de datos

            try
            {
                // Crear el comando para ejecutar el procedimiento almacenado
                DB.CrearComando("DispositivosSelProc");

                // Ejecutar el comando y obtener el resultado
                DbDataReader dr = DB.EjecutarConsulta();

                // Cargar los datos en un DataTable
                DataTable dt = new DataTable();
                dt.Load(dr);

                // Procesar cada fila y agregarla a la lista de funcionarios
                foreach (DataRow row in dt.Rows)
                {
                    Dispositivo dispositivo = new Dispositivo
                    {
                        //Comprobación de DBNull antes de la conversión
                        IdDispositivo = row["IdDispositivo"] != DBNull.Value ? Convert.ToInt32(row["IdDispositivo"]) : 0,
                        Descripcion = row["Descripcion"] != DBNull.Value ? row["Descripcion"].ToString() : "Sin Descripcion",
                        IP = row["IP"] != DBNull.Value ? row["IP"].ToString() : "Sin IP",
                        Mac = row["Mac"] != DBNull.Value ? row["Mac"].ToString() : "Sin Mac",
                        Ubicacion = row["Ubicacion"] != DBNull.Value ? row["Ubicacion"].ToString() : "Sin Ubicacion",
                        PushProtocol = row["PushProtocol"] != DBNull.Value ? row["PushProtocol"].ToString() : "Sin PushProtocol",
                        UploadFlag = row["UploadFlag"] != DBNull.Value ? row["UploadFlag"].ToString() : "Sin UploadFlag",
                        LastActivityLog = row["LastActivityLog"] != DBNull.Value ? Convert.ToDateTime(row["LastActivityLog"]) : DateTime.MinValue,
                        LastActivityOP = row["LastActivityOP"] != DBNull.Value ? Convert.ToDateTime(row["LastActivityOP"]) : DateTime.MinValue
                    };

                    dispositivos.Add(dispositivo);
                }

                return dispositivos;
            }
            catch (BaseDatosException ex)
            {
                throw new SyntaxErrorException(ex.Message);
            }
            finally
            {
                DB.Desconectar();  // Cierra la conexión
            }
        }
    }
}
