﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EUsuario
    {
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }

        public int idEmpleado { get; set; }
    }
}
