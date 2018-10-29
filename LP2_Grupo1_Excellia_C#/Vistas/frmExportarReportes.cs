﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using Modelo;


namespace Vistas
{
    public partial class frmExportarReportes : Form
    {
        private ProyectoBL proyectoBL;
        public frmExportarReportes()
        {
            InitializeComponent();
            dtpFInicial.Value = DateTime.Now;
            proyectoBL = new ProyectoBL();

            cboEstado.DataSource = proyectoBL.listarEtapas();
            cboEstado.DisplayMember = "NombreEtapa";
            cboEstado.ValueMember = "IdEtapa";
            //cboEstado.Items.Insert(0, "--Seleccionar--");

            cboEmpresa.DataSource = proyectoBL.listarEmpresasClientes();
            cboEmpresa.DisplayMember = "NombreEmpresa";
            cboEmpresa.ValueMember = "IdCliente";
            //cboEmpresa.Items.Insert(0, "--Seleccionar--");
        }

        
        private void ExportarReportes_Load(object sender, EventArgs e)
        {
            /*
            cboEmpresa.Items.Insert(0,"Seleccionar");
            cboEmpresa.Items.Add("Transmar");
            cboEmpresa.Items.Add("Alicorp");
            cboEmpresa.SelectedIndex = 0;

            cboEstado.Items.Insert(0, "Seleccionar");
            cboEstado.Items.Add("En curso");
            cboEstado.Items.Add("Finalizado");
            cboEstado.Items.Add("Cancelado");
            cboEstado.SelectedIndex = 0;*/
        }

        private void cboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dtpFInicial_ValueChanged(object sender, EventArgs e)
        {
            dtpFEstimada.MinDate = dtpFInicial.Value;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se realizó la exportación con éxito");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //gdvBuscarReporte.Rows.Add("00264","Almacén Alicorp","Finalizado","6000.00","Alicorp");
        }

        private void gdvBuscarReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
