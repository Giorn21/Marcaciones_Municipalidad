using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Credenciales
    {
        static string _usuario;
        static string _host;
        static string _macaddress;

        public static string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public static string Host
        {
            get { return _host; }
            set { _host = value; }
        }

        public static string MacAdress
        {
            get { return _macaddress; }
            set { _macaddress = value; }
        }
    }
}
