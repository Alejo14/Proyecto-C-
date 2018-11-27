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
        private TrabajadorBL trabajadorBL;
        public frmConfiguraciones(Trabajador t, int seleccionador)
        {
            InitializeComponent();
            trabajadorBL = new TrabajadorBL();
            txtNombre.Text = t.Nombre;
            txtNombre.Enabled = false;
            txtApellidos.Text = t.ApellidoPaterno + " " + t.ApellidoMaterno;
            txtApellidos.Enabled = false;
            txtTelefono.Text = t.Telefono;
            txtTelefono.Enabled = false;
            txtSexo.Text = Convert.ToString(t.Sexo);
            txtSexo.Enabled = false;
            txtCorreo.Text = t.Correo;
            txtCorreo.Validating += txtCorreo_Validating;
            txtFechaNacimiento.Text = Convert.ToString(t.FechaNac);
            txtFechaNacimiento.Enabled = false;
            cuentaUsuarioBL = new CuentaUsuarioBL();
            cu = cuentaUsuarioBL.obtenerCuentaUsuario(t.Correo);
            txtNombreUsuario.Text = cu.NomUsuario;
            txtNombreUsuario.Validating += txtNombreUsuario_Validating;
            if (seleccionador == 0)
            {
                Operario op = (Operario)t;
                txtTipoUsuario.Text = Convert.ToString(op.Cargo);
            }
            else
            {
                txtTipoUsuario.Text = "JEFE DE PROYECTO";
            }
            txtTipoUsuario.Enabled = false;
            txtDominio.Text = trabajadorBL.obtenerDominio(t.IdTrabajador);
            txtDominio.Enabled = false;  
        }

        private void txtNombreUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombreUsuario.Text.Length < 3 && txtNombreUsuario.Text.Length > 8)
            {
                errorNombreUsuario.SetError(txtNombreUsuario, "Nombre de usuario debe tener entre 3 y 8 caracteres");
            }

            if (txtNombreUsuario.Text.Count(caracter => !char.IsLetterOrDigit(caracter)) != 0)
            {
                errorNombreUsuario.SetError(txtNombreUsuario, "Nombre de usuario debe tener solo numeros y letras");
            }
            else
            {
                errorNombreUsuario.SetError(txtNombreUsuario, "");
            }
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            int espaciosBlancos = txtCorreo.Text.Count(caracter => caracter == ' ');

            int numArroba = txtCorreo.Text.Count(caracter => caracter == '@');

            int numCar = txtCorreo.Text.Length;

            if (numCar > 80)
            {
                errorCorreo.SetError(txtCorreo, "Correo debe tener a lo mas 80 caracteres");
            }

            else if (espaciosBlancos != 0 && numArroba != 1)
            {
                errorCorreo.SetError(txtCorreo, "Correo debe poseer una @ y no debe contener espacios en blanco");
            }
            else if (espaciosBlancos != 0)
            {
                errorCorreo.SetError(txtCorreo, "Correo no debe contener Espacios en blanco");
            }

            else if (numArroba != 1)
            {
                errorCorreo.SetError(txtCorreo, "Correo debe poseer una @");
            }
            else
            {
                errorCorreo.SetError(txtCorreo, "");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (trabajadorBL.actualizarPerfil(cu))
            {
                MessageBox.Show("Se han guardado los cambios","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrió un error en la actualización de su perfil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCambiarContrseña_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña cc = new frmCambiarContraseña();
            if (cc.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
