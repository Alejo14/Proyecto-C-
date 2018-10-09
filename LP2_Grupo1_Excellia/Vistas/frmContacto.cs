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
            txtCodigo.Text = "EXC145";
            txtNombre.Text = "Roberto Paredes";
            txtCorreo.Text = "r.paredes@hotmail.com";
            txtRol.Text = "Programador";
            txtTelefono.Text = "940323164";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
