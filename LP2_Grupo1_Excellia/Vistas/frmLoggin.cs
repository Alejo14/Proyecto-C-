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
    public partial class frmLoggin : Form
    {
        public frmLoggin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Ingrese su Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Ingrese su Contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormMenuPrincipal mp = new FormMenuPrincipal();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void lklblContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperarContraseña rc = new frmRecuperarContraseña();
            this.Hide();
            if (rc.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }
    }
}
