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
    public partial class frmInformacionProyecto : Form
    {
        private ProyectoBL proyectoBL;
        private Proyecto proyecto;
        private Proyecto Proyecto { get => proyecto; set => proyecto = value; }
        public frmInformacionProyecto(Proyecto p)
        {
            InitializeComponent();
            proyectoBL = new ProyectoBL();
            cboEtapa.DataSource = proyectoBL.listarEtapas();

            cboEtapa.DisplayMember = "NombreEtapa";
            cboEtapa.ValueMember = "IdEtapa";
            cboEtapa.SelectedIndex = p.EtapaInt-1;
            txtId.Text = p.IdProyecto.ToString();
            txtNombre.Text = p.Nombre.ToString();
            txtPresupuesto.Text = p.Presupuesto.ToString();
            txtFInicial.Text = p.FechaInicio.ToString();
            txtFEstimada.Text = p.FechaFinEstimada.ToString();

            cboPrioridad.Items.Add(TipoPrioridad.ALTA);
            cboPrioridad.Items.Add(TipoPrioridad.MEDIA);
            cboPrioridad.Items.Add(TipoPrioridad.BAJA);

            cboPrioridad.SelectedIndex = p.PrioridadInt-1;
            Proyecto = (Proyecto)p;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text.Trim().ToString());
            int pri = Int32.Parse(cboPrioridad.SelectedIndex.ToString()) + 1;
            int et = Int32.Parse(cboEtapa.SelectedIndex.ToString()) + 1;
            proyectoBL.ActualizarDatos(id, pri, et);
            MessageBox.Show("Se han realizado los cambios satisfactoriamente");
            cboEtapa.Enabled = false;
            cboPrioridad.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
        }

        private void btnCancelarProyecto_Click(object sender, EventArgs e)
        {
            if (((Etapa)cboEtapa.SelectedItem).IdEtapa != 1)
            {
                MessageBox.Show("No se pudo cancelar el proyecto. Solo se puede cancelar proyectos en etapa de Análisis", "Cancelar proyecto", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (MessageBox.Show("¿Está seguro de realizar la cancelación del proyecto?","Cancelar proyecto", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(((Etapa)cboEtapa.SelectedItem).IdEtapa == 1)
                {
                    proyectoBL.CancelarProyecto(int.Parse(txtId.Text));
                    MessageBox.Show("Se ha realizado la cancelación del proyecto");
                }
                else
                {
                    MessageBox.Show("No se pudo cancelar el proyecto. Solo se puede cancelar proyectos en etapa de Análisis", "Cancelar proyecto", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }  
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cboEtapa.Enabled = true;
            cboPrioridad.Enabled = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAsignarTrabajador_Click(object sender, EventArgs e)
        {
            frmAsignarTrabajador at = new frmAsignarTrabajador(Proyecto);
            if (at.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
