using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using Modelo;

namespace Vistas
{
    public partial class frmGenerarProyecto : Form
    {
        private EruBL eruBL;
        private ERU eru;
        public frmGenerarProyecto()
        {
            InitializeComponent();
            dgvEruProyecto.AutoGenerateColumns = false;
            eruBL = new EruBL();
            dgvEruProyecto.DataSource = eruBL.listarErusPendientes();
        }

        public ERU ERU { get => eru; set => eru = value; }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (dgvEruProyecto.SelectedRows.Count > 0)
            {
                ERU = (ERU)dgvEruProyecto.CurrentRow.DataBoundItem;
                frmAgregarInfProyecto frm = new frmAgregarInfProyecto(ERU);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Se debe de seleccionar una ERU para crearle un proyecto", "Crear proyecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
