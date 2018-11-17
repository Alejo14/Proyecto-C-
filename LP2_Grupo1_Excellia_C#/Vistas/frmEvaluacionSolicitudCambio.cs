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

namespace Vistas
{
    public partial class frmEvaluacionSolicitudCambio : Form
    {
        private Evaluacion evaluacionRechazoForm;
        public frmEvaluacionSolicitudCambio()
        {
            InitializeComponent();
        }

        public Evaluacion EvaluacionRechazoForm { get => evaluacionRechazoForm; set => evaluacionRechazoForm = value; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMotivoRechazo.Text == "") {
                MessageBox.Show("Debe agregar un motivo para poder rechazar la solicitud");
                return;
            }

            if (txtMotivoRechazo.Text.Length > 4000) {
                MessageBox.Show("El motivo no debe superar los 4000 caracteres");
                return;
            }

            evaluacionRechazoForm = new Evaluacion();

            evaluacionRechazoForm.Descripcion = txtMotivoRechazo.Text;
            evaluacionRechazoForm.Fecha = DateTime.Today;
            evaluacionRechazoForm.Resultado = false;

            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
