using Modelo;
using LogicaNegocio;
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
    public partial class frmAsignarTrabajador : Form
    {
        private TrabajadorBL trabajadorBL;
        public frmAsignarTrabajador()
        {
            InitializeComponent();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            bool entre = false;
            if (dgvTrabajador.Rows.Count >= 1)
            {
                DialogResult result = MessageBox.Show("Seguro que quiere asignar a estos trabajadores al proyecto.", "Advertencia",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    entre = true;
                    MessageBox.Show("Correos enviados correctamente.", "Asignación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    entre = true;
                }
            }
            if (!entre)
            {
                MessageBox.Show("Ningún trabajador seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }  
        }

        private void btnForm_Buscar_Click(object sender, EventArgs e)
        {
            trabajadorBL = new TrabajadorBL();
            dgvTrabajador.AutoGenerateColumns = false;
            dgvTrabajador.DataSource = trabajadorBL.listarTrabajadores(txtDNI.Text, txtNombre.Text,
                "", "", "", "","");
        }

        private void btnAvanzada_Click(object sender, EventArgs e)
        {
            frmBuscarTrabajador bt = new frmBuscarTrabajador(1);
            if(bt.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
