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
    public class cls_UPD_Unidad
    {
        BaseDatos DB = new BaseDatos();

        #region Propiedades
        private string usuario;
        private string host;

        public string Host
        {
            get { return host; }
            set { host = value; }
        }

        public cls_UPD_Unidad()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        public bool ActualizarUnidad(int idUnidad, int direccion, string nombreCentro, string ubicacion, string telefono, string email)
        {
            bool resultado = false;
            DB.Conectar();

            try
            {
                DB.CrearComando("sp_UPD_Unidad @IdUnidad, @Direccion, @NombreCentro, @Ubicacion, @Telefono, @Email");
                DB.AsignarParametroEntero("@IdUnidad", idUnidad);
                DB.AsignarParametroEntero("@Direccion", direccion);
                DB.AsignarParametroCadena("@NombreCentro", nombreCentro);
                DB.AsignarParametroCadena("@Ubicacion", ubicacion);
                DB.AsignarParametroCadena("@Telefono", telefono);
                DB.AsignarParametroCadena("@Email", email);

                DB.EjecutarComando();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la unidad: " + ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }

            return resultado;
        }
    }
}
