using common.Models;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class clsVer_TipoBiometria
    {
        readonly BaseDatos DB = new BaseDatos();
        TipoBiometria current = null;

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

        public List<TipoBiometria> DataSource { get; set; }

        public clsVer_TipoBiometria()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        public List<TipoBiometria> ObtenerBiometria()
        {
            var biometrias = new List<TipoBiometria>();
            DB.Conectar();

            try
            {
                DB.CrearComando("sp_VerBiometria");
                DbDataReader dr = DB.EjecutarConsulta();
                DataTable dt = new DataTable();
                dt.Load(dr);

                foreach (DataRow row in dt.Rows)
                {
                    TipoBiometria biometria = new TipoBiometria
                    {
                      
                        Biometria = row[0] != DBNull.Value ? Convert.ToInt32(row[0]) : 0,
                        Descripcion = row[1] != DBNull.Value ? row[1].ToString() : "Sin Descripcion",
                     
                    };

                    biometrias.Add(biometria);
                }

                return biometrias;
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
