﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace common
{
    public class cls_UPD_TipoContrato
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

        public cls_UPD_TipoContrato()
        {
            this.usuario = Credenciales.Usuario;
            this.host = Credenciales.Host;
        }
        #endregion
        public bool ActualizarTipoContrato(int tipoContrato, string descripcion)
        {
            clsAgregar_LogsApp logs = new clsAgregar_LogsApp();
            
            bool resultado = false;
            DB.Conectar();

            try
            {
              
                DB.CrearComando("sp_UPD_TipoContrato @TipoContrato, @Descripcion");
                DB.AsignarParametroEntero("@TipoContrato", tipoContrato);
                DB.AsignarParametroCadena("@Descripcion", descripcion);

                DB.EjecutarComando();
                resultado = true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el contrato: " + ex.Message);
                string Usuario = LoginUser.Usuario;
                logs.InsertarLog("Contrato", "Err_Update", Usuario, ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }

            return resultado;
        }
    }
}