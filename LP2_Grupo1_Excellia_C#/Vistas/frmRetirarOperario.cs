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
    public partial class frmRetirarOperario : Form
    {
        private ProyectoBL proyectoBL;
        private TrabajadorBL trabajadorBL;
        public frmRetirarOperario()
        {
            InitializeComponent();
            proyectoBL = new ProyectoBL();
            cboProyecto.DataSource = proyectoBL.listarProyectos();
            cboProyecto.DisplayMember = "Nombre";
            cboProyecto.ValueMember = "IdProyecto";
            trabajadorBL = new TrabajadorBL();
            dgvOperarios.AutoGenerateColumns = false;

            dgvOperarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public Trabajador Trabajador { get => Trabajador; set => Trabajador = value; }
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de realizar el retiro del usuario del proyecto?", "Retirar Operarios", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                proyectoBL.retirarOperario((Proyecto)cboProyecto.SelectedItem, (Trabajador)dgvOperarios.CurrentRow.DataBoundItem);
                dgvOperarios.DataSource = trabajadorBL.listarOperarios((Proyecto)cboProyecto.SelectedItem);
                MessageBox.Show("Se ha realizado el retiro de los operarios del proyecto");
            }
        }

        private void cboProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            dgvOperarios.DataSource = trabajadorBL.listarOperarios((Proyecto)cboProyecto.SelectedItem);

        }

        private void frmRetirarOperario_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
