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
    public partial class frmSolicitarRetiroDeProyecto : Form
    {
        public frmSolicitarRetiroDeProyecto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMotivo.Text))
                MessageBox.Show("Debe de ingresar el motivo de la solicitud de retiro");
            else
                MessageBox.Show("Se ha registrado la solicitud de retiro y se ha enviado un correo al Jefe de Proyecto");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSolicitarRetiroDeProyecto_Load(object sender, EventArgs e)
        {
            dgvProyectos.Rows.Add("False", "00689","Almacén maritimo de Tramarsa S.A","Finalizado","22/04/2017");
            dgvProyectos.Rows.Add("False", "00591","Almacén Alicorp", "En curso", "01/10/2018");
            dgvProyectos.Rows.Add("False", "00167", "Proyecto Puerto Salaverry", "Finalizado", "10/10/2017");
            dgvProyectos.Rows.Add("False", "00278","Inclusíón de número electronico de SUNAT en Liquidación de Compra", "Finalizado", "03/05/2018");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
