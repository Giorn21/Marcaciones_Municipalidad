using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace common
{
    public class clsAgregar_Unidad
    {
        readonly BaseDatos DB = new BaseDatos();
        private string usuario;
        private string host;

        public clsAgregar_Unidad()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }

        public void AgregarUnidad(string Direccion, string descripcion, string ubicacion, string telefono, string email)
        {
            DB.Conectar();

            try
            {
                DB.CrearComando("sp_InsertarUnidad @IdDireccion, @Descripcion, @Ubicacion, @Telefono, @Email");

                // Agregar parámetros
                DB.AgregarParametro("@IdDireccion", Direccion);
                DB.AgregarParametro("@Descripcion", descripcion);
                DB.AgregarParametro("@Ubicacion", ubicacion);  
                DB.AgregarParametro("@Telefono", telefono);    
                DB.AgregarParametro("@Email", email);

                // Ejecutar comando
                DB.EjecutarComando();

                MessageBox.Show("Unidad agregada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la unidad: " + ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }
        }
    }
}
