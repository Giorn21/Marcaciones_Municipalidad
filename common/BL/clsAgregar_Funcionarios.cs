using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace common
{
    public class clsAgregar_Funcionarios
    {
        readonly BaseDatos DB = new BaseDatos();

        clsAgregar_Funcionarios current = null;



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

        public clsAgregar_Funcionarios()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        public class clsInsertarFuncionario
        {
            readonly BaseDatos DB = new BaseDatos();

            public void InsertarFuncionario(string rutCompleto, string nombres, string apellidoPaterno,
                                        string apellidoMaterno, byte[] foto, string email,
                                        int tipoContrato, int idCargo, int idDispositivo)
            {
                string idEmpleado = ObtenerIdEmpleadoDeRut(rutCompleto);

                DB.Conectar();  // Abre la conexión a la base de datos

                try
                {
                    // Crear el comando para ejecutar el procedimiento almacenado
                    DB.CrearComando("sp_InsertarFuncionario");

                    // Asignar los parámetros necesarios al comando
                    DB.AsignarParametro("@IdEmpleado", idEmpleado);  // idEmpleado es un string
                    DB.AsignarParametro("@Rut", rutCompleto);        // Rut es un string
                    DB.AsignarParametro("@Nombres", nombres);        // Nombres es un string
                    DB.AsignarParametro("@ApellidoPaterno", apellidoPaterno);  // ApellidoPaterno es un string
                    DB.AsignarParametro("@ApellidoMaterno", apellidoMaterno);  // ApellidoMaterno es un string

                    // Foto: si es un byte[], pasarlo como objeto
                    DB.AsignarParametro("@Foto", (object)foto);  // foto debe ser de tipo object

                    DB.AsignarParametro("@Email", email);  // Email es un string

                    // Convertir los enteros a string o pasarlos como object si se permite
                    DB.AsignarParametro("@TipoContrato", tipoContrato.ToString());  // Convertir int a string
                    DB.AsignarParametro("@IdCargo", idCargo.ToString());  // Convertir int a string
                    DB.AsignarParametro("@IdDispositivo", idDispositivo.ToString());  // Convertir int a string


                    // Ejecutar el comando
                    DB.EjecutarComando();
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

            // Método para extraer el IdEmpleado del RUT
            private string ObtenerIdEmpleadoDeRut(string rut)
            {
                int posicionGuion = rut.IndexOf('-');
                if (posicionGuion > 0)
                {
                    return rut.Substring(0, posicionGuion); // Solo los números antes del guion
                }
                else
                {
                    throw new FormatException("El RUT no tiene un formato válido.");
                }
            }
        }
    }
}
