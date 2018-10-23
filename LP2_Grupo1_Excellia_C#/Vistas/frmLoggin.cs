using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using LogicaNegocio;
using System.Runtime.InteropServices;

namespace Vistas
{
    public partial class frmLoggin : Form
    {
        private CuentaUsuario usuarioLogin;
        private CuentaUsuarioBL cuentaUsuarioBL;
        public frmLoggin()
        {
            InitializeComponent();
            cuentaUsuarioBL = new CuentaUsuarioBL();
        }

        public int IdTrabajador
        {
            get{
                if(usuarioLogin.Persona is JefeProyecto)
                {
                    JefeProyecto p = (JefeProyecto)usuarioLogin.Persona;
                    return p.IdTrabajador;
                }
                else if(usuarioLogin.Persona is Operario)
                {
                    Operario o = (Operario)usuarioLogin.Persona;
                    return o.IdTrabajador;
                }else if(usuarioLogin.Persona is Administrador)
                {
                    Administrador a = (Administrador)usuarioLogin.Persona;
                    return a.IdTrabajador;
                }
                return -1;
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Debe ingresar tanto usuario como contraseña para acceder al sistema","Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            usuarioLogin = new CuentaUsuario();
            usuarioLogin.NomUsuario = txtUsuario.Text;
            usuarioLogin.Contrasena = txtContraseña.Text;

            int tipoUsuario = cuentaUsuarioBL.validarUsuario(usuarioLogin);
            if (tipoUsuario < 0)
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(tipoUsuario == 1)
                {
                    FormMenuOperario mp = new FormMenuOperario();
                    this.Hide();
                    mp.ShowDialog();
                    this.Close();
                }
                else if(tipoUsuario == 2)
                {
                    frmMenuJefeProyecto mj = new frmMenuJefeProyecto();
                    this.Hide();
                    mj.ShowDialog();
                    this.Close();
                }else if(tipoUsuario == 4)
                {
                    MessageBox.Show("Falta implementar la vista de Administrador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("No tiene permisos para hacer uso del sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Nombre de usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Nombre de usuario";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.PasswordChar = '*';
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.PasswordChar = '\0';
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Silver;  
            }
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
