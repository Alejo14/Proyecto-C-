using Modelo;
using LogicaNegocio;
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
    public partial class frmCambiarContraseña : Form
    {
        private CuentaUsuario cu;
        private TrabajadorBL trabajadorBL;
        public frmCambiarContraseña(CuentaUsuario cu)
        {
            InitializeComponent();
            this.cu = cu;
            trabajadorBL = new TrabajadorBL();
            txtContra.Validating += TxtContra_Validating;
        }

        private void TxtContra_Validating(object sender, CancelEventArgs e)
        {
            int valoresEspeciales = txtContra.Text.Count(caracter => !char.IsLetterOrDigit(caracter));
            if (valoresEspeciales != 0)
            {
                errorContra.SetError(txtContra, "La contraseña solo debe tener números o letras");
            }
            else
            {
                errorContra.SetError(txtContra, "");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if ((txtContra.Text != "" && txtContraRep.Text == "") || (txtContra.Text == "" && txtContraRep.Text != ""))
            {
                MessageBox.Show("Debe llenar ambos campos o ninguno si quiere continuar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!validarContra())
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cu.Contrasena = txtContra.Text;
            if (trabajadorBL.actualizarPerfil(cu))
            {
                MessageBox.Show("Se han guardado los cambios", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrió un error en la actualización de su perfil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.DialogResult = DialogResult.OK;
        }
        private bool validarContra()
        {
            int valoresEspeciales = txtContra.Text.Count(caracter => !Char.IsLetterOrDigit(caracter));
            bool valido = valoresEspeciales == 0 && txtContra.Text.Equals(txtContra.Text);
            return valido;
        }
    }
    
}
