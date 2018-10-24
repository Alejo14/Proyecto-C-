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
    public partial class frmAgregarInfProyecto : Form
    {
        private ProyectoBL proyectoBL;
        private ERU eru;
        private int idJefe;
        public frmAgregarInfProyecto(ERU e, int id)
        {
            InitializeComponent();
            proyectoBL = new ProyectoBL();
            txtNombre.Text = e.Descripcion.ToString();

            cboPrioridad.Items.Add(TipoPrioridad.ALTA);
            cboPrioridad.Items.Add(TipoPrioridad.MEDIA);
            cboPrioridad.Items.Add(TipoPrioridad.BAJA);
            dtpFInicio.Value = DateTime.Parse(e.FechaSolicitud.ToString());
            eru = e;
            idJefe = id;

            dtpFFEstimada.MinDate = dtpFInicio.Value.AddDays(1);
            dtpFFReal.MinDate = dtpFInicio.Value.AddDays(1);
            //dtpFInicio = e.FechaSolicitud;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            Proyecto pro = new Proyecto();
            pro.Nombre = txtNombre.Text.Trim();
            pro.Presupuesto = Int32.Parse(txtPresupuesto.Text.Trim());
            ERU eruPro = new ERU();
            eruPro.IdERU = Int32.Parse(eru.IdERU.ToString());
            pro.Eru = eruPro;
            if(cboPrioridad.SelectedIndex == 0)
            {
                pro.Prioridad = TipoPrioridad.ALTA;
            }else if (cboPrioridad.SelectedIndex == 1)
            {
                pro.Prioridad = TipoPrioridad.MEDIA;
            }
            else if (cboPrioridad.SelectedIndex == 2)
            {
                pro.Prioridad = TipoPrioridad.BAJA;
            }

            //MessageBox.Show(pro.Prioridad.ToString());
            pro.FechaInicio = dtpFInicio.Value;
            pro.FechaFinEstimada = dtpFFEstimada.Value;
            pro.FechaRealFin = dtpFFReal.Value;
            pro.JefeProyecto.IdTrabajador = idJefe;

            proyectoBL.CrearProyecto(pro); 
            MessageBox.Show("Se realizó la creación del proyecto con exito", "Creación proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dtpFFEstimada_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpFInicio_ValueChanged(object sender, EventArgs e)
        {
            dtpFFEstimada.MinDate = dtpFInicio.Value.AddDays(1);
            dtpFFReal.MinDate = dtpFInicio.Value.AddDays(1);
        }
    }
}
