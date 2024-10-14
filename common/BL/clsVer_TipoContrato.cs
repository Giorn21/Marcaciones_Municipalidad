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
    public class clsVer_TipoContrato
    {
        readonly BaseDatos DB = new BaseDatos();
        TipoContrato current = null;

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

        public List<TipoContrato> DataSource { get; set; }

        public clsVer_TipoContrato()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        public List<TipoContrato> ObtenerContrato()
        {
            var tipoContratos = new List<TipoContrato>();
            DB.Conectar();

            try
            {
                DB.CrearComando("sp_ObtenerTiposContratos");
                DbDataReader dr = DB.EjecutarConsulta();
                DataTable dt = new DataTable();
                dt.Load(dr);

                foreach (DataRow row in dt.Rows)
                {
                    TipoContrato contrato = new TipoContrato
                    {

                        Contrato = Convert.ToInt32(row[0]),
                        Descripcion = row[1] != DBNull.Value ? row[1].ToString() : "Sin Descripcion",

                    };

                    tipoContratos.Add(contrato);
                }

                return tipoContratos;
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
