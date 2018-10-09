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
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGestionarCuentasUsuario gCU = new FormGestionarCuentasUsuario();
            gCU.Visible = true;
        }

        private void btnVisualizarProyectos_Click(object sender, EventArgs e)
        {
            FormVisualizarProyectos vP = new FormVisualizarProyectos();
            vP.Visible = true;
        }

        private void btnSolicitarRetiroProyecto_Click(object sender, EventArgs e)
        {
            frmSolicitarRetiroDeProyecto retiro = new frmSolicitarRetiroDeProyecto();
            retiro.Visible = true;
        }

        private void btnExportarReportes_Click(object sender, EventArgs e)
        {
            frmExportarReportes exportarReportes = new frmExportarReportes();
            exportarReportes.Visible = true;
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            frmChat chat = new frmChat();
            chat.Visible = true;
        }

        private void btnAsignarTrabajador_Click(object sender, EventArgs e)
        {
            frmAsignarTrabajador at = new frmAsignarTrabajador();
            at.Visible = true;
        }

        private void btnBuscarContacto_Click(object sender, EventArgs e)
        {
            frmBuscarContactoTrabajador bc = new frmBuscarContactoTrabajador();
            bc.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
