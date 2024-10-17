using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Horario
    {
        public int IdHorario { get; set; }
        public string Descripcion { get; set; }
        public bool Lunes { get; set; }
        public TimeSpan L_EntradaMañana { get; set; }
        public TimeSpan L_SalidaMañana { get; set; }
        public TimeSpan L_EntradaTarde { get; set; }
        public TimeSpan L_SalidaTarde { get; set; }
        public int L_ToleranciaEntrada { get; set; }
        public int L_ToleranciaSalida { get; set; }
        public bool Martes { get; set; }
        public TimeSpan M_EntradaMañana { get; set; }
        public TimeSpan M_SalidaMañana { get; set; }
        public TimeSpan M_EntradaTarde { get; set; }
        public TimeSpan M_SalidaTarde { get; set; }
        public int M_ToleranciaEntrada { get; set; }
        public int M_ToleranciaSalida { get; set; }
        public bool Miercoles { get; set; }
        public TimeSpan X_EntradaMañana { get; set; }
        public TimeSpan X_SalidaMañana { get; set; }
        public TimeSpan X_EntradaTarde { get; set; }
        public TimeSpan X_SalidaTarde { get; set; }
        public int X_ToleranciaEntrada { get; set; }
        public int X_ToleranciaSalida { get; set; }
        public bool Jueves { get; set; }
        public TimeSpan  J_EntradaMañana { get; set; }
        public TimeSpan J_SalidaMañana { get; set; }
        public TimeSpan J_EntradaTarde { get; set; }
        public TimeSpan J_SalidaTarde { get; set; }
        public int J_ToleranciaEntrada { get; set; }
        public int J_ToleranciaSalida { get; set; }
        public bool Viernes { get; set; }
        public TimeSpan V_EntradaMañana { get; set; }
        public TimeSpan V_SalidaMañana { get; set; }
        public TimeSpan V_EntradaTarde { get; set; }
        public TimeSpan V_SalidaTarde { get; set; }
        public int V_ToleranciaEntrada { get; set; }
        public int V_ToleranciaSalida { get; set; }
        public bool Sabado { get; set; }
        public TimeSpan S_EntradaMañana { get; set; }
        public TimeSpan S_SalidaMañana { get; set; }
        public TimeSpan S_EntradaTarde { get; set; }
        public TimeSpan S_SalidaTarde { get; set; }
        public int S_ToleranciaEntrada { get; set; }
        public int S_ToleranciaSalida { get; set; }
        public bool Domingo { get; set; }
        public TimeSpan D_EntradaMañana { get; set; }
        public TimeSpan D_SalidaMañana { get; set; }
        public TimeSpan D_EntradaTarde { get; set; }
        public TimeSpan D_SalidaTarde { get; set; }
        public int D_ToleranciaEntrada { get; set; }
        public int D_ToleranciaSalida { get; set; }
        public int TotalHorasSemanales { get; set; }
    }
}
