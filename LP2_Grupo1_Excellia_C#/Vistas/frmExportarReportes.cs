using System;
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
        private Proyecto proyecto;
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
            cboEmpresa.ValueMember = "IdEmpresa";
            //cboEmpresa.Items.Insert(0, "--Seleccionar--");
            cboEmpresa.Enabled = false;
            cboEstado.Enabled = false;
            dtpFEstimada.Enabled = false;
            dtpFInicial.Enabled = false;
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
            proyecto = new Proyecto();
            string empresa = "";
            string etapa = "";
            string fechaInicio = "";
            string fechaFinal = "";

            if (cboEmpresa.SelectedIndex != -1)
            {
                Cliente emp = (Cliente)cboEmpresa.SelectedItem;
                if (ckbEmpresa.Checked)
                {
                    empresa = emp.IdEmpresa.ToString();
                }
            }
            if(cboEstado.SelectedIndex != -1)
            {
                if (ckbEtapa.Checked)
                {
                    etapa = cboEstado.SelectedIndex.ToString();
                }
            }
            if (ckbFechas.Checked)
            {

            }

            //MessageBox.Show(empresa);
            //gdvBuscarReporte.AutoGenerateColumns = false;
            //gdvBuscarReporte.DataSource = proyectoBL.listarReportes();
        }

        private void gdvBuscarReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ckbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEmpresa.Checked == true)
            {
                cboEmpresa.Enabled = true;
            }
            else
            {
                cboEmpresa.Enabled = false;
            }
        }

        private void ckbEtapa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEtapa.Checked == true)
            {
                cboEstado.Enabled = true;
            }
            else
            {
                cboEstado.Enabled = false;
            }
        }

        private void ckFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFechas.Checked == true)
            {
                dtpFEstimada.Enabled = true;
                dtpFInicial.Enabled = true;
            }
            else
            {
                dtpFEstimada.Enabled = false;
                dtpFInicial.Enabled = false;
            }
        }
    }
}
