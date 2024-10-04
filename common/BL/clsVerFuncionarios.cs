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
    public class clsVerFuncionarios
    {
        readonly BaseDatos DB = new BaseDatos();

        Funcionario current = null;



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

        public clsVerFuncionarios()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        public List<Funcionario> ObtenerFuncionarios()
        {
            var funcionarios = new List<Funcionario>();
            DB.Conectar(); 

            try
            {
                DB.CrearComando("sp_Funcionarios_Contrato_Dispositivo");
                DbDataReader dr = DB.EjecutarConsulta();
                DataTable dt = new DataTable();
                dt.Load(dr);

                foreach (DataRow row in dt.Rows)
                {
                    Funcionario funcionario = new Funcionario
                    {
                        // Comprobación
                        IdEmpleado = row["IdEmpleado"] != DBNull.Value ? Convert.ToInt32(row["IdEmpleado"]) : 0,
                        Rut = row["Rut"] != DBNull.Value ? row["Rut"].ToString() : "Sin Rut",
                        Nombres = row["Nombres"] != DBNull.Value ? row["Nombres"].ToString() : "Sin Nombre",
                        ApellidoPaterno = row["ApellidoPaterno"] != DBNull.Value ? row["ApellidoPaterno"].ToString() : "Sin Apellido Paterno",
                        ApellidoMaterno = row["ApellidoMaterno"] != DBNull.Value ? row["ApellidoMaterno"].ToString() : "Sin Apellido Materno",
                        Foto = row["Foto"] != DBNull.Value ? (byte[])row["Foto"] : null,
                        Email = row["Email"] != DBNull.Value ? row["Email"].ToString() : "Sin Email",
                        Contrato = row["Contrato"] != DBNull.Value ? row["Contrato"].ToString() : "Sin Contrato",
                        Cargo = row["Cargo"] != DBNull.Value ? row["Cargo"].ToString() : "Sin Cargo",
                        Unidad= row["Unidad"] != DBNull.Value ? row["Unidad"].ToString() : "Sin Unidad",
                        IdDispositivo = row["IdDispositivo"] != DBNull.Value ? Convert.ToInt32(row["IdDispositivo"]) : 0
                    };

                    funcionarios.Add(funcionario);
                }

                return funcionarios;
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
