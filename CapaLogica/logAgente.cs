﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaLogica
{
    public class logAgente
    {
        #region singleton
        private static readonly logAgente _instancia = new logAgente();
        public static logAgente Instancia
        {
            get { return logAgente._instancia; }
        }
        #endregion singleton
        public DataTable IngresarAgente(entAgente Agente)
        {
            return datAgente.Instancia.IngresoAgente(Agente);
        }
    }
}
