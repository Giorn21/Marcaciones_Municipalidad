using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataLayer;
using System.Data.Common;
using System.Runtime.Remoting.Contexts;

namespace common
{

    public class clsVerDisp_Funcionario
    {
        readonly BaseDatos DB = new BaseDatos();
        Disp_Funcionario current = null;

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

        public List<Disp_Funcionario> DataSource { get; set; }

        public clsVerDisp_Funcionario()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion
        public List<Disp_Funcionario> ObtenerDispFuncionarios(int idDispositivo, int idEmpleado)
        {
            var disp_Funcionarios = new List<Disp_Funcionario>();
            DB.Conectar();  // Abre la conexión a la base de datos

            try
            {
                // Crear el comando para ejecutar el procedimiento almacenado
                DB.CrearComando("DispositivosFuncionarioSelProc @IdDispositivo, @IdEmpleado");

                // Agregar los parámetros requeridos por el procedimiento almacenado
                DB.AsignarParametroEntero("@IdDispositivo", idDispositivo);
                DB.AsignarParametroEntero("@IdEmpleado", idEmpleado);

                // Ejecutar el comando y obtener el resultado
                DbDataReader dr = DB.EjecutarConsulta();

                // Cargar los datos en un DataTable
                DataTable dt = new DataTable();
                dt.Load(dr);

                // Procesar cada fila y agregarla a la lista de funcionarios
                foreach (DataRow row in dt.Rows)
                {
                    Disp_Funcionario disp_Funcionario = new Disp_Funcionario();
                    {
                        // Comprobación de DBNull antes de la conversión
                        disp_Funcionario.IdDispositivo = row["IdDispositivo"] != DBNull.Value ? Convert.ToInt32(row["IdDispositivo"]) : 0;
                        disp_Funcionario.IdEmpleado = row["IdEmpleado"] != DBNull.Value ? Convert.ToInt32(row["IdEmpleado"]) : 0;
                        disp_Funcionario.Sync = row["Sync"] != DBNull.Value ? Convert.ToByte(row["Sync"]) : (byte)0;
                    };

                    disp_Funcionarios.Add(disp_Funcionario);
                }

                return disp_Funcionarios;
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
