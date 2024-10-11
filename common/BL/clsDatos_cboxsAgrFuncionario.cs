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

namespace common.BL
{
    public class clsDatos_cboxsAgrFuncionario
    {
        private readonly BaseDatos DB = new BaseDatos();

        // Método para cargar los tipos de contrato en el ComboBox
        public void CargarTiposContratos(ComboBox cboxTipoContrato)
        {
            try
            {
                DB.Conectar();
                DbCommand cmd = DB.CrearComando("sp_ObtenerTiposContratos");
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();

                using (DbDataAdapter da = DB.CrearDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                cboxTipoContrato.DataSource = dt;
                cboxTipoContrato.DisplayMember = "Descripcion";
                cboxTipoContrato.ValueMember = "TipoContrato";
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

        public void CargarTipoCargo(ComboBox cboxTipoCargo)
        {
            try
            {
                DB.Conectar();
                DbCommand cmd = DB.CrearComando("sp_ObtenerTiposCargos");
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();

                using (DbDataAdapter da = DB.CrearDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                cboxTipoCargo.DataSource = dt;
                cboxTipoCargo.DisplayMember = "Descripcion";
                cboxTipoCargo.ValueMember = "IdCargo";
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

        public void CargarTipoUnidad(ComboBox cbox_IdUnidad)
        {
            try
            {
                DB.Conectar();
                DbCommand cmd = DB.CrearComando("sp_ObtenerUnidades");
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();

                using (DbDataAdapter da = DB.CrearDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                cbox_IdUnidad.DataSource = dt;
                cbox_IdUnidad.DisplayMember = "Descripcion";
                cbox_IdUnidad.ValueMember = "IdUnidad";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar unidades: " + ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }
        }

        public void CargarDispositivos(ComboBox cbox_IdDispositivo) 
        {

            try
            {
                DB.Conectar();
                DbCommand cmd = DB.CrearComando("sp_ObtenerDispositivos");
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();

                using (DbDataAdapter da = DB.CrearDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                cbox_IdDispositivo.DataSource = dt;
                cbox_IdDispositivo.DisplayMember = "Descripcion";
                cbox_IdDispositivo.ValueMember = "IdDispositivo";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar dispositivos: " + ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }
        }

        public void CargarHorarios(ComboBox cbox_Horarios) 
        {
            try
            {
                DB.Conectar();
                DbCommand cmd = DB.CrearComando("sp_ObtenerHorarios");
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();

                using (DbDataAdapter da = DB.CrearDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                // Asignar los datos al ComboBox
                cbox_Horarios.DataSource = dt;
                cbox_Horarios.DisplayMember = "Descripcion"; 
                cbox_Horarios.ValueMember = "IdHorario";       
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar horarios: " + ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }
        }
    }
}
