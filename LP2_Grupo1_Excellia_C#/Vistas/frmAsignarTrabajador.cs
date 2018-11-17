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
    public partial class frmAsignarTrabajador : Form
    {
        private TrabajadorBL trabajadorBL;
        private ProyectoBL proyectoBL;
        private Proyecto proyecto;
        private Proyecto Proyecto { get => proyecto; set => proyecto = value; }
        public frmAsignarTrabajador(Proyecto p)
        {
            InitializeComponent();
            proyectoBL = new ProyectoBL();
            trabajadorBL = new TrabajadorBL();
            Proyecto = new Proyecto();
            Proyecto = (Proyecto)p;
            txtDNI.Validating += TxtDNI_Validating;
            txtNombre.Validating += TxtNombre_Validating;
        }

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            string nombre = txtNombre.Text.Trim().Replace("  ", " ");
            bool solo_letras = nombre.All(caracter => char.IsLetter(caracter) || char.IsWhiteSpace(caracter));
            bool tamanoCorrecto = (nombre.Length >= 2 || nombre.Length == 0);
            if (!solo_letras)
                errorProviderNombre.SetError(txtNombre, "El nombre debe tener solo letras y espacios en blanco");
            else
                errorProviderNombre.SetError(txtNombre, "");
            if (!tamanoCorrecto)
                errorProviderNombre.SetError(txtNombre, "El nombre debe ser mayor a dos caracteres");
            else
                errorProviderNombre.SetError(txtNombre, "");
        }

        private void TxtDNI_Validating(object sender, CancelEventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            bool esNumerico = dni.All(digito => char.IsDigit(digito));
            bool tamanoCorrecto = (dni.Length == 8 || dni.Length == 0);
            if (!esNumerico)
                errorProviderDNI.SetError(txtDNI, "El DNI debe ser numérico");
            else
                errorProviderDNI.SetError(txtDNI, "");
            if (!tamanoCorrecto)
                errorProviderDNI.SetError(txtDNI, "El DNI debe ser de temaño 8");
            else
                errorProviderDNI.SetError(txtDNI, "");
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            bool entre = false;
            if (dgvTrabajador.Rows.Count >= 1)
            {
                if (MessageBox.Show("¿Seguro que quiere asignar a estos trabajadores al proyecto.?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    entre = true;
                    proyectoBL.AsignarTrabajador((Proyecto)Proyecto, (Trabajador)dgvTrabajador.CurrentRow.DataBoundItem);
                    MessageBox.Show("Correos enviados correctamente.", "Asignación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    entre = true;
                }
            }
            if (!entre)
            {
                MessageBox.Show("Ningún trabajador seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnForm_Buscar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text != "" && !validarDNI()) return;
            if (txtNombre.Text != "" && !validarNombre()) return;
            trabajadorBL = new TrabajadorBL();
            dgvTrabajador.AutoGenerateColumns = false;
            Operario op = new Operario();
            op.Dni = txtDNI.Text.Trim();
            op.Nombre = txtNombre.Text.Trim().Replace("  ", " ");
            op.ApellidoMaterno = op.ApellidoPaterno = op.Correo = op.Telefono = "";
            dgvTrabajador.DataSource = trabajadorBL.listarTrabajadores(op,"");
        }

        private void btnAvanzada_Click(object sender, EventArgs e)
        {
            frmBuscarTrabajador bt = new frmBuscarTrabajador(1);
            if(bt.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private bool validarDNI() {
            string dni = txtDNI.Text.Trim();
            bool esNumerico = dni.All(digito => char.IsDigit(digito));
            bool tamanoCorrecto = (dni.Length == 8);
            bool valido = esNumerico && tamanoCorrecto;
            if (!valido)
            {
                if (!esNumerico && !tamanoCorrecto)
                {
                    MessageBox.Show("El DNI debe ser numérico y de temaño 8");
                }
                else if (!esNumerico)
                    MessageBox.Show("El DNI debe ser numérico");
                else if (!tamanoCorrecto)
                    MessageBox.Show("El DNI debe ser de temaño 8");
            }
            return valido;
        }

        private bool validarNombre() {
            string nombre = txtNombre.Text.Trim().Replace("  ", " ");
            bool valido = nombre.All(caracter => char.IsLetter(caracter) || char.IsWhiteSpace(caracter));
            if (!valido)
                MessageBox.Show("El nombre debe tener solo letras y espacios en blanco");
            return valido;
        }
    }
}
