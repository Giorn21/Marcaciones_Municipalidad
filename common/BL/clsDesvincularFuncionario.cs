using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class clsDesvincularFuncionario
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

        public List<Funcionario> DataSource { get; set; }

        public clsDesvincularFuncionario()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        public bool DesvincularFuncionario(int idEmpleado, DateTime fechaDesvinculacion)
        {
            try
            {
                DB.Conectar();
                DbCommand cmd = DB.CrearComando("sp_DesvincularFuncionario");
                cmd.CommandType = CommandType.StoredProcedure;

                // Añadir parámetros
                cmd.Parameters.Add(new SqlParameter("@IdEmpleado", SqlDbType.Int) { Value = idEmpleado });
                cmd.Parameters.Add(new SqlParameter("@Hasta", SqlDbType.DateTime) { Value = fechaDesvinculacion });

                // Ejecutar el comando
                cmd.ExecuteNonQuery();
                return true; // Se desvinculó exitosamente
            }
            catch (Exception ex)
            {
                throw new Exception("Error al desvincular el funcionario: " + ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }
        }
    }
}
