﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace ProyectoAltavista
{
    public partial class ConsultarAgente : Form
    {
        public ConsultarAgente()
        {
            InitializeComponent();
            ListarAgente();
        }

        public void ListarAgente()
        {
            dgvConsultaAgente.DataSource = logAgente.Instancia.ListarAgentes();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entAgente Age = new entAgente();
                Age.dni = int.Parse(txtDni.Text.Trim());
                if (logAgente.Instancia.BuscarAgente(Age))
                {
                    ModificarAgente modi = new ModificarAgente(Age.dni);
                    modi.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontró al agente");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            MantenedorAgente mantenedor = new MantenedorAgente();
            mantenedor.Show();
            this.Close();
        }
    }
}
