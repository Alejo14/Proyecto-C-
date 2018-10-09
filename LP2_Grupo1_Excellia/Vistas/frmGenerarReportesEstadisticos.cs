using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class frmGenerarReportesEstadisticos : Form
    {
        public frmGenerarReportesEstadisticos()
        {
            InitializeComponent();
            dtpFInicial.Value = DateTime.Now;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void frmGenerarReportesEstadisticos_Load(object sender, EventArgs e)
        {
            cboEmpresa.Items.Insert(0,"Seleccionar");
            cboEmpresa.Items.Add("Transmar");
            cboEmpresa.Items.Add("Alicorp");
            cboEmpresa.SelectedIndex = 0;
            cboEstado.Items.Insert(0, "Seleccionar");
            cboEstado.Items.Add("En curso");
            cboEstado.Items.Add("Finalizado");
            cboEstado.Items.Add("Cancelado");
            cboEstado.SelectedIndex = 0;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se creo el reporte estadístico con éxito.");
        }
        private void dtpFInicial_ValueChanged(object sender, EventArgs e)
        {
            dtpFFinal.MinDate = dtpFInicial.Value;
        }

        
    }
}
