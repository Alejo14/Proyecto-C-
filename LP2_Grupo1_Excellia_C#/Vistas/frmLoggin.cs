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
        private bool noIngresoContrasena;
        private bool noIngresoUsuario;
        public frmLoggin()
        {
            InitializeComponent();
            cuentaUsuarioBL = new CuentaUsuarioBL();
            AcceptButton = btnIngresar;
            noIngresoContrasena = true;
            noIngresoUsuario = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "" || noIngresoUsuario) || (txtContraseña.Text == "" || noIngresoContrasena))
            {
                MessageBox.Show("Debe ingresar tanto usuario como contraseña para acceder al sistema","Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            usuarioLogin = new CuentaUsuario();
            usuarioLogin.NomUsuario = txtUsuario.Text;
            usuarioLogin.Contrasena = txtContraseña.Text;

            int tipoUsuario = cuentaUsuarioBL.validarUsuario(ref usuarioLogin);
            if (tipoUsuario < 0)
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                
                if(tipoUsuario == 1)
                {
                    Operario op = new Operario();
                    op = (Operario)usuarioLogin.Persona;
                    FormMenuOperario mp = new FormMenuOperario(op);
                    this.Hide();
                    mp.ShowDialog();
                    this.Close();
                }
                else if(tipoUsuario == 2)
                {
                    JefeProyecto jp = new JefeProyecto();
                    jp = (JefeProyecto)usuarioLogin.Persona;
                    frmMenuJefeProyecto mj = new frmMenuJefeProyecto(jp);
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
                noIngresoUsuario = false;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Nombre de usuario";
                txtUsuario.ForeColor = Color.Silver;
                noIngresoUsuario = true;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.PasswordChar = '*';
                noIngresoContrasena = false;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.PasswordChar = '\0';
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Silver;
                noIngresoContrasena = true;
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
