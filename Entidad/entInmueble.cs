﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entInmueble
    {
        public int idInmueble { get; set; }
        public int idSector { get; set; }
        public int idPropietario { get; set; }
        public string direccion { get; set; }
        public int precio { get; set; }
        public int precioMinimo { get; set; }
        public int nRegistroPublico { get; set; }
        public Boolean vendido { get; set; }
        public Boolean habilitado { get; set; }
    }
}