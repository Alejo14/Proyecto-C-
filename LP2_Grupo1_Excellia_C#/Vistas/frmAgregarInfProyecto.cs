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
        public frmAgregarInfProyecto(ERU e)
        {
            InitializeComponent();
            txtNombre.Text = e.Descripcion.ToString();

            cboPrioridad.Items.Add(TipoPrioridad.ALTA);
            cboPrioridad.Items.Add(TipoPrioridad.MEDIA);
            cboPrioridad.Items.Add(TipoPrioridad.BAJA);
            dtpFInicio.Value = DateTime.Parse(e.FechaSolicitud.ToString());
            eru = e;
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
            pro.FechaInicio = DateTime.Parse(dtpFInicio.ToString());
            pro.FechaFinEstimada = DateTime.Parse(dtpFFEstimada.ToString());
            pro.FechaRealFin = DateTime.Parse(dtpFFReal.ToString());

            // proyectoBL.crearProyecto(); 
            MessageBox.Show("Se realizó la creación del proyecto con exito", "Creación proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
