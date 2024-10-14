using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace common
{
    public class clsBuscadorLogs
    {
        public class clsBuscarLogs
        {
            private BaseDatos DB = new BaseDatos();

            public List<Logs> BuscarLogs(DateTime desde, DateTime hasta, string proceso, string descripcion, string usuario)
            {
                var logsList = new List<Logs>();
                try
                {
                    // Asegúrate de que la conexión esté abierta
                    DB.Conectar();
                    DB.CrearComando("sp_buscador_Logs @Desde, @Hasta, @Proceso, @Descripcion, @Usuario");

                    // Añadir los parámetros al comando
                    DB.AsignarParametroFecha("@Desde", desde);
                    DB.AsignarParametroFecha("@Hasta", hasta);
                    DB.AsignarParametroCadena("@Proceso", proceso);
                    DB.AsignarParametroCadena("@Descripcion", descripcion);
                    DB.AsignarParametroCadena("@Usuario", usuario);


                    // Ejecutar la consulta
                    using (DbDataReader dr = DB.EjecutarConsulta())
                    {
                        while (dr.Read())
                        {
                            Logs logApp = new Logs
                            {
                                Fecha = dr["Fecha"] != DBNull.Value ? Convert.ToDateTime(dr["Fecha"]) : DateTime.MinValue,
                                Proceso = dr["Proceso"] != DBNull.Value ? dr["Proceso"].ToString() : "Sin Proceso",
                                Accion = dr["Accion"] != DBNull.Value ? dr["Accion"].ToString() : "Sin Acción",
                                Usuario = dr["Usuario"] != DBNull.Value ? dr["Usuario"].ToString() : "Desconocido",
                                Descripcion = dr["Descripcion"] != DBNull.Value ? dr["Descripcion"].ToString() : "Sin Descripción",
                                Host = dr["Host"] != DBNull.Value ? dr["Host"].ToString() : "Sin Host"
                            };

                            logsList.Add(logApp);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar logs: " + ex.Message);
                }
                finally
                {
                    DB.Desconectar();
                }

                return logsList;
            }
        }
    }
}



