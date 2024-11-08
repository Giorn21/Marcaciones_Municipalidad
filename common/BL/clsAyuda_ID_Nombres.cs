using common.Models;
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
    public class clsAyuda_ID_Nombres
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

        public clsAyuda_ID_Nombres()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        readonly BaseDatos DB = new BaseDatos();

        public List<Marcaciones> ObtenerAyuda_Id_nombre()
        {
            var Ayuda = new List<Marcaciones>();
            DB.Conectar();

            try
            {
                DB.CrearComando("sp_Ayuda_Id_Nombre");
                DbDataReader dr = DB.EjecutarConsulta();
                DataTable dt = new DataTable();
                dt.Load(dr);

                foreach (DataRow row in dt.Rows)
                {
                    Marcaciones ayuda = new Marcaciones
                    {

                        ID = row[0] != DBNull.Value ? Convert.ToInt32(row[0]) : 0,
                        Nombre = row[1] != DBNull.Value ? row[1].ToString() : "Sin Nombre",

                    };

                    Ayuda.Add(ayuda);
                }

                return Ayuda;
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
