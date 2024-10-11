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
                //Verificadores
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

                // Validar el dígito verificador (debe ser un número o la letra 'K')
                string digitoVerificador = partesRut[1].ToUpper();
                if (digitoVerificador.Length != 1 || (!char.IsDigit(digitoVerificador[0]) && digitoVerificador != "K"))
                {
                    throw new ArgumentException("El dígito verificador no es válido.");
                }

                DatosFuncionario.IdEmpleado = idEmpleado;
                DatosFuncionario.Rut = rut; 

                return true; 
            }

            public bool ValidarCorreo(string correo)
            {
                if (!correo.Contains("@"))
                {
                    throw new ArgumentException("Correo electrónico no válido. Debe incluir '@'.");
                }

                DatosFuncionario.CorreoElectronico = correo;
                return true;
            }

            //cargar Combobox
            public void SeleccionarTipoContrato(int tipoContratoId) => DatosFuncionario.TipoContrato = tipoContratoId;
            public void SeleccionarTipoCargo(int tipoCargoId) => DatosFuncionario.TipoCargo = tipoCargoId;
            public void SeleccionarUnidad(int unidadId) => DatosFuncionario.IdUnidad = unidadId;
            public void SeleccionarDispositivo(int dispositivoId) => DatosFuncionario.IdDispositivo = dispositivoId;
            public void SeleccionarHorario(int horario) => DatosFuncionario.IdHorario = horario;

            public bool RegistrarUsuario()
            {
                try
                {
                    
                    DB.Conectar();
                    DbCommand cmd = DB.CrearComando("sp_AgregarFuncionarioContratoDispositivo");
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Añadir parámetros
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
                    cmd.Parameters.Add(new SqlParameter("@IdHorario", SqlDbType.Int) { Value = DatosFuncionario.IdHorario }); 
                    cmd.Parameters.Add(new SqlParameter("@Desde", SqlDbType.DateTime) { Value = DatosFuncionario.Fecha });  

                    cmd.ExecuteNonQuery();

                    return true; 
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al registrar el usuario: " + ex.Message);
                }
                finally
                {
                    DB.Desconectar();
                }
            }

        }
    }
}
