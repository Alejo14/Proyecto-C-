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
    public partial class FormVisualizarProyectos : Form
    {
        public FormVisualizarProyectos()
        {
            InitializeComponent();
        }

        private void dgvVisualizarProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmInformacionProyecto iP = new frmInformacionProyecto();
            iP.Visible = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
