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
    public partial class FormInfUsuario : Form
    {
        private CuentaUsuario usuario;

        public CuentaUsuario Usuario { get => usuario; set => usuario = value; }

        public FormInfUsuario()
        {
            InitializeComponent();
            txtNombUsuario.Text = usuario.NomUsuario;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            MessageBox.Show("Usuario Eliminado con exito");
        }
    }
}
