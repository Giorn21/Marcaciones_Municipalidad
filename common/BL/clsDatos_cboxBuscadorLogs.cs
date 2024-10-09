using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class clsDatos_cboxBuscadorLogs
    {
        private BaseDatos DB;

        public clsDatos_cboxBuscadorLogs()
        {
            DB = new BaseDatos();
        }

        public List<string> CargarProcesos()
        {
            var procesos = new List<string>();
            try
            {
                // Aquí debes cambiar "sp_CargarProcesos" por el nombre de tu procedimiento almacenado
                DB.Conectar();
                DB.CrearComando("sp_CargarProcesos");
                DbDataReader dr = DB.EjecutarConsulta();
                while (dr.Read())
                {
                    procesos.Add(dr["Proceso"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar procesos: " + ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }

            procesos.Insert(0, "Seleccione");

            return procesos;
        }

        public List<string> CargarUsuarios()
        {
            var usuarios = new List<string>();
            try
            {
                // Aquí debes cambiar "sp_CargarUsuarios" por el nombre de tu procedimiento almacenado
                DB.Conectar();
                DB.CrearComando("sp_CargarUsuarios");
                DbDataReader dr = DB.EjecutarConsulta();
                while (dr.Read())
                {
                    usuarios.Add(dr["Usuario"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar usuarios: " + ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }
            usuarios.Insert(0, "Seleccione");
            return usuarios;
        }
    }
}
