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
using Modelo;

namespace Vistas
{
    public partial class FormMenuOperario : Form
    {
        private Operario op;
        private bool menuEscodido;
        public FormMenuOperario(Operario operario)
        {
            InitializeComponent();
            AbrirFormInPanel(new FormVisualizarProyectos(true));
            menuEscodido = false;
            op = operario;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void btnVisualizarProyectos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormVisualizarProyectos(true));
        }
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.scOperario.Panel2.Controls.Count > 0)
                this.scOperario.Panel2.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.scOperario.Panel2.Controls.Add(fh);
            this.scOperario.Panel2.Tag = fh;
            fh.Show();
        }
        private void btnSolicitarRetiroProyecto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmSolicitarRetiroDeProyecto(op));
        }

        private void btnExportarReportes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmExportarReportes());
        }

        private void bttLogOut_Click(object sender, EventArgs e)
        {
            frmLoggin lg = new frmLoggin();
            this.Hide();
            if (lg.ShowDialog() == DialogResult.OK)
            {
                lg.Visible = true;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menuEscodido)
            {
                scOperario.Panel1.Show();
                scOperario.SplitterDistance = 260;
                scOperario.SplitterWidth = 4;
                menuEscodido = false;

            }
            else
            {
                scOperario.Panel1.Hide();
                scOperario.SplitterDistance = 0;
                scOperario.SplitterWidth = 85;
                menuEscodido = true;
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir sin cerrar sesión.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
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
