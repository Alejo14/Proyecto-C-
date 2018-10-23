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
        //private ProyectoBL etapaBL;
        public FormVisualizarProyectos()
        {
            InitializeComponent();
            proyectoBL = new ProyectoBL();
            cboEtapa.DataSource = proyectoBL.listarEtapas();
            
            cboEtapa.DisplayMember = "NombreEtapa";
            cboEtapa.ValueMember = "IdEtapa";
            //dtpFechaComienzo.MinDate = DateTime.Today;

            //int id = 0;
            //int etapa = ((Etapa)cboEtapa.SelectedItem).IdEtapa;
            //dgvVisualizarProyectos.DataSource = proyectoBL.listarProyectosEnCurso(etapa);
        }

        private void dgvVisualizarProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //frmInformacionProyecto iP = new frmInformacionProyecto();
            //iP.Visible = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public Proyecto Proyecto { get => proyecto; set => proyecto = value; }
        private void dgvVisualizarProyectos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DateTime mifecha = dtpFechaComienzo.Value.Date;
            int dia = mifecha.Day;
            int mes = mifecha.Month;
            int anio = mifecha.Year;
            //MessageBox.Show(dia.ToString()+" "+mes.ToString()+" "+anio.ToString());
            this.DialogResult = DialogResult.OK;
            //Proyecto = new Proyecto();
            Proyecto = (Proyecto)dgvVisualizarProyectos.CurrentRow.DataBoundItem;
            
            frmInformacionProyecto iP = new frmInformacionProyecto(Proyecto);
            iP.ShowDialog();
            //iP.Visible = true;
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
            
            //cboEtapa.DataSource = proyectoBL.listarEtapas();

            //cboEtapa.DisplayMember = "NombreEtapa";
            //cboEtapa.ValueMember = "IdEtapa";

            //int etapa = ((Etapa)cboEtapa.SelectedItem).IdEtapa;
            //dgvVisualizarProyectos.DataSource = proyectoBL.listarProyectosEnCurso(etapa);

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

        private void lblProyectosEnCurso_Click(object sender, EventArgs e)
        {

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
