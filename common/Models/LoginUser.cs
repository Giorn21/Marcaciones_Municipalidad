using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class LoginUser
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string contrasena { get; set; }

        //dato global para todos los formularios
        public static string Usuario { get; set; }
    }
}
