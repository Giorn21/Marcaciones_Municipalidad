using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public List<AgregarDatos> DataSource { get; set; }

        public clsAgregar_Funcionarios()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        public class clsInsertarFuncionario
        {

            // Instancia de la clase AgregarDatos
            public AgregarDatos DatosFuncionario { get; private set; }

            // Constructor
            public clsInsertarFuncionario()
            {
                DatosFuncionario = new AgregarDatos(); // Inicializar la instancia
            }

            // Método para dividir el RUT y obtener el IdEmpleado
            public bool ProcesarRut(string rut)
            {
                if (!rut.Contains("-"))
                {
                    throw new ArgumentException("Formato de RUT incorrecto.");
                }

                string[] partesRut = rut.Split('-');
                if (partesRut.Length != 2)
                {
                    throw new ArgumentException("RUT no tiene un dígito verificador.");
                }

                if (!int.TryParse(partesRut[0], out int idEmpleado))
                {
                    throw new ArgumentException("La parte numérica del RUT no es válida.");
                }

                // Asignar valores a las propiedades de la clase AgregarDatos
                DatosFuncionario.IdEmpleado = idEmpleado;
                DatosFuncionario.Rut = rut;

                return true; // Validación exitosa
            }

            // Validación básica del correo electrónico
            public bool ValidarCorreo(string correo)
            {
                if (!correo.Contains("@"))
                {
                    throw new ArgumentException("Correo electrónico no válido. Debe incluir '@'.");
                }

                DatosFuncionario.CorreoElectronico = correo; // Asignar correo a la propiedad
                return true;
            }

            // Métodos para cargar datos del ComboBox y seleccionar el valor
            public void SeleccionarTipoContrato(int tipoContratoId)
            {
                DatosFuncionario.TipoContrato = tipoContratoId;
            }

            public void SeleccionarTipoCargo(int tipoCargoId)
            {
                DatosFuncionario.TipoCargo = tipoCargoId;
            }

            public void SeleccionarUnidad(int unidadId)
            {
                DatosFuncionario.IdUnidad = unidadId;
            }

            public void SeleccionarDispositivo(int dispositivoId)
            {
                DatosFuncionario.IdDispositivo = dispositivoId;
            }

            // Método para registrar el usuario en la base de datos
            public bool RegistrarUsuario()
            {
                try
                {  
                    using (SqlConnection conn = DB.ObtenerConexion())
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("sp_AgregarFuncionarioContratoDispositivo", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Añadir parámetros utilizando las propiedades de la clase AgregarDatos
                            cmd.Parameters.AddWithValue("@IdEmpleado", DatosFuncionario.IdEmpleado);
                            cmd.Parameters.AddWithValue("@Rut", DatosFuncionario.Rut);
                            cmd.Parameters.AddWithValue("@Nombre", DatosFuncionario.Nombre);
                            cmd.Parameters.AddWithValue("@ApellidoPaterno", DatosFuncionario.ApellidoPaterno);
                            cmd.Parameters.AddWithValue("@ApellidoMaterno", DatosFuncionario.ApellidoMaterno);
                            cmd.Parameters.AddWithValue("@CorreoElectronico", DatosFuncionario.CorreoElectronico);
                            cmd.Parameters.AddWithValue("@TipoContrato", DatosFuncionario.TipoContrato);
                            cmd.Parameters.AddWithValue("@TipoCargo", DatosFuncionario.TipoCargo);
                            cmd.Parameters.AddWithValue("@IdUnidad", DatosFuncionario.IdUnidad);
                            cmd.Parameters.AddWithValue("@IdDispositivo", DatosFuncionario.IdDispositivo);

                            // Ejecutar el procedimiento almacenado
                            cmd.ExecuteNonQuery();
                        }
                    }

                    return true; // Si todo sale bien
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    throw new Exception("Error al registrar el usuario: " + ex.Message);
                }
            }

        }
    }
}
