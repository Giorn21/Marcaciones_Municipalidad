using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Funcionario
    {
        public int IdEmpleado { get; set; }
        public string Rut { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public byte[] Foto { get; set; }
        public string Email { get; set; }
        public string Contrato { get; set; }
        public string Cargo { get; set; }
        public int IdDispositivo { get; set; }

    }
}
