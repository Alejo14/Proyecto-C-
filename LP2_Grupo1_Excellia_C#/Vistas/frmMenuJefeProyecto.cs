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
        private JefeProyecto jp;
        public frmMenuJefeProyecto(JefeProyecto jefeProyecto)
        {
            InitializeComponent();
            AbrirFormInPanel(new FormVisualizarProyectos(false));
            jp = new JefeProyecto();
            jp = jefeProyecto;
        }
        public int IdJefe
        {
            get => jp.IdTrabajador;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);        
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 240)
                MenuVertical.Width = 0;
            else
                MenuVertical.Width = 240;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
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
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmExportarReportes());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormVisualizarProyectos(false));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmRetirarOperario());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmBuscarTrabajador(0));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmLoggin lg = new frmLoggin();
            this.Hide();
            if (lg.ShowDialog() == DialogResult.OK)
            {
                lg.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmGenerarProyecto());
        }
    }
}
