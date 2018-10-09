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
    public partial class frmInformacionProyecto : Form
    {
        public frmInformacionProyecto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se han realizado los cambios satisfactoriamente");
            cboEtapa.Enabled = false;
            cboPrioridad.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            txtFReal.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cboEtapa_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            cboEtapa.Items.Insert(0,"Seleccionar");
            cboEtapa.Items.Add("Análisis");
            cboEtapa.Items.Add("Desarrollo");
            cboEtapa.Items.Add("Pruebas");
            cboEtapa.Items.Add("Preparación");
            cboEtapa.Items.Add("Post-producción");
            cboEtapa.Items.Add("Completado");
            cboEtapa.SelectedIndex = 0;*/
        }

        private void frmInformacionProyecto_Load(object sender, EventArgs e)
        {
            txtId.Text ="009978";
            txtNombre.Text = "Almacén Alicorp";
            txtPresupuesto.Text = "6000.00";
            txtFInicial.Text = "27/08/2018";
            txtFEstimada.Text = "29/10/2018";

            cboEtapa.Items.Insert(0, "Seleccionar");
            cboEtapa.Items.Add("Análisis");
            cboEtapa.Items.Add("Desarrollo");
            cboEtapa.Items.Add("Pruebas");
            cboEtapa.Items.Add("Preparación");
            cboEtapa.Items.Add("Post-producción");
            cboEtapa.Items.Add("Completado");
            cboEtapa.SelectedIndex = 0;

            cboPrioridad.Items.Insert(0, "Seleccionar");
            cboPrioridad.Items.Add("1 - Alta");
            cboPrioridad.Items.Add("2 - Media");
            cboPrioridad.Items.Add("3 - Baja");
            cboPrioridad.SelectedIndex = 0;
        }

        private void btnCancelarProyecto_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro de realizar la cancelación del proyecto?","Cancelar proyecto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Se ha realizado la cancelación del proyecto");
            }

         
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cboEtapa.Enabled = true;
            cboPrioridad.Enabled = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            txtFReal.Enabled = true;
        }
    }
}
