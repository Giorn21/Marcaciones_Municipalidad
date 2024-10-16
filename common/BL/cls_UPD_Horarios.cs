using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace common
{
    public class cls_UPD_Horarios
    {
        private BaseDatos DB = new BaseDatos();

        public void ActualizarHorario(
            TimeSpan lEntradaManana, TimeSpan lSalidaManana, TimeSpan lEntradaTarde, TimeSpan lSalidaTarde, int lToleranciaEntrada, int lToleranciaSalida,
            TimeSpan mEntradaManana, TimeSpan mSalidaManana, TimeSpan mEntradaTarde, TimeSpan mSalidaTarde, int mToleranciaEntrada, int mToleranciaSalida,
            TimeSpan xEntradaManana, TimeSpan xSalidaManana, TimeSpan xEntradaTarde, TimeSpan xSalidaTarde, int xToleranciaEntrada, int xToleranciaSalida,
            TimeSpan jEntradaManana, TimeSpan jSalidaManana, TimeSpan jEntradaTarde, TimeSpan jSalidaTarde, int jToleranciaEntrada, int jToleranciaSalida,
            TimeSpan vEntradaManana, TimeSpan vSalidaManana, TimeSpan vEntradaTarde, TimeSpan vSalidaTarde, int vToleranciaEntrada, int vToleranciaSalida,
            TimeSpan sEntradaManana, TimeSpan sSalidaManana, TimeSpan sEntradaTarde, TimeSpan sSalidaTarde, int sToleranciaEntrada, int sToleranciaSalida,
            TimeSpan dEntradaManana, TimeSpan dSalidaManana, TimeSpan dEntradaTarde, TimeSpan dSalidaTarde, int dToleranciaEntrada, int dToleranciaSalida,
            decimal totalHorasSemanales)
        {
            try
            {
                DB.Conectar();

                DB.CrearComando("sp_UPD_Horario"); 

                // Asignar los parámetros
                DB.AsignarParametro("@L_EntradaMañana", lEntradaManana);
                DB.AsignarParametro("@L_SalidaMañana", lSalidaManana);
                DB.AsignarParametro("@L_EntradaTarde", lEntradaTarde);
                DB.AsignarParametro("@L_SalidaTarde", lSalidaTarde);
                DB.AsignarParametro("@L_ToleranciaEntrada", lToleranciaEntrada);
                DB.AsignarParametro("@L_ToleranciaSalida", lToleranciaSalida);

                DB.AsignarParametro("@M_EntradaMañana", mEntradaManana);
                DB.AsignarParametro("@M_SalidaMañana", mSalidaManana);
                DB.AsignarParametro("@M_EntradaTarde", mEntradaTarde);
                DB.AsignarParametro("@M_SalidaTarde", mSalidaTarde);
                DB.AsignarParametro("@M_ToleranciaEntrada", mToleranciaEntrada);
                DB.AsignarParametro("@M_ToleranciaSalida", mToleranciaSalida);

                DB.AsignarParametro("@X_EntradaMañana", xEntradaManana);
                DB.AsignarParametro("@X_SalidaMañana", xSalidaManana);
                DB.AsignarParametro("@X_EntradaTarde", xEntradaTarde);
                DB.AsignarParametro("@X_SalidaTarde", xSalidaTarde);
                DB.AsignarParametro("@X_ToleranciaEntrada", xToleranciaEntrada);
                DB.AsignarParametro("@X_ToleranciaSalida", xToleranciaSalida);

                DB.AsignarParametro("@J_EntradaMañana", jEntradaManana);
                DB.AsignarParametro("@J_SalidaMañana", jSalidaManana);
                DB.AsignarParametro("@J_EntradaTarde", jEntradaTarde);
                DB.AsignarParametro("@J_SalidaTarde", jSalidaTarde);
                DB.AsignarParametro("@J_ToleranciaEntrada", jToleranciaEntrada);
                DB.AsignarParametro("@J_ToleranciaSalida", jToleranciaSalida);

                DB.AsignarParametro("@V_EntradaMañana", vEntradaManana);
                DB.AsignarParametro("@V_SalidaMañana", vSalidaManana);
                DB.AsignarParametro("@V_EntradaTarde", vEntradaTarde);
                DB.AsignarParametro("@V_SalidaTarde", vSalidaTarde);
                DB.AsignarParametro("@V_ToleranciaEntrada", vToleranciaEntrada);
                DB.AsignarParametro("@V_ToleranciaSalida", vToleranciaSalida);

                DB.AsignarParametro("@S_EntradaMañana", sEntradaManana);
                DB.AsignarParametro("@S_SalidaMañana", sSalidaManana);
                DB.AsignarParametro("@S_EntradaTarde", sEntradaTarde);
                DB.AsignarParametro("@S_SalidaTarde", sSalidaTarde);
                DB.AsignarParametro("@S_ToleranciaEntrada", sToleranciaEntrada);
                DB.AsignarParametro("@S_ToleranciaSalida", sToleranciaSalida);

                DB.AsignarParametro("@D_EntradaMañana", dEntradaManana);
                DB.AsignarParametro("@D_SalidaMañana", dSalidaManana);
                DB.AsignarParametro("@D_EntradaTarde", dEntradaTarde);
                DB.AsignarParametro("@D_SalidaTarde", dSalidaTarde);
                DB.AsignarParametro("@D_ToleranciaEntrada", dToleranciaEntrada);
                DB.AsignarParametro("@D_ToleranciaSalida", dToleranciaSalida);

                DB.AsignarParametro("@TotalHorasSemanales", totalHorasSemanales);

                DB.EjecutarComando();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el horario: " + ex.Message);
            }
            finally
            {
                DB.Desconectar();
            }
        }
    }
}
