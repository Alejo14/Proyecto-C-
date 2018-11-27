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
        private Trabajador t;
        private Operario op;
        private JefeProyecto jf;
        private int seleccionador;
        private enum Estados { INICIAL, EDITAR, GUARDAR }
        public Operario Operario { get => op; set => value = op; }
        public JefeProyecto JefeProyecto { get => jf; set => value = jf; }
        private Estados estado;
        public frmConfiguraciones(Trabajador t, int seleccionador)
        {
            InitializeComponent();
            trabajadorBL = new TrabajadorBL();
            if(seleccionador == 0) op = new Operario();
            else jf = new JefeProyecto();
            this.t = t;
            this.seleccionador = seleccionador;
            estado = Estados.INICIAL;
            mostrarEstadoActual(estado,t,seleccionador);
        }

        private void txtNombreUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombreUsuario.Text.Length < 3 || txtNombreUsuario.Text.Length > 15)
            {
                errorNombreUsuario.SetError(txtNombreUsuario, "Nombre de usuario debe tener entre 3 y 15 caracteres");
            }
            else if (txtNombreUsuario.Text.Count(caracter => !char.IsLetterOrDigit(caracter)) != 0)
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
            if (!validarCorreo())
            {
                MessageBox.Show("Correo no válido","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (!validarNombreUsuario())
            {
                MessageBox.Show("Nombre Usuario no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cu.Persona.Correo = txtCorreo.Text.Trim();
            cu.NomUsuario = txtNombreUsuario.Text.Trim();
            if (trabajadorBL.actualizarPerfil(cu))
            {
               MessageBox.Show("Se han guardado los cambios","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrió un error en la actualización de su perfil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            estado = Estados.GUARDAR;
            mostrarEstadoActual(estado, t, seleccionador);
            if (seleccionador == 0) op.Correo = txtCorreo.Text.Trim();
            else jf.Correo = txtCorreo.Text.Trim();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCambiarContrseña_Click(object sender, EventArgs e)
        {
            cu.Persona.Correo = txtCorreo.Text.Trim();
            cu.NomUsuario = txtNombreUsuario.Text.Trim();
            frmCambiarContraseña cc = new frmCambiarContraseña(cu);
            if (cc.ShowDialog() == DialogResult.OK)
            {
                estado = Estados.GUARDAR;
                mostrarEstadoActual(estado, t, seleccionador);
                if (seleccionador == 0) op.Correo = txtCorreo.Text.Trim();
                else jf.Correo = txtCorreo.Text.Trim();
            }
        }
        private bool validarCorreo()
        {
            int espaciosBlancos = txtCorreo.Text.Count(caracter => caracter == ' ');
            int numArroba = txtCorreo.Text.Count(caracter => caracter == '@');
            int numCar = txtCorreo.Text.Length;
            bool valido = numCar <= 80 && numCar > 0 && espaciosBlancos == 0 && numArroba == 1;

            return valido;
        }
        private bool validarNombreUsuario()
        {
            int especiales = txtNombreUsuario.Text.Count(caracter => !char.IsLetterOrDigit(caracter));
            bool valido = txtNombreUsuario.Text.Length >= 3 && txtNombreUsuario.Text.Length <= 15 && especiales == 0;
            
            return valido;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = Estados.EDITAR;
            mostrarEstadoActual(estado, t, seleccionador);
        }
        private void mostrarEstadoActual(Estados e, Trabajador t, int seleccionador)
        {
            if (e == Estados.INICIAL)
            {
                txtNombre.Text = t.Nombre;
                txtNombre.Enabled = false;
                txtApellidos.Text = t.ApellidoPaterno + " " + t.ApellidoMaterno;
                txtApellidos.Enabled = false;
                txtTelefono.Text = t.Telefono;
                txtTelefono.Enabled = false;
                txtSexo.Text = Convert.ToString(t.Sexo);
                txtSexo.Enabled = false;
                txtCorreo.Text = t.Correo;
                txtCorreo.Enabled = false;
                txtFechaNacimiento.Text = Convert.ToString(t.FechaNac);
                txtFechaNacimiento.Enabled = false;
                cuentaUsuarioBL = new CuentaUsuarioBL();
                cu = cuentaUsuarioBL.obtenerCuentaUsuario(t.Correo);
                txtNombreUsuario.Text = cu.NomUsuario;
                txtNombreUsuario.Enabled = false;
                btnEditar.Visible = true;
                if (seleccionador == 0)
                {
                    op = (Operario)t;
                    txtTipoUsuario.Text = Convert.ToString(op.Cargo);
                }
                else
                {
                    jf = (JefeProyecto)t;
                    txtTipoUsuario.Text = "JEFE DE PROYECTO";
                }
                txtTipoUsuario.Enabled = false;
                txtDominio.Text = trabajadorBL.obtenerDominio(t.IdTrabajador);
                txtDominio.Enabled = false;
            }
            else if (e == Estados.EDITAR)
            {
                txtCorreo.Enabled = true;
                txtNombreUsuario.Enabled = true;
                txtCorreo.Validating += txtCorreo_Validating;
                txtNombreUsuario.Validating += txtNombreUsuario_Validating;
                btnEditar.Visible = false;
            }else if(e == Estados.GUARDAR)
            {
                txtCorreo.Enabled = false;
                txtNombreUsuario.Enabled = false;
                btnEditar.Visible = true;
            }
        }
    }
}
