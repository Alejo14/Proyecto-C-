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
        private int seleccionar;
        private Proyecto p;
        public frmBuscarTrabajador(int seleccionar, Proyecto p)
        {
            InitializeComponent();
            if (seleccionar == 1)//Jefe de Proyecto
            {
                btnRegresar.Visible = true;
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                btnSeleccionar.Visible = true;
                this.BackColor = Color.White;
                this.pnlTitulo.BackColor = Color.DarkOrange;
                this.lblTitulo.BackColor = Color.DarkOrange;
                this.p = p;
            }
            else if (seleccionar == 0)//Operario
            {
                this.pnlTitulo.Visible = false;
                btnRegresar.Visible = false;
                btnSeleccionar.Visible = false;
            }
            this.seleccionar = seleccionar;
            rolBL = new RolBL();
            TipoTrabajador todosTiposTrabajador = new TipoTrabajador();
            todosTiposTrabajador.IdTipoTrabajador = 0;
            todosTiposTrabajador.Descripcion = "Todos";
            BindingList<TipoTrabajador> roles = new BindingList<TipoTrabajador>();
            if (seleccionar == 0) roles = rolBL.listarRoles(0);
            else if (seleccionar == 1) roles = rolBL.listarRoles(1);
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
            } catch
            {

            }
            BindingList<Trabajador> t;
            Operario op = new Operario();
            op.Dni = txtDNI.Text;
            op.Nombre = txtNombre.Text;
            op.ApellidoPaterno = txtApPat.Text;
            op.ApellidoMaterno = txtApMat.Text;
            op.Correo = txtCorreo.Text;
            op.Telefono = txtTelefono.Text;
            if (seleccionar == 0)
            {
                if (rol.IdTipoTrabajador == 0)
                    t = trabajadorBL.listarTrabajadores(op, "");
                else
                    t = trabajadorBL.listarTrabajadores(op, rol.Descripcion);
                if (t.Count == 0)
                    MessageBox.Show("No se encontró resultados que desea.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvTrabajadores.DataSource = t;
            }
            else if(seleccionar == 1)
            {
                if (rol.IdTipoTrabajador == 0)
                    t = trabajadorBL.listarTrabajadoresDisponibles(p,op, "");
                else
                    t = trabajadorBL.listarTrabajadoresDisponibles(p,op, rol.Descripcion);
                if (t.Count == 0)
                    MessageBox.Show("No se encontró resultados que desea.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvTrabajadores.DataSource = t;  
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
