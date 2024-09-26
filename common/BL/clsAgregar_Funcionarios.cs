using DataLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
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
            readonly BaseDatos DB = new BaseDatos();

            clsAgregar_Funcionarios current = null;

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
                // Verificar que el RUT contenga un guion
                if (!rut.Contains("-"))
                {
                    throw new ArgumentException("Formato de RUT incorrecto.");
                }

                // Separar el RUT en partes
                string[] partesRut = rut.Split('-');
                if (partesRut.Length != 2)
                {
                    throw new ArgumentException("RUT no tiene un dígito verificador.");
                }

                // Verificar que la parte numérica sea válida
                if (!int.TryParse(partesRut[0], out int idEmpleado))
                {
                    throw new ArgumentException("La parte numérica del RUT no es válida.");
                }

                // Asignar valores a las propiedades de la clase DatosFuncionario
                DatosFuncionario.IdEmpleado = idEmpleado;
                DatosFuncionario.Rut = rut; // Guardar el RUT completo en el formato IdEmpleado-DígitoVerificador

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
                    // Conectar a la base de datos
                    DB.Conectar();

                    // Crear comando
                    DbCommand cmd = DB.CrearComando("sp_AgregarFuncionarioContratoDispositivo");

                    // Establecer el tipo de comando a procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Añadir parámetros utilizando las propiedades de la clase AgregarDatos
                    cmd.Parameters.Add(new SqlParameter("@IdEmpleado", SqlDbType.Int) { Value = DatosFuncionario.IdEmpleado });
                    cmd.Parameters.Add(new SqlParameter("@Rut", SqlDbType.VarChar) { Value = DatosFuncionario.Rut });
                    cmd.Parameters.Add(new SqlParameter("@Nombres", SqlDbType.VarChar) { Value = DatosFuncionario.Nombre });
                    cmd.Parameters.Add(new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar) { Value = DatosFuncionario.ApellidoPaterno });
                    cmd.Parameters.Add(new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar) { Value = DatosFuncionario.ApellidoMaterno });
                    cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar) { Value = DatosFuncionario.CorreoElectronico });
                    cmd.Parameters.Add(new SqlParameter("@TipoContrato", SqlDbType.Int) { Value = DatosFuncionario.TipoContrato });
                    cmd.Parameters.Add(new SqlParameter("@IdCargo", SqlDbType.Int) { Value = DatosFuncionario.TipoCargo });
                    cmd.Parameters.Add(new SqlParameter("@IdUnidad", SqlDbType.Int) { Value = DatosFuncionario.IdUnidad });
                    cmd.Parameters.Add(new SqlParameter("@IdDispositivo", SqlDbType.Int) { Value = DatosFuncionario.IdDispositivo });

                    // Ejecutar el procedimiento almacenado
                    cmd.ExecuteNonQuery();

                    return true; // Si todo sale bien
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    throw new Exception("Error al registrar el usuario: " + ex.Message);
                }
                finally
                {
                    // Cerrar la conexión
                    DB.Desconectar();
                }
            }

        }
    }
}
