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
    public partial class frmBuscarContactoTrabajador : Form
    {
        public frmBuscarContactoTrabajador()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmContacto c = new frmContacto();
            if (c.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnAvanzada_Click(object sender, EventArgs e)
        {
            frmBuscarTrabajador bt = new frmBuscarTrabajador();
            if(bt.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
