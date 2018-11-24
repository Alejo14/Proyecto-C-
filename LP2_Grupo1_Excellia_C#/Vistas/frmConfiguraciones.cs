using LogicaNegocio;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class frmConfiguraciones : Form
    {
        private CuentaUsuarioBL cuentaUsuarioBL;
        private CuentaUsuario cu;
        public frmConfiguraciones(Operario op, int seleccionador)
        {
            InitializeComponent();
            txtNombre.Text = op.Nombre;
            txtNombre.Enabled = false;
            txtApellidos.Text = op.ApellidoPaterno + " " + op.ApellidoMaterno;
            txtApellidos.Enabled = false;
            txtTelefono.Text = op.Telefono;
            txtTelefono.Enabled = false;
            txtSexo.Text = Convert.ToString(op.Sexo);
            txtSexo.Enabled = false;
            txtCorreo.Text = op.Correo;
            txtFechaNacimiento.Text = Convert.ToString(op.FechaNac);
            txtFechaNacimiento.Enabled = false;
            cuentaUsuarioBL = new CuentaUsuarioBL();
            cu = cuentaUsuarioBL.obtenerCuentaUsuario(op.Correo);
            txtNombreUsuario.Text = cu.NomUsuario;
            txtTipoUsuario.Text = Convert.ToString(op.Cargo);
            txtTipoUsuario.Enabled = false;
            txtDominio.Text = Convert.ToString(op.Dominio);
            txtDominio.Enabled = false;  
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se han guardado los cambios");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCambiarContrseña_Click(object sender, EventArgs e)
        {

        }
    }
}
