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
    public class clsVer_TipoUnidad
    {
        readonly BaseDatos DB = new BaseDatos();
        TipoUnidad current = null;

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

        public List<TipoUnidad> DataSource { get; set; }

        public clsVer_TipoUnidad()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        public List<TipoUnidad> ObtenerUnidad()
        {
            var tipoUnidades = new List<TipoUnidad>();
            DB.Conectar();

            try
            {
                DB.CrearComando("sp_VerUnidad");
                DbDataReader dr = DB.EjecutarConsulta();
                DataTable dt = new DataTable();
                dt.Load(dr);

                foreach (DataRow row in dt.Rows)
                {
                    TipoUnidad unidad = new TipoUnidad
                    {
                        Direccion = row["Direccion"] != DBNull.Value ? row["Direccion"].ToString() : "Sin Direccion",
                        IdUnidad = row["IdUnidad"] != DBNull.Value ? Convert.ToInt32(row["IdUnidad"]) : 0,
                        Descripcion = row["Descripcion"] != DBNull.Value ? row["Descripcion"].ToString() : "Sin Descripcion",
                        Ubicacion = row["Ubicacion"] != DBNull.Value ? row["Ubicacion"].ToString() : "Sin Ubicacion",
                        Telefono = row["Telefono"] != DBNull.Value ? row["Telefono"].ToString() : "Sin Telefono",
                        Email = row["Email"] != DBNull.Value ? row["Email"].ToString() : "Sin Email",

                    };

                    tipoUnidades.Add(unidad);
                }

                return tipoUnidades;
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
