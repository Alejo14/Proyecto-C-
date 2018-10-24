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
    public partial class FormVisualizarProyectos : Form
    {
        private ProyectoBL proyectoBL;
        private Proyecto proyecto;
        public FormVisualizarProyectos(bool operario)
        {
            InitializeComponent();
            proyectoBL = new ProyectoBL();
            cboEtapa.DataSource = proyectoBL.listarEtapas();
            
            cboEtapa.DisplayMember = "NombreEtapa";
            cboEtapa.ValueMember = "IdEtapa";
            if (operario) btnRetirarOperario.Visible = false;
        }

        public Proyecto Proyecto { get => proyecto; set => proyecto = value; }
        private void dgvVisualizarProyectos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DateTime mifecha = dtpFechaComienzo.Value.Date;
            int dia = mifecha.Day;
            int mes = mifecha.Month;
            int anio = mifecha.Year;
            this.DialogResult = DialogResult.OK;
            Proyecto = (Proyecto)dgvVisualizarProyectos.CurrentRow.DataBoundItem;
            
            frmInformacionProyecto iP = new frmInformacionProyecto(Proyecto);
            iP.ShowDialog();
            int etapa = ((Etapa)cboEtapa.SelectedItem).IdEtapa;
            dgvVisualizarProyectos.DataSource = proyectoBL.listarProyectosEnCurso(etapa, mifecha);
        }

        private void cboEtapa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int etapa = ((Etapa)cboEtapa.SelectedItem).IdEtapa;
            DateTime mifecha = dtpFechaComienzo.Value.Date;
            int dia = mifecha.Day;
            int mes = mifecha.Month;
            int anio = mifecha.Year;
            dgvVisualizarProyectos.DataSource = proyectoBL.listarProyectosEnCurso(etapa, mifecha);
            dgvVisualizarProyectos.Columns["CodigoGestorProyecto"].Visible = false;
            dgvVisualizarProyectos.Columns["JefeProyecto"].Visible = false;
            dgvVisualizarProyectos.Columns["Eru"].Visible = false;
            dgvVisualizarProyectos.Columns["EtapaInt"].Visible = false;
            dgvVisualizarProyectos.Columns["EtapaString"].Visible = false;
            dgvVisualizarProyectos.Columns["PrioridadInt"].Visible = false;
            dgvVisualizarProyectos.Columns["FechaRealFin"].Visible = false;
        }

        private void FormVisualizarProyectos_Load(object sender, EventArgs e)
        {

        }

        private void dtpFechaComienzo_ValueChanged(object sender, EventArgs e)
        {
            DateTime mifecha = dtpFechaComienzo.Value.Date;
            int dia = mifecha.Day;
            int mes = mifecha.Month;
            int anio = mifecha.Year;
            int etapa = ((Etapa)cboEtapa.SelectedItem).IdEtapa;
            dgvVisualizarProyectos.DataSource = proyectoBL.listarProyectosEnCurso(etapa, mifecha);
        }

        private void btnRetirarOperario_Click(object sender, EventArgs e)
        { 

            if (dgvVisualizarProyectos.SelectedRows.Count > 0)
            {
                Proyecto = (Proyecto)dgvVisualizarProyectos.CurrentRow.DataBoundItem;
                frmRetirarOperarioXProyecto frm = new frmRetirarOperarioXProyecto(Proyecto);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Se debe de seleccionar un proyecto para retirar usuarios", "Retirar operarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    
}
