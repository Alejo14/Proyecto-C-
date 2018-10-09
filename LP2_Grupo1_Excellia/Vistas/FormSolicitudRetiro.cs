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
    public partial class FormSolicitudRetiro : Form
    {
        public FormSolicitudRetiro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSolicitarRetiro_Click(object sender, EventArgs e)
        {
            String mensaje;
            if (txtMotivoSolicitud.Text == "")
            {
                mensaje = "Registro inválido: Debe especificar Motivo de Solicitud";
            }
            else
                mensaje = "Solicitud de registro exitosa";
            MessageBox.Show(mensaje);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dgvSolicitudRetiro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
