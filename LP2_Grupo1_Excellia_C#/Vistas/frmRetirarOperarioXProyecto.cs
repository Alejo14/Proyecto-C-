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
    public partial class frmRetirarOperarioXProyecto : Form
    {
        private ProyectoBL proyectoBL;
        private TrabajadorBL trabajadorBL;
        private Proyecto proyecto;
        private Proyecto Proyecto { get => proyecto; set => proyecto = value; }
        public frmRetirarOperarioXProyecto(Proyecto p)
        {
            InitializeComponent();
            trabajadorBL = new TrabajadorBL();
            proyectoBL = new ProyectoBL();
            dgvOperarios.AutoGenerateColumns = false;
            dgvOperarios.DataSource = trabajadorBL.listarOperarios(p);
            Proyecto = new Proyecto();
            Proyecto = (Proyecto)p;
            
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de realizar el retiro del usuario del proyecto?", "Retirar Operarios", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                proyectoBL.retirarOperario((Proyecto)Proyecto, (Trabajador)dgvOperarios.CurrentRow.DataBoundItem);
                dgvOperarios.DataSource = trabajadorBL.listarOperarios(Proyecto);
                MessageBox.Show("Se ha realizado el retiro de los operarios del proyecto");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
