using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using Modelo;

namespace Vistas
{
    public partial class frmMenuJefeProyecto : Form
    {
        private int id_jefe;
        private bool menuEscodido;
        private JefeProyecto jf;
        public frmMenuJefeProyecto(JefeProyecto jefeProyecto)
        {
            InitializeComponent();
            AbrirFormInPanel(new FormVisualizarProyectos(false));
            menuEscodido = false;
            jf = jefeProyecto;
            id_jefe = jefeProyecto.IdTrabajador;
            lblUsuarios.Text = jf.Nombre + " " + jf.ApellidoPaterno + " " + jf.ApellidoMaterno + Environment.NewLine
                + jf.Telefono + Environment.NewLine + jf.Correo;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);        
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (menuEscodido)
            {
                scJefeProyecto.Panel1.Show();
                scJefeProyecto.SplitterDistance = 235;
                scJefeProyecto.SplitterWidth = 4;
                menuEscodido = false;

            }
            else
            {
                scJefeProyecto.Panel1.Hide();
                scJefeProyecto.SplitterDistance = 0;
                scJefeProyecto.SplitterWidth = 85;
                menuEscodido = true;
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
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

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.scJefeProyecto.Panel2.Controls.Count > 0)
                this.scJefeProyecto.Panel2.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.scJefeProyecto.Panel2.Controls.Add(fh);
            this.scJefeProyecto.Panel2.Tag = fh;
            fh.Show();
        }
        private void btnExportarReportes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmExportarReportes());
        }

        private void btnVisualizarProyectos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormVisualizarProyectos(false));
        }

        private void btnBuscarContacto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmBuscarTrabajador(0));
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLoggin lg = new frmLoggin();
            this.Hide();
            if (lg.ShowDialog() == DialogResult.OK)
            {
                lg.Visible = true;
            }
        }

        private void btnGenerarProyecto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmGenerarProyecto(id_jefe));
        }

        private void btnGestionRequerimientos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmSolicitudesModificacionRequerimientos(id_jefe));
        }

        private void ptbUsuarios_Click(object sender, EventArgs e)
        {
            Operario op = new Operario();
            op.Nombre = jf.Nombre;
            op.ApellidoMaterno = jf.ApellidoMaterno;
            op.ApellidoPaterno = jf.ApellidoPaterno;
            op.Correo = jf.Correo;
            frmConfiguraciones conf = new frmConfiguraciones(op,1);
            if(conf.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
