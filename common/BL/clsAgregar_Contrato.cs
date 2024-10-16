using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace common
{
    public class clsAgregar_Contrato
    {
        BaseDatos DB = new BaseDatos();
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

        public List<TipoContrato> DataSource { get; set; }

        public clsAgregar_Contrato()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion

        public void InsertarContrato(int IdContrato, string Descripcion)
        {
            clsAgregar_LogsApp logs = new clsAgregar_LogsApp();

            try
            {
                DB.Conectar();
                DB.CrearComando("TipoContratoInsProc @TipoContrato, @Descripcion");

                DB.AgregarParametro("@TipoContrato", IdContrato);
                DB.AgregarParametro("@Descripcion", Descripcion);

                DB.EjecutarComando();

                MessageBox.Show("Contrato Agregado Correctamente.");
                string Usuario = LoginUser.Usuario;
                logs.InsertarLog("Contrato", "Con Nuevo", Usuario, "Se a agregado un nuevo Contrato a la base de datos.");
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al insertar un nuevo Contrato: " + ex.Message);
                string Usuario = LoginUser.Usuario;
                logs.InsertarLog("Contrato", "Err_Contrato", Usuario, ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }
        }
    }
}
