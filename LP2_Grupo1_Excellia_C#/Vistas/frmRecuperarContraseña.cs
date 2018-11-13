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

namespace Vistas
{
    public partial class frmRecuperarContraseña : Form
    {
        private CuentaUsuarioBL cuentasUsuarioBl;
        public frmRecuperarContraseña()
        {
            InitializeComponent();
            cuentasUsuarioBl = new CuentaUsuarioBL();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                MessageBox.Show("Debe ingresar su correo electrónico.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CuentaUsuario cu = cuentasUsuarioBl.obtenerCuentaUsuario(txtCorreo.Text);
            if (cu == null)
            {
                MessageBox.Show("No existe dicho nombre de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (txtCorreo.Text != cu.Persona.Correo)
            {
                MessageBox.Show("Correo Incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            if (cuentasUsuarioBl.recuperarContraseña(cu))
                MessageBox.Show("El código de recuperación se ha enviado exitósamente.", "Recuperación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Ha ocurrido un error durante el envío del correo." + System.Environment.NewLine + "Intentar más tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
