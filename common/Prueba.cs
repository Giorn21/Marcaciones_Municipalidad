﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Prueba
    {
        readonly BaseDatos DB = new BaseDatos();

        public Prueba()
        {
            DB.Conectar();
        }
    }
}
