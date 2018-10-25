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
    public partial class FormAgregarUsuario : Form
    {
        private CuentaUsuario usuario;
        private CuentaUsuarioBL cuentaUsuarioBL;
        public CuentaUsuario Usuario { get => usuario; set => usuario = value; }

        public FormAgregarUsuario()
        {
            InitializeComponent();
            txtNombrePersona.Validating += TxtNombrePersona_Validating;
            txtNombUsuario.Validating += TxtNombUsuario_Validating;
            txtDni.Validating += TxtDni_Validating;
            txtApellidoPaterno.Validating += TxtApellidoPaterno_Validated;
            txtApellidoMaterno.Validating += TxtApellidoMaterno_Validating;
            txtCorreo.Validating += TxtCorreo_Validating;
            txtTelefono.Validating += TxtTelefono_Validating;
            dtpFechaNacimiento.MaxDate = DateTime.Today;
            usuario = new CuentaUsuario();
            cuentaUsuarioBL = new CuentaUsuarioBL();
            DominioBL dominioBL = new DominioBL();
            cboDominio.DataSource = dominioBL.obtenerDominios();
            EmpresaBL empresaBL = new EmpresaBL();
            cboEmpresa.DataSource = empresaBL.obtenerEmpresas();
            cboDominio.Enabled = false;
            cboEmpresa.Enabled = false;
        }

        private void TxtNombUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombUsuario.Text.Length < 3 && txtNombUsuario.Text.Length > 8) {
                errorProviderNombUsuario.SetError(txtNombUsuario, "Nombre de usuario debe tener entre 3 y 8 caracteres");
            }

            if (txtNombUsuario.Text.Count(caracter => !char.IsLetterOrDigit(caracter)) != 0)
            {
                errorProviderNombUsuario.SetError(txtNombUsuario, "Nombre de usuario debe tener solo numeros y letras");
            }
            else {
                errorProviderNombUsuario.SetError(txtNombUsuario, "");
            }
        }

        private void TxtTelefono_Validating(object sender, CancelEventArgs e)
        {
            int numValido = txtTelefono.Text.Count(caracter => !char.IsDigit(caracter));

            if (txtTelefono.Text.Length > 10) {
                errorProviderTelefono.SetError(txtTelefono, "Telefono debe tener a lo mas 10 numeros");
            }

            if (numValido != 0) {
                errorProviderTelefono.SetError(txtTelefono, "Telefono debe ser numerico");
            }
            else
            {
                errorProviderNombUsuario.SetError(txtTelefono, "");
            }
        }

        private void TxtCorreo_Validating(object sender, CancelEventArgs e)
        {
            int espaciosBlancos = txtCorreo.Text.Count(caracter => caracter == ' ');

            int numArroba = txtCorreo.Text.Count(caracter => caracter == '@');

            int numCar = txtCorreo.Text.Length;

            if (numCar > 80)
            {
                errorProviderCorreo.SetError(txtCorreo, "Correo debe tener a lo mas 80 caracteres");
            }

            else if (espaciosBlancos != 0 && numArroba != 1)
            {
                errorProviderCorreo.SetError(txtCorreo, "Correo debe poseer una @ y no debe contener Espacios en blanco");
            }
            else if (espaciosBlancos != 0)
            {
                errorProviderCorreo.SetError(txtCorreo, "Correo no debe contener Espacios en blanco");
            }

            else if (numArroba != 1)
            {
                errorProviderCorreo.SetError(txtCorreo, "Correo debe poseer una @");
            }
            else {
                errorProviderCorreo.SetError(txtCorreo, "");
            }
        }

        private void TxtApellidoMaterno_Validating(object sender, CancelEventArgs e)
        {
            if (!txtApellidoPaterno.Text.All(caracter => char.IsLetter(caracter)))
                errorProviderApellidoMaterno.SetError(txtApellidoMaterno, "El apellido paterno debe estar compuesto por letras");
            else
                errorProviderApellidoMaterno.SetError(txtApellidoMaterno, "");
        }

        private void TxtApellidoPaterno_Validated(object sender, EventArgs e)
        {
            if (!txtApellidoPaterno.Text.All(caracter => char.IsLetter(caracter)))
                errorProviderApellidoPaterno.SetError(txtApellidoPaterno, "El apellido paterno debe estar compuesto por letras");
            else
                errorProviderApellidoPaterno.SetError(txtApellidoPaterno, "");
        }

        private void TxtDni_Validating(object sender, CancelEventArgs e)
        {
            bool esNumerico = txtDni.Text.All(caracter => char.IsDigit(caracter));

            bool tamanoAdecuado = txtDni.Text.Length == 8;

            if (!esNumerico && !tamanoAdecuado)
            {
                errorProviderDni.SetError(txtDni, "DNI debe ser numerico y de tamaño 8");
            }
            else if (!esNumerico)
            {
                errorProviderDni.SetError(txtDni, "DNI debe ser numerico");
            }
            else if (!tamanoAdecuado)
            {
                errorProviderDni.SetError(txtDni, "DNI debe ser de tamaño 8");
            }
            else {
                errorProviderDni.SetError(txtDni, "");
            }
        }

        private void TxtNombrePersona_Validating(object sender, CancelEventArgs e)
        {
            string cadenaNombPersona = txtNombrePersona.Text;
            if (!cadenaNombPersona.All(caracter => char.IsLetter(caracter) || char.IsWhiteSpace(caracter)))
                errorProviderNombPersona.SetError(txtNombrePersona, "El nombre debe estar compuesto por letras y espacios en blanco");

            else
                errorProviderNombPersona.SetError(txtNombrePersona, "");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe ingresar DNI");
                return;
            }

            if (!txtDni.Text.All(caracter => char.IsDigit(caracter)))
            {
                MessageBox.Show("DNI debe ser numerico");
                return;
            }

            if (txtDni.Text.Length != 8)
            {
                MessageBox.Show("DNI debe ser de tamaño 8");
                return;
            }

            if (txtNombrePersona.Text == ""){
                MessageBox.Show("Debe ingresar nombre de persona");
                return;
            }

            if (!txtNombrePersona.Text.All(caracter => char.IsLetter(caracter) || char.IsWhiteSpace(caracter))) {
                MessageBox.Show("El nombre debe estar compuesto por letras y espacios en blanco");
                return;
            }

            if (txtApellidoPaterno.Text == "")
            {
                MessageBox.Show("Debe ingresar Apellido paterno");
                return;
            }

            if (!txtApellidoPaterno.Text.All(caracter => char.IsLetter(caracter))) {
                MessageBox.Show("El apellido paterno debe estar compuesto por letras");
                return;
            }

            if (txtApellidoMaterno.Text == "")
            {
                MessageBox.Show("Debe ingresar Apellido materno");
                return;
            }

            if (!txtApellidoMaterno.Text.All(caracter => char.IsLetter(caracter))) {
                MessageBox.Show("El apellido Materno debe estar compuesto por letras");
                return;
            }

            if (txtCorreo.Text == "")
            {
                MessageBox.Show("Debe ingresar Correo");
                return;
            }

            if (txtCorreo.Text.Length > 80)
            {
                MessageBox.Show("Correo debe tener a lo mas 80 caracteres");
                return;
            }

            if (txtCorreo.Text.Count(caracter => caracter == '@') != 1)
            {
                MessageBox.Show("Correo debe poseer una @");
                return;
            }

            if (txtCorreo.Text.Count(caracter => caracter == ' ') != 0)
            {
                MessageBox.Show("Correo no debe contener Espacios en blanco");
                return;
            }

            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Debe ingresar telefono");
                return;
            }

            if (txtTelefono.Text.Length > 10)
            {
                MessageBox.Show("Telefono debe tener a lo mas 10 numeros");
            }

            if (txtTelefono.Text.Count(caracter => !char.IsDigit(caracter)) != 0) {
                MessageBox.Show("Telefono debe ser numerico");
                return;
            }

            if (txtNombUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar nombre de usuario");
                return;
            }

            if (txtNombUsuario.Text.Length < 3 && txtNombUsuario.Text.Length > 8)
            {
                MessageBox.Show("Nombre de usuario debe tener entre 3 y 8 caracteres");
                return;
            }

            if (txtNombUsuario.Text.Count(caracter => !char.IsLetterOrDigit(caracter)) != 0)
            {
                MessageBox.Show("Nombre de usuario debe tener solo numeros y letras");
                return;
            }

            usuario.NomUsuario = txtNombUsuario.Text.Trim().Replace("  ", " ");
            usuario.Bloqueado = false;

            Persona per = new Persona();

            if (cbTipoUsuario.SelectedIndex == 0)
                per = new Operario(TipoCargo.ANALISTA_DESARROLLO, (Dominio)cboDominio.SelectedItem);
            else if (cbTipoUsuario.SelectedIndex == 1)
                per = new KAM((Dominio)cboDominio.SelectedItem);
            else if (cbTipoUsuario.SelectedIndex == 2)
                per = new Experto((Dominio)cboDominio.SelectedItem);
            else if (cbTipoUsuario.SelectedIndex == 3)
                per = new JefeProyecto((Dominio)cboDominio.SelectedItem);
            else if (cbTipoUsuario.SelectedIndex == 4)
                per = new Operario(TipoCargo.TESTER, (Dominio)cboDominio.SelectedItem);
            else if (cbTipoUsuario.SelectedIndex == 5)
                per = new Operario(TipoCargo.PROGRAMADOR, (Dominio)cboDominio.SelectedItem);
            else if (cbTipoUsuario.SelectedIndex == 6)
                per = new Cliente((Empresa)cboEmpresa.SelectedItem);

            per.Dni = txtDni.Text;
            per.Nombre = txtNombrePersona.Text;
            per.ApellidoPaterno = txtApellidoPaterno.Text;
            per.ApellidoMaterno = txtApellidoMaterno.Text;
            per.Correo = txtCorreo.Text;
            per.Telefono = txtTelefono.Text;
            if (cbSexo.SelectedIndex == 0)
                per.Sexo = 'H';
            else
                per.Sexo = 'M';

            per.FechaNac = dtpFechaNacimiento.Value;

            usuario.Persona = per;

            string contrasena = cuentaUsuarioBL.insertarUsuario(usuario);
            
            if (contrasena == "")
            {
                MessageBox.Show("Error al ingresar usuario en base de datos");
                return;
            }
            MessageBox.Show("Usuario registrado exitosamente");

            DialogResult = DialogResult.OK;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cancelar la operacion?", "cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void cbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoUsuario.SelectedIndex == 6)
            {
                cboEmpresa.Enabled = true;
                cboDominio.Enabled = false;
            }
            else
            {
                cboEmpresa.Enabled = false;
                cboDominio.Enabled = true;
            }
        }
    }
}
