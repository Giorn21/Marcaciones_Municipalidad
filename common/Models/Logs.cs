﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Logs
    {
        public int IdLog { get; set; }
        public DateTime Fecha { get; set; }
        public string Proceso { get; set; }
        public string Accion { get; set; }
        public string Usuario { get; set; }
        public string Descripcion { get; set; }
        public string Host { get; set; }
    }
}
