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
    public partial class frmRetirarOperario : Form
    {
        public frmRetirarOperario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmRetirarOperario_Load(object sender, EventArgs e)
        {
            cboProyecto.Items.Insert(0,"Seleccionar");
            cboProyecto.Items.Add("Almacén maritimo de Tramarsa S.A");
            cboProyecto.SelectedIndex = 0;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha retirado a los operarios seleccionados satisfactoriamente");
        }

        private void cboProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
  
            dgvOperarios.Rows.Add("009805861", "Jose Alberto Miranda Martinez","Programador");
            dgvOperarios.Rows.Add("009975892", "Nestor Junior Cautivo Herrada", "Programador");
            dgvOperarios.Rows.Add("009732480", "Alex Junior Montoya Saavedra", "Analista");
            dgvOperarios.Rows.Add("009480979", "Andrea Del Pilar Paredes Vergara", "Analista");
        }
    }
}
