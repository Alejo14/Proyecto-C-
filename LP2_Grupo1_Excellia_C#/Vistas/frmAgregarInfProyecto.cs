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

            txtNombre.Validating += TxtNombre_Validating;
            txtPresupuesto.Validating += TxtPresupuesto_Validating;
            //dtpFInicio = e.FechaSolicitud;
        }

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            string nombreProyecto = txtNombre.Text.Trim().Replace("  ", " ");
            bool valido = nombreProyecto.All(caracter => char.IsLetterOrDigit(caracter) || char.IsWhiteSpace(caracter));
            if (valido)
                errorProviderNombProyecto.SetError(txtNombre, "");
            else
                errorProviderNombProyecto.SetError(txtNombre, "El nombre debe estar compuesto por letras, espacios en blanco y números");
        }

        private void TxtPresupuesto_Validating(object sender, CancelEventArgs e)
        {
            double presupuesto = 0.0;
            try
            {
                presupuesto = double.Parse(txtPresupuesto.Text.Trim());

                if (presupuesto <= 0.0) {
                    errorProviderPresupuesto.SetError(txtPresupuesto, "El presupuesto debe ser mayor que 0");
                }
                else
                    errorProviderPresupuesto.SetError(txtPresupuesto, "");
            }
            catch
            {
                errorProviderPresupuesto.SetError(txtPresupuesto, "El presupuesto debe ser un valor real");
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            if (!validarNombreProyecto()) return;
            if (!validarPresupuesto()) return;

            Proyecto pro = new Proyecto();
            pro.Nombre = txtNombre.Text.Trim().Replace("  ", " ");
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
        private bool validarNombreProyecto() {
            string nombreProyecto = txtNombre.Text.Trim().Replace("  ", " ");
            bool valido = nombreProyecto.All(caracter => char.IsLetterOrDigit(caracter) || char.IsWhiteSpace(caracter));
            if (!valido)
                MessageBox.Show("El nombre debe estar compuesto por letras, espacios en blanco y números");

            return valido;
        }

        private bool validarPresupuesto() {
            double presupuesto = 0.0;
            bool valido = false;
            try
            {
                presupuesto = double.Parse(txtPresupuesto.Text.Trim());

                valido = (presupuesto > 0.0);

                if (!valido)
                {
                    MessageBox.Show("El presupuesto debe ser mayor que 0");
                }
            }
            catch
            {
                MessageBox.Show("El presupuesto debe ser un valor real");
            }

            return valido;
        }
    }
}
