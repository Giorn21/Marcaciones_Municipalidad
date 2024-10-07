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
    public class clsVerMacacionesManuales
    {
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

        public List<Marcaciones> DataSource { get; set; }

        public clsVerMacacionesManuales()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        readonly BaseDatos DB = new BaseDatos();

        Marcaciones current = null;
        public List<Marcaciones> ObtenerMarcacionesManuales()
        {
            var marcaciones = new List<Marcaciones>();
            DB.Conectar();

            try
            {
                DB.CrearComando("sp_RegistrosMarcacionManual");
                DbDataReader dr = DB.EjecutarConsulta();
                DataTable dt = new DataTable();
                dt.Load(dr);

                foreach (DataRow row in dt.Rows)
                {
                    Marcaciones Marcas = new Marcaciones
                    {
                        // Comprobación
                        ID = row["ID"] != DBNull.Value ? Convert.ToInt32(row["ID"]) : 0,
                        Nombre = row["Nombres"] != DBNull.Value ? row["Nombres"].ToString() : "Sin Nombre",
                        Apellido = row["ApellidoPaterno"] != DBNull.Value ? row["ApellidoPaterno"].ToString() : "Sin Apellido",
                        fecha = row["Fecha"] != DBNull.Value ? Convert.ToDateTime(row["Fecha"]).ToString("dd/MM/yyyy") : "Sin Fecha",
                        hora = row["Hora"] != DBNull.Value ? row["Hora"].ToString() : "no tiene hora asignada",
                        TipoMarca = row["TipoMarca"] != DBNull.Value ? Convert.ToInt32(row["TipoMarca"]) : 0,
                        Comentario = row["Comentario"] != DBNull.Value ? row["Comentario"].ToString() : "Sin comentario",
                    };

                    marcaciones.Add(Marcas);
                }

                return marcaciones;
            }
            catch (BaseDatosException ex)
            {
                throw new SyntaxErrorException(ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }
        }
    }
}
