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
    public partial class frmBuscarTrabajador : Form
    {
        private TrabajadorBL trabajadorBL;
        private RolBL rolBL;
        public frmBuscarTrabajador(int seleccionar)
        {
            InitializeComponent();
            if(seleccionar == 1)
            {
                btnSeleccionar.Visible = true;
            }else if(seleccionar == 0)
            {
                btnSeleccionar.Visible = false;
            }
            rolBL = new RolBL();
            TipoTrabajador todosTiposTrabajador = new TipoTrabajador();
            todosTiposTrabajador.IdTipoTrabajador = 0;
            todosTiposTrabajador.Descripcion = "Todos";
            BindingList<TipoTrabajador> roles = rolBL.listarRoles();
            roles.Insert(0, todosTiposTrabajador);
            cmbRol.DataSource = roles;
            cmbRol.DisplayMember = "Descripcion";
            cmbRol.ValueMember = "IdTipoTrabajador";
            cmbRol.SelectedIndex = 0;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TipoTrabajador rol = new TipoTrabajador();
            trabajadorBL = new TrabajadorBL();
            dgvTrabajadores.AutoGenerateColumns = false;
            try
            {
                rol = (TipoTrabajador)cmbRol.SelectedItem;
            } catch (Exception ex)
            {

            }
            BindingList<Trabajador> t;
            if (rol.IdTipoTrabajador == 0)
            {
                t = trabajadorBL.listarTrabajadores(txtDNI.Text, txtNombre.Text,
                    txtApPat.Text, txtApMat.Text, txtCorreo.Text, txtTelefono.Text, "");
            }
            else
            {
                t = trabajadorBL.listarTrabajadores(txtDNI.Text, txtNombre.Text,
                    txtApPat.Text, txtApMat.Text, txtCorreo.Text, txtTelefono.Text, rol.Descripcion);
            }
            if (t != null)
            {
                dgvTrabajadores.DataSource = t;
            }
            else
            {
               // dgvTrabajadores
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            bool entre = false;
            foreach(DataGridViewRow r in dgvTrabajadores.Rows)
            {
                if (r.Selected && dgvTrabajadores.Rows.Count > 1)
                {
                    entre = true;
                    break;
                }
            }
            if (entre)
            {
                DialogResult result = MessageBox.Show("Seguro que quiere asignar a estos trabajadores al proyecto.", "Advertencia", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Correos enviados correctamente.", "Éxito", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Se enviarán correos a todos los trabajadores buscados." + Environment.NewLine + "¿Seguro de que quiere continuar?"
                    , "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(result == DialogResult.OK)
                {
                    MessageBox.Show("Correos enviados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }                
            }
        }

        private void txtApPat_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
