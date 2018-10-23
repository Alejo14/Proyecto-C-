using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Vistas
{
    public partial class FormMenuOperario : Form
    {
        public FormMenuOperario()
        {
            InitializeComponent();
            AbrirFormInPanel(new FormVisualizarProyectos());
            pnlMenu.Width = 262;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void btnVisualizarProyectos_Click(object sender, EventArgs e)
        {
            /*FormVisualizarProyectos vP = new FormVisualizarProyectos();
            if (vP.ShowDialog() == DialogResult.OK)
            {

            }*/
            AbrirFormInPanel(new FormVisualizarProyectos());
        }
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnSolicitarRetiroProyecto_Click(object sender, EventArgs e)
        {
            /*frmSolicitarRetiroDeProyecto retiro = new frmSolicitarRetiroDeProyecto();
            if (retiro.ShowDialog() == DialogResult.OK)
            {

            }*/
            AbrirFormInPanel(new frmSolicitarRetiroDeProyecto());
        }

        private void btnExportarReportes_Click(object sender, EventArgs e)
        {
            /*frmExportarReportes exportarReportes = new frmExportarReportes();
            if (exportarReportes.ShowDialog() == DialogResult.OK)
            {

            }*/
            AbrirFormInPanel(new frmExportarReportes());
        }

        private void btnBuscarContacto_Click(object sender, EventArgs e)
        {
            /*frmBuscarTrabajador bc = new frmBuscarTrabajador(0);
            if(bc.ShowDialog() == DialogResult.OK)
            {

            }*/
            AbrirFormInPanel(new frmBuscarTrabajador(0));
        }

        private void btnRetirarOperario_Click(object sender, EventArgs e)
        {
            /*frmRetirarOperario br = new frmRetirarOperario();
            if (br.ShowDialog() == DialogResult.OK)
            {

            }*/
            AbrirFormInPanel(new frmRetirarOperario());
        }

        private void bttChat_Click(object sender, EventArgs e)
        {
            frmChat chat = new frmChat();
            chat.Visible = true;
        }

        private void bttLogOut_Click(object sender, EventArgs e)
        {
            frmLoggin lg = new frmLoggin();
            this.Hide();
            if (lg.ShowDialog() == DialogResult.OK)
            {
                lg.Visible = true;
            }
            //Application.Exit();
        }

        private void tsbGestionarUsuario_Click(object sender, EventArgs e)
        {
            FormGestionarCuentasUsuario gCU = new FormGestionarCuentasUsuario();
            if (gCU.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 262)
            {
                pnlMenu.Width = 0;
            }
            else
            {
                pnlMenu.Width = 262;
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void iconMinimizar_MouseEnter(object sender, EventArgs e)
        {
            iconMinimizar.BackColor = Color.DarkSalmon;
        }

        private void iconCerrar_MouseEnter(object sender, EventArgs e)
        {
            iconCerrar.BackColor = Color.DarkSalmon;
        }

        private void iconCerrar_MouseLeave(object sender, EventArgs e)
        {
            iconCerrar.BackColor = Color.Transparent;
        }

        private void iconMinimizar_MouseLeave(object sender, EventArgs e)
        {
            iconMinimizar.BackColor = Color.Transparent;
        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
