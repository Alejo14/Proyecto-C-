using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using LogicaNegocio;

namespace Vistas
{
    public partial class frmRevisarSolicitudRequerimiento : Form
    {
        private SolicitudCambio solCambioForm;
        public frmRevisarSolicitudRequerimiento(SolicitudCambio solCambio)
        {
            InitializeComponent();
            solCambioForm = solCambio;
            txtProyecto.Text = solCambioForm.Proyecto.Nombre;
            txtCliente.Text = solCambioForm.Cliente.Nombre;
            txtFechaSolicitud.Text = solCambioForm.FechaSolicitud.ToString();
            txtEmpresa.Text = solCambioForm.Cliente.Empresa.RazonSocial;
            txtTipoRequerimiento.Text = solCambioForm.Requerimiento.TipoStr;
            txtRequerimiento.Text = solCambioForm.Requerimiento.Descripcion;
            txtDescripcion.Text = solCambioForm.Descripcion;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Confirma aprobación de la solicitud de modificación de requerimientos?", "Aprobar solicitud", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                SolicitudCambioBL solicitudBL = new SolicitudCambioBL();
                solicitudBL.registrarEvalucionSolicitud(solCambioForm, true);
                MessageBox.Show("Aprobación realizada exitosamente");
                DialogResult = DialogResult.OK;
            }
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            frmEvaluacionSolicitudCambio frmEvaluacion = new frmEvaluacionSolicitudCambio();
            if (frmEvaluacion.ShowDialog() == DialogResult.OK) {
                solCambioForm.Evaluacion = frmEvaluacion.EvaluacionRechazoForm;
                SolicitudCambioBL solicitudBL = new SolicitudCambioBL();
                solicitudBL.registrarEvalucionSolicitud(solCambioForm, false);
                MessageBox.Show("Desaprobación realizada exitosamente");
                DialogResult = DialogResult.OK;
            }
        }
    }
}
