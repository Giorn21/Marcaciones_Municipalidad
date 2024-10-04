using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace common
{
    public class clsBuscarFuncionarios
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

        public clsBuscarFuncionarios()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        public List<Funcionario> BuscarFuncionarioPorRut(string rut)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();


            try
            {
                // Conectar a la base de datos
                DB.Conectar();

                // Crear el comando para el procedimiento almacenado
                DB.CrearComando("sp_BuscarFuncionarioPorRut");

                // Agregar el parámetro @Rut al comando
                DB.AgregarParametro("@Rut", rut);

                // Ejecutar la consulta
                using (DbDataReader reader = DB.EjecutarConsulta()) // Cambia a DbDataReader
                {
                    // Leer los resultados
                    while (reader.Read())
                    {
                        Funcionario funcionario = new Funcionario
                        {
                            IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                            Rut = reader["Rut"].ToString(),
                            Nombres = reader["Nombres"].ToString(),
                            ApellidoPaterno = reader["ApellidoPaterno"].ToString(),
                            ApellidoMaterno = reader["ApellidoMaterno"].ToString(),
                            Foto = reader["Foto"] != DBNull.Value ? (byte[])reader["Foto"] : null,
                            Email = reader["Email"].ToString(),
                            Contrato = reader["Contrato"].ToString(),
                            Cargo = reader["Cargo"].ToString(),
                            Unidad = reader["Unidad"].ToString(),
                            IdDispositivo = reader["IdDispositivo"] != DBNull.Value ? Convert.ToInt32(reader["IdDispositivo"]) : 0
                        };

                        // Agregar a la lista
                        funcionarios.Add(funcionario);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el funcionario: " + ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }

            return funcionarios;
        }
    }
}
