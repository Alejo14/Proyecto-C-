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
            txtFechaNacimiento.Text = Convert.ToString(t.FechaNac);
            txtFechaNacimiento.Enabled = false;
            cuentaUsuarioBL = new CuentaUsuarioBL();
            cu = cuentaUsuarioBL.obtenerCuentaUsuario(t.Correo);
            txtNombreUsuario.Text = cu.NomUsuario;
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
            frmCambiarContraseña cc = new frmCambiarContraseña();
            if (cc.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
