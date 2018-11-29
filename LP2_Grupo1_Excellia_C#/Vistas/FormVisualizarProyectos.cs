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
        private Trabajador trabajadorProyecto;
        public FormVisualizarProyectos(bool operario, Trabajador trabajador)
        {
            InitializeComponent();
            trabajadorProyecto = trabajador;
            proyectoBL = new ProyectoBL();
            cboEtapa.DataSource = proyectoBL.listarEtapas();
            
            cboEtapa.DisplayMember = "NombreEtapa";
            cboEtapa.ValueMember = "IdEtapa";
            if (operario)
            {
                btnInformacionProyecto.Visible = false;
                btnAsignar.Visible = false;
                btnRetirarOperario.Visible = false;
            }
        }

        public Proyecto Proyecto { get => proyecto; set => proyecto = value; }

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

            if (dgvVisualizarProyectos.SelectedCells.Count > 0)
            {
                Proyecto = (Proyecto)dgvVisualizarProyectos.CurrentRow.DataBoundItem;
                frmRetirarOperarioXProyecto frm = new frmRetirarOperarioXProyecto(Proyecto);
                if(frm.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("Se debe de seleccionar un proyecto para retirar operarios", "Retirar operarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (dgvVisualizarProyectos.SelectedCells.Count > 0)
            {
                Proyecto = (Proyecto)dgvVisualizarProyectos.CurrentRow.DataBoundItem;
                proyecto.JefeProyecto = (JefeProyecto)trabajadorProyecto;
                frmAsignarTrabajador at = new frmAsignarTrabajador(Proyecto);
                if (at.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("Se debe de seleccionar un proyecto para asignar operarios", "Asignar operarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInformacionProyecto_Click(object sender, EventArgs e)
        {
            if (dgvVisualizarProyectos.SelectedCells.Count > 0)
            {
                DateTime mifecha = dtpFechaComienzo.Value.Date;
                int dia = mifecha.Day;
                int mes = mifecha.Month;
                int anio = mifecha.Year;
                this.DialogResult = DialogResult.OK;
                Proyecto = (Proyecto)dgvVisualizarProyectos.CurrentRow.DataBoundItem;
                if (trabajadorProyecto is JefeProyecto)
                    Proyecto.JefeProyecto = (JefeProyecto)trabajadorProyecto;

                frmInformacionProyecto iP = new frmInformacionProyecto(Proyecto);
                iP.ShowDialog();
                int etapa = ((Etapa)cboEtapa.SelectedItem).IdEtapa;
                dgvVisualizarProyectos.DataSource = proyectoBL.listarProyectosEnCurso(etapa, mifecha);
            }
            else
            {
                MessageBox.Show("Se debe de seleccionar un proyecto para ver su información", "Información de proyecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSubirDocs_Click(object sender, EventArgs e)
        {
            if (dgvVisualizarProyectos.SelectedCells.Count > 0)
            {
                Proyecto = (Proyecto)dgvVisualizarProyectos.CurrentRow.DataBoundItem;
                FormSubirArchivos administadorDocs = new FormSubirArchivos(Proyecto.IdProyecto,trabajadorProyecto.IdTrabajador);
                if(administadorDocs.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un proyecto para poder subir/descargar documentos.", "Administración de Documentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
