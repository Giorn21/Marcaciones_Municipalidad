using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace common
{
    public class clsDatos_cboxAgrUnidad
    {
        private readonly BaseDatos DB = new BaseDatos();

        // Método para cargar los tipos de contrato en el ComboBox
        public void CargarUnidadDireccion(ComboBox cboxDirecion)
        {
            try
            {
                DB.Conectar();
                DbCommand cmd = DB.CrearComando("sp_ObtenerUnidadDireccion");
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();

                using (DbDataAdapter da = DB.CrearDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                cboxDirecion.DataSource = dt;
                cboxDirecion.DisplayMember = "Descripcion";
                cboxDirecion.ValueMember = "IdDireccion";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar tipos de contratos: " + ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }
        }

        public void CargarUnidadUbicacino(ComboBox cboxUbicacion)
        {
            try
            {
                DB.Conectar();
                DbCommand cmd = DB.CrearComando("sp_ObtenerUnidadUbicacion");
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();

                using (DbDataAdapter da = DB.CrearDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                cboxUbicacion.DataSource = dt;
                cboxUbicacion.DisplayMember = "Ubicacion";
                cboxUbicacion.ValueMember = "Ubicacion";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar tipos de cargo: " + ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }
        }
    }
}
