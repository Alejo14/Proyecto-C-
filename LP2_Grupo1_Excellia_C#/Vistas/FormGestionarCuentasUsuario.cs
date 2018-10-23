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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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
    }
}
