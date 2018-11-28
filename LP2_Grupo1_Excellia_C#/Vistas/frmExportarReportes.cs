using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.Shared;
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

            dtpFEstimada.Enabled = false;
            dtpFInicial.Enabled = false;
        }

        private void dtpFInicial_ValueChanged(object sender, EventArgs e)
        {
            dtpFEstimada.MinDate = dtpFInicial.Value;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ParameterFields parametrosReporte = new ParameterFields();
            ParameterField parametroFechaMin = new ParameterField();
            ParameterField parametroFechaMax = new ParameterField();
            parametroFechaMin.Name = "FECHA_MIN";
            parametroFechaMax.Name = "FECHA_MAX";

            ParameterDiscreteValue valFechaMin = new ParameterDiscreteValue();
            ParameterDiscreteValue valFechaMax = new ParameterDiscreteValue();

            valFechaMin.Value = dtpFInicial.Value;
            valFechaMax.Value = dtpFEstimada.Value;
            parametroFechaMin.CurrentValues.Add(valFechaMin);
            parametroFechaMax.CurrentValues.Add(valFechaMax);

            parametrosReporte.Add(parametroFechaMin);
            parametrosReporte.Add(parametroFechaMax);

            frmDetalleReporte detalleReporte = new frmDetalleReporte(parametrosReporte);
            if(detalleReporte.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Se realizó la exportación con éxito");
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
