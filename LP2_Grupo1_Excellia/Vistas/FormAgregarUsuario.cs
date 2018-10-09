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
    public partial class FormAgregarUsuario : Form
    {

        private static int iDNuevo = 1;

        private CuentaUsuario usuario;

        public CuentaUsuario Usuario { get => usuario; set => usuario = value; }

        public FormAgregarUsuario()
        {
            InitializeComponent();

            usuario = new CuentaUsuario();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            usuario.IdCuenta = iDNuevo;
            iDNuevo++;
            usuario.NomUsuario = txtNombUsuario.Text;
            usuario.Contrasena = txtContrasena.Text;
            usuario.Bloqueado = false;

            Persona per;
            if (cbTipoUsuario.SelectedIndex == 1)
                per = new Trabajador();
            else
                per = new Cliente();

            per.Dni = txtDni.Text;
            per.Nombre = txtNombrePersona.Text;
            per.ApellidoPaterno = txtApellidoPaterno.Text;
            per.ApellidoMaterno = txtApellidoMaterno.Text;
            if (cbSexo.SelectedIndex == 0)
                per.Sexo = 'H';
            else
                per.Sexo = 'M';

            per.FechaNac = DateTime.Parse(dtpFechaNacimiento.Text);

            usuario.Persona = per;

            MessageBox.Show("Usuario registrado exitosamente");

            DialogResult = DialogResult.OK;
            
        }
    }
}
