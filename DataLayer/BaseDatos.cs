﻿using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.Security.Cryptography;
using System.Collections;
using System.Data.SqlClient;

namespace DataLayer
{
    public class BaseDatos
    {
        string passPhrase      = "Pa55pr@se";  
        string saltValue       = "s@1tV@lue";  
        string hashAlgorithm   = "SHA1";       
        int passwordIterations = 2;            
        string initVector      = "@1B2c3D4e5F6g7H8"; 
        int keySize            = 256; 

        private DbConnection conexion = null;
        private DbCommand comando = null;
        private DbTransaction transaccion = null;
        private string cadenaConexion;
        private static DbProviderFactory factory = null;

        /// <summary>
        /// Crea una instancia del acceso a la base de datos.
        /// </summary>
        public BaseDatos()
        {
            Configurar();
        }

        /// <summary>
        /// Crea una instancia del acceso a la base de datos.
        /// </summary>
        public BaseDatos(string server, string database, string user, string password, string proveedor)
        {
            
            var userdb = Encriptacion.Decrypt(user, passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize);
            var passdb = Encriptacion.Decrypt(password, passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize);

            Configurar(server, database, userdb, passdb, proveedor);
        }

        #region Configuración
        private void Configurar(string server, string database, string user, string password, string proveedor)
        {
            try
            {
                this.cadenaConexion = String.Format("Server={0};Database={1};Uid={2};Pwd={3};", server, database, user, password);
                BaseDatos.factory = DbProviderFactories.GetFactory(proveedor);
            }
            catch (ConfigurationException ex)
            {
                throw new BaseDatosException("Error al cargar la configuración del acceso a datos.", ex);
            }
        }

        /// <summary>
        /// Configura el acceso a la base de datos para su utilización.
        /// </summary>
        /// <exception cref="BaseDatosException">Si existe un error al cargar la configuración.</exception>
        private void Configurar()
       {
            try
            {
                //string db = Encriptacion.Encrypt("RegistroMarcas", passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize);


             // string server = Encriptacion.Decrypt(ConfigurationManager.AppSettings.Get("SERVER"), passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize);
                string server = ConfigurationManager.AppSettings.Get("SERVER");
                string user = Encriptacion.Decrypt(ConfigurationManager.AppSettings.Get("USERNAME"), passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize);
                string password = Encriptacion.Decrypt(ConfigurationManager.AppSettings.Get("PASSWORD"), passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize);
             // string port = Encriptacion.Decrypt(ConfigurationManager.AppSettings.Get("PORT"), passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize);
                string database = Encriptacion.Decrypt(ConfigurationManager.AppSettings.Get("DATABASE"), passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize);

                string proveedor = ConfigurationManager.AppSettings.Get("PROVEEDOR_ADONET");
             // this.cadenaConexion = ConfigurationManager.AppSettings.Get("CADENA_CONEXION");
                this.cadenaConexion = String.Format("Server={0};Database={1};Uid={2};Pwd={3};", server, database, user, password);
                BaseDatos.factory = DbProviderFactories.GetFactory(proveedor);
            }
            catch (ConfigurationException ex)
            {
                throw new BaseDatosException("Error al cargar la configuración del acceso a datos.", ex);
            }
        }
        #endregion

        #region Conección
        /// <summary>
        /// Permite desconectarse de la base de datos.
        /// </summary>
        public void Desconectar()
        {
            if (this.conexion.State.Equals(ConnectionState.Open))
            {
                this.conexion.Close();
                // this.conexion = null;
            }
        }

        /// <summary>
        /// Se concecta con la base de datos.
        /// </summary>
        /// <exception cref="BaseDatosException">Si existe un error al conectarse.</exception>
        public void Conectar()
        {
            if (this.conexion != null && !this.conexion.State.Equals(ConnectionState.Closed))
            {
                return;
                throw new BaseDatosException("La conexión ya se encuentra abierta.");
            }
            try
            {
                if (this.conexion == null)
                {
                    this.conexion = factory.CreateConnection();

                    this.conexion.ConnectionString = cadenaConexion;
                }
                this.conexion.Open();
            }
            catch (DataException ex)
            {
                throw new BaseDatosException("Error al conectarse a la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new BaseDatosException("Error al conectarse a la base de datos.", ex);
            }
        }
        #endregion

        #region Parametros
        /// <summary>
        /// Asigna un parámetro de tipo cadena al comando creado.
        /// </summary>
        /// <param name="nombre">El nombre del parámetro.</param>
        /// <param name="valor">El valor del parámetro.</param>
        public void AsignarParametroBinario(string nombre, Byte[] valor)
        {
            DbParameter param = comando.CreateParameter();
            param.DbType = System.Data.DbType.Binary;
            param.Direction = ParameterDirection.Input;
            param.ParameterName = nombre;
            param.Size = valor.Length;
            param.Value = valor;

            comando.Parameters.Add(param);
        }


        /// <summary>
        /// Asigna un parámetro de tipo cadena al comando creado.
        /// </summary>
        /// <param name="nombre">El nombre del parámetro.</param>
        /// <param name="valor">El valor del parámetro.</param>
        public void AsignarParametroXml(string nombre, string valor)
        {
            DbParameter param = comando.CreateParameter();
            param.DbType = System.Data.DbType.Xml;
            param.Direction = ParameterDirection.Input;
            param.ParameterName = nombre;
            param.Size = valor.Length;
            param.Value = valor;

            comando.Parameters.Add(param);

            // AsignarParametro(nombre, "'", valor);
        }

        /// <summary>
        /// Setea un parámetro como nulo del comando creado.
        /// </summary>
        /// <param name="nombre">El nombre del parámetro cuyo valor será nulo.</param>
        public void AsignarParametroNulo(string nombre)
        {
            DbParameter param = comando.CreateParameter(); ;
            param.DbType = System.Data.DbType.Object;
            param.Direction = ParameterDirection.Input;
            param.ParameterName = nombre;
            param.Value = DBNull.Value;

            comando.Parameters.Add(param);

            // AsignarParametro(nombre, "", "NULL");
        }

        /// <summary>
        /// Asigna un parámetro de tipo cadena al comando creado.
        /// </summary>
        /// <param name="nombre">El nombre del parámetro.</param>
        /// <param name="valor">El valor del parámetro.</param>
        public void AsignarParametroCadena(string nombre, string valor)
        {
            DbParameter param = comando.CreateParameter();
            param.DbType = System.Data.DbType.String;
            param.Direction = ParameterDirection.Input;
            param.ParameterName = nombre;

            // Verificar si el valor es nulo
            if (valor == null)
            {
                param.Value = DBNull.Value; // Asigna DBNull si el valor es null
            }
            else
            {
                param.Size = valor.Length; // Establece el tamaño solo si el valor no es nulo
                param.Value = valor; // Asigna el valor
            }

            comando.Parameters.Add(param);
        }

        /// <summary>
        /// Asigna un parámetro de tipo Boolean al comando creado.
        /// </summary>
        /// <param name="nombre">El nombre del parámetro.</param>
        /// <param name="valor">El valor del parámetro.</param>
        public void AsignarParametroBoolean(string nombre, Boolean valor)
        {
            DbParameter param = comando.CreateParameter(); ;
            param.DbType = System.Data.DbType.Boolean;
            param.Direction = ParameterDirection.Input;
            param.ParameterName = nombre;
            param.Value = valor;

            comando.Parameters.Add(param);

            // AsignarParametro(nombre, "", valor.ToString());
        }

        /// <summary>
        /// Asigna un parámetro de tipo entero al comando creado.
        /// </summary>
        /// <param name="nombre">El nombre del parámetro.</param>
        /// <param name="valor">El valor del parámetro.</param>
        public void AsignarParametroEntero(string nombre, int valor)
        {
            DbParameter param = comando.CreateParameter();
            param.DbType = System.Data.DbType.Int32;
            param.Direction = ParameterDirection.Input;
            param.ParameterName = nombre;
            param.Value = valor;

            comando.Parameters.Add(param);

            // AsignarParametro(nombre, "", valor.ToString());
        }

        /// <summary>
        /// Asigna un parámetro de tipo double al comando creado.
        /// </summary>
        /// <param name="nombre">El nombre del parámetro.</param>
        /// <param name="valor">El valor del parámetro.</param>
        public void AsignarParametroDouble(string nombre, double valor)
        {

            DbParameter param = comando.CreateParameter(); ;
            param.DbType = System.Data.DbType.Double;
            param.Direction = ParameterDirection.Input;
            param.ParameterName = nombre;
            param.Value = valor;

            comando.Parameters.Add(param);

            // AsignarParametro(nombre, "", valor.ToString("#.#"));
        }

        /// <summary>
        /// Asigna un parámetro de tipo double al comando creado.
        /// </summary>
        /// <param name="nombre">El nombre del parámetro.</param>
        /// <param name="valor">El valor del parámetro.</param>
        public void AsignarParametroDecimal(string nombre, decimal valor)
        {
            DbParameter param = comando.CreateParameter(); ;
            param.DbType = System.Data.DbType.Decimal;
            param.Direction = ParameterDirection.Input;
            param.ParameterName = nombre;
            param.Value = valor;

            comando.Parameters.Add(param);
        }

        /// <summary>
        /// Asigna un parámetro de tipo double al comando creado.
        /// </summary>
        /// <param name="nombre">El nombre del parámetro.</param>
        /// <param name="valor">El valor del parámetro.</param>
        public void AsignarParametroFloat(string nombre, float valor)
        {

            DbParameter param = comando.CreateParameter(); ;
            param.DbType = System.Data.DbType.Double;
            param.Direction = ParameterDirection.Input;
            param.ParameterName = nombre;
            param.Value = valor;

            comando.Parameters.Add(param);

            // AsignarParametro(nombre, "", valor.ToString("#.#"));
        }


        /// <summary>
        /// Asigna un parámetro de tipo Image al comando creado.
        /// </summary>
        /// <param name="nombre">El nombre del parámetro.</param>
        /// <param name="valor">El valor del parámetro.</param>
        public void AsignarParametroImage(string nombre, byte[] valor = null)
        {
            DbParameter param = comando.CreateParameter();
            param.Direction = ParameterDirection.Input;
            param.ParameterName = nombre;
            // param.Value = valor.GetBuffer();
            param.Value = valor;

            comando.Parameters.Add(param);
        }

        /// <summary>
        /// Asigna un parámetro al comando creado.
        /// </summary>
        /// <param name="nombre">El nombre del parámetro.</param>
        /// <param name="separador">El separador que será agregado al valor del parámetro.</param>
        /// <param name="valor">El valor del parámetro.</param>
        public void AsignarParametro(string nombre, object valor)
        {
            int indice = this.comando.CommandText.IndexOf(nombre);
            string prefijo = this.comando.CommandText.Substring(0, indice);
            string sufijo = this.comando.CommandText.Substring(indice + nombre.Length);
            this.comando.CommandText = prefijo + sufijo;
        }

        /// <summary>
        /// Asigna un parámetro de tipo fecha al comando creado.
        /// </summary>
        /// <param name="nombre">El nombre del parámetro.</param>
        /// <param name="valor">El valor del parámetro.</param>
        public void AsignarParametroFecha(string nombre, DateTime valor)
        {
            DbParameter param = comando.CreateParameter(); ;
            param.DbType = System.Data.DbType.DateTime;
            param.Direction = ParameterDirection.Input;
            param.ParameterName = nombre;
            param.Value = valor;

            comando.Parameters.Add(param);
        }
        #endregion

        #region Comandos
        /// <summary>
        /// Crea un comando en base a una sentencia SQL.
        /// Ejemplo:
        /// <code>SELECT * FROM Tabla WHERE campo1=@campo1, campo2=@campo2</code>
        /// Guarda el comando para el seteo de parámetros y la posterior ejecución.
        /// </summary>
        /// <param name="sentenciaSQL">La sentencia SQL con el formato: SENTENCIA [param = @param,]</param>
        public DbCommand CrearComando(string sentenciaSQL)
        {
            this.comando = factory.CreateCommand();
            this.comando.Connection = this.conexion;
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = sentenciaSQL;
            if (this.transaccion != null)
            {
                this.comando.Transaction = this.transaccion;
            }
            return comando;
        }


        /// <summary>
        /// Ejecuta el comando creado y retorna el resultado de la consulta.
        /// </summary>
        /// <returns>El resultado de la consulta.</returns>
        /// <exception cref="BaseDatosException">Si ocurre un error al ejecutar el comando.</exception>
        public DbDataReader EjecutarConsulta()
        {
            return this.comando.ExecuteReader();
        }

        /// <summary>
        /// Ejecuta el comando creado y retorna un escalar.
        /// </summary>
        /// <returns>El escalar que es el resultado del comando.</returns>
        /// <exception cref="BaseDatosException">Si ocurre un error al ejecutar el comando.</exception>
        public float EjecutarEscalar()
        {
            float escalar = 0;
            try
            {
                // this.comando.CommandType = CommandType.StoredProcedure;
                escalar = float.Parse( this.comando.ExecuteScalar().ToString() );
            }
            catch (InvalidCastException ex)
            {
                throw new BaseDatosException("Error al ejecutar un escalar.", ex);
            }
            finally
            {

            }
            return escalar;
        }

        /// <summary>
        /// Ejecuta el comando creado.
        /// </summary>
        public void EjecutarComando()
        {
            this.comando.ExecuteNonQuery();
        }

        /// <summary>
        /// Comienza una transacción en base a la conexion abierta.
        /// Todo lo que se ejecute luego de esta ionvocación estará 
        /// dentro de una tranasacción.
        /// </summary>
        public void ComenzarTransaccion()
        {
            if (this.transaccion == null)
            {
                this.transaccion = this.conexion.BeginTransaction();
            }
        }

        /// <summary>
        /// Cancela la ejecución de una transacción.
        /// Todo lo ejecutado entre ésta invocación y su 
        /// correspondiente <c>ComenzarTransaccion</c> será perdido.
        /// </summary>
        public void CancelarTransaccion()
        {
            if (this.transaccion != null)
            {
                this.transaccion.Rollback();
            }
        }

        /// <summary>
        /// Confirma todo los comandos ejecutados entre el <c>ComanzarTransaccion</c>
        /// y ésta invocación.
        /// </summary>
        public void ConfirmarTransaccion()
        {
            if (this.transaccion != null)
            {
                this.transaccion.Commit();
            }
        }
        #endregion

        #region Encriptación
        public string EncryptString(string inputString, int dwKeySize, string xmlString)
        {
            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
            rsaCryptoServiceProvider.FromXmlString(xmlString);
            int keySize = dwKeySize / 8;
            byte[] bytes = Encoding.UTF32.GetBytes(inputString);

            // RSACryptoServiceProvider here;

            int maxLength = keySize - 42;
            int dataLength = bytes.Length;
            int iterations = dataLength / maxLength;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i <= iterations; i++)
            {
                byte[] tempBytes = new byte[
                        (dataLength - maxLength * i > maxLength) ? maxLength :
                                                      dataLength - maxLength * i];
                Buffer.BlockCopy(bytes, maxLength * i, tempBytes, 0,
                                  tempBytes.Length);
                byte[] encryptedBytes = rsaCryptoServiceProvider.Encrypt(tempBytes,
                                                                          true);
                stringBuilder.Append(Convert.ToBase64String(encryptedBytes));
            }
            return stringBuilder.ToString();
        }

        public string DecryptString(string inputString, int dwKeySize, string xmlString)
        {
            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
            rsaCryptoServiceProvider.FromXmlString(xmlString);
            int base64BlockSize = ((dwKeySize / 8) % 3 != 0) ? (((dwKeySize / 8) / 3) * 4) + 4 : ((dwKeySize / 8) / 3) * 4;
            int iterations = inputString.Length / base64BlockSize;
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < iterations; i++)
            {
                byte[] encryptedBytes = Convert.FromBase64String(inputString.Substring(base64BlockSize * i, base64BlockSize));
                Array.Reverse(encryptedBytes);
                arrayList.AddRange(rsaCryptoServiceProvider.Decrypt(encryptedBytes, true));
            }
            return Encoding.UTF32.GetString(arrayList.ToArray(Type.GetType("System.Byte")) as byte[]);
        }

        public void AgregarParametro(string nombre, object valor)
        {
            // Asegúrate de que la conexión está abierta
            if (conexion == null || conexion.State != ConnectionState.Open)
            {
                throw new InvalidOperationException("La conexión no está abierta.");
            }

            // Verificar que el comando está inicializado
            if (comando == null)
            {
                throw new InvalidOperationException("El comando no está inicializado.");
            }

            // Crear un nuevo parámetro
            DbParameter parametro = comando.CreateParameter();
            parametro.ParameterName = nombre;

            // Asignar el valor (usa DBNull.Value si el valor es null o vacío)
            parametro.Value = valor ?? DBNull.Value;

            // Agregar el parámetro al comando
            comando.Parameters.Add(parametro);
        }

        public DbDataAdapter CrearDataAdapter(DbCommand cmd)
        {
            return new SqlDataAdapter((SqlCommand)cmd);
        }
        #endregion

    }
}
