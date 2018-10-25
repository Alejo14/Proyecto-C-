using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using Modelo;

namespace Vistas
{
    public partial class FormGestionarCuentasUsuario : Form
    {

        private BindingList<CuentaUsuario> usuarios;
        private CuentaUsuarioBL cuentaUsuarioBL;
        public FormGestionarCuentasUsuario()
        {
            InitializeComponent();
            cuentaUsuarioBL = new CuentaUsuarioBL();
            usuarios = cuentaUsuarioBL.obtenerCuentasUsuario();
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.DataSource = usuarios;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            FormAgregarUsuario aUsuario = new FormAgregarUsuario();
            if (aUsuario.ShowDialog() == DialogResult.OK)
            {
                usuarios.Add(aUsuario.Usuario);
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir sin cerrar cesión", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
