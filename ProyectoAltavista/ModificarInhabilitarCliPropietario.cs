﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAltavista
{
    public partial class ModificarInhabilitarCliPropietario : Form
    {
        public ModificarInhabilitarCliPropietario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MantenedorCliPropietario mantCliPropietario = new MantenedorCliPropietario();
            mantCliPropietario.Show();
            this.Close();
        }
    }
}
