using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace common
{
    public class clsAgregar_TipoMarcasManual
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

        public List<Marcaciones> DataSource { get; set; }

        public clsAgregar_TipoMarcasManual()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        public void InsertarMarcacionManual(int id, DateTime fecha, TimeSpan hora, bool tipoMarca, string comentario)
        {
            

            try
            {
              
                DB.Conectar();
                DbCommand cmd = DB.CrearComando("sp_AgregarMarcacionManual");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ID", id));
                cmd.Parameters.Add(new SqlParameter("@Fecha", fecha));
                cmd.Parameters.Add(new SqlParameter("@Hora", hora));
                cmd.Parameters.Add(new SqlParameter("@TipoMarca", tipoMarca));
                cmd.Parameters.Add(new SqlParameter("@Comentario", comentario));

                DB.EjecutarComando();

                MessageBox.Show("Marcación manual agregada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la marcación manual: " + ex.Message);

            }
            finally
            {
                DB.Desconectar();
            }
        }
    }
}
