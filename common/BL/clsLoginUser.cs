using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class clsLoginUser: LoginUser
    {
        readonly BaseDatos DB = new BaseDatos();

        LoginUser loginUser = null;

        

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
        // servidor de base de datos
        #region Metodos Publicos

        private string usuario;
        private string host;


        public string Host
        {
            get { return host; }
            set { host = value; }
        }

        public clsLoginUser()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion 


        public List<LoginUser> Get(System.String user, System.String contrasena)
        {
            var LoginUsers = new List<LoginUser>();
            DB.Conectar();
            try
            {
                //Ejecutamos el sp con parametros
                DB.CrearComando("sp_LoginUser @Usuario, @contrasena");
                DB.AsignarParametroCadena("@Usuario", user);
                DB.AsignarParametroCadena("@contrasena", contrasena);


                DbDataReader dr = DB.EjecutarConsulta();

                // los resultados se cargan
                DataTable dt = new DataTable();
                dt.TableName = MethodBase.GetCurrentMethod().DeclaringType.Name;
                dt.Load(dr);
                this.count = dt.Rows.Count;

                if (this.count > 0)
                {
                    System.IO.StringWriter writer = new System.IO.StringWriter();
                    dt.WriteXml(writer, XmlWriteMode.WriteSchema);
                    this.toxml = writer.ToString();
                }

                // Se leen los datos y se crean objetos para cada fila.
                DataTableReader reader = new DataTableReader(dt);
                if (reader == null)
                {
                    this.count = 0;
                    return null;
                }
                // Lee cada fila del lector
                while (reader.Read())
                {
                    try
                    {
                        // Llama a ReadDataRow para procesar la fila y guarda en current
                        loginUser = ReadDataRow(reader);
                        LoginUsers.Add(loginUser);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                reader.Close();
                return LoginUsers;
            }
            catch (BaseDatosException ex)
            {
                throw new SyntaxErrorException(ex.Message.ToString());
            }
            finally
            {
                DB.Desconectar();
            }
        }
        private LoginUser ReadDataRow(DataTableReader reader)
        {

            loginUser = null;

            var e = new LoginUser()
            {
                //Asigna los datos y verifica si son nulos 
                Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id")),
                User = reader.IsDBNull(reader.GetOrdinal("Usuario")) ? "" : reader.GetString(reader.GetOrdinal("Usuario")),
                contrasena = reader.IsDBNull(reader.GetOrdinal("Contrasena")) ? "" : reader.GetString(reader.GetOrdinal("Contrasena")),

            };
            this.loginUser = e;
            return (LoginUser)e;
        }
    }
}
