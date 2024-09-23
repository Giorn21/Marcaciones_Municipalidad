using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Dispositivo
    {
        public int IdDispositivo { get; set; }
        public string Descripcion { get; set; }
        public string IP {  get; set; }
        public string Mac {  get; set; }
        public string Ubicacion {  get; set; }
        public string PushProtocol { get; set; }
        public string UploadFlag { get; set; }
        public DateTime LastActivityLog { get; set; }
        public DateTime LastActivityOP { get; set; }
    }
}
