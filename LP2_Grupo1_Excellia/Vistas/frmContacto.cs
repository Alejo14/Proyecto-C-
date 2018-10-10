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
    public partial class frmContacto : Form
    {
        public frmContacto()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            txtCorreo.Enabled = false;
            txtNombre.Enabled = false;
            txtRol.Enabled = false;
            txtTelefono.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
