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

namespace Vistas
{
    public partial class FormGestionarCuentasUsuario : Form
    {

        private BindingList<CuentaUsuario> usuarios;
        public FormGestionarCuentasUsuario()
        {
            InitializeComponent();
            usuarios = new BindingList<CuentaUsuario>();
            dgvUsuarios.DataSource = usuarios;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            FormAgregarUsuario aUsuario = new FormAgregarUsuario();
            if (aUsuario.ShowDialog() == DialogResult.OK)
            {
                usuarios.Add(aUsuario.Usuario);
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormInfUsuario infUsuario = new FormInfUsuario();

            infUsuario.Usuario = (CuentaUsuario)dgvUsuarios.CurrentRow.DataBoundItem;
            //infUsuario.MdiParent = this;
            if (infUsuario.ShowDialog() == DialogResult.OK)
            {
                usuarios.Remove(infUsuario.Usuario);
            }
        }
    }
}
