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
    public class clsVer_TipoMarca
    {
        readonly BaseDatos DB = new BaseDatos();
        TipoMarca current = null;

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

        public List<TipoMarca> DataSource { get; set; }

        public clsVer_TipoMarca()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        public List<TipoMarca> ObtenerTipoMarca(int Marca = 0)
        {
            var tipoMarcas = new List<TipoMarca>();
            DB.Conectar();

            try
            {
                DB.CrearComando("TipoMarcaSelProc  @TipoMarca");
                DB.AsignarParametroEntero("@TipoMarca", Marca);
                DbDataReader dr = DB.EjecutarConsulta();
                DataTable dt = new DataTable();
                dt.Load(dr);

                foreach (DataRow row in dt.Rows)
                {
                    TipoMarca tipoMarca = new TipoMarca
                    {
                        Descripcion = row[1].ToString(),
                        Autorizacion = Convert.ToByte(row[2])
                    };

                    tipoMarcas.Add(tipoMarca);
                }
                
                return tipoMarcas;
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
