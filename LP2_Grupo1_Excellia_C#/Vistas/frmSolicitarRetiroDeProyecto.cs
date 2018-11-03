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
    public partial class frmSolicitarRetiroDeProyecto : Form
    {
        private Operario operario;
        private ProyectoBL proyectoBL;
        private Proyecto proyecto;
        public frmSolicitarRetiroDeProyecto(Operario operario)
        {
            InitializeComponent();
            this.operario = operario;
            proyectoBL = new ProyectoBL();
            dgvProyectos.AutoGenerateColumns = false;
            dgvProyectos.DataSource = proyectoBL.listarProyectosOperario(operario.IdTrabajador);           
        }
        private void btnSolicitarRetiro_Click(object sender, EventArgs e)
        {
            //Enviar un correo electronico al jefe para que pueda determinar
            //Actualizar el estado del proyecto para ese trabajador
            if (string.IsNullOrEmpty(txtMotivo.Text))
            {
                MessageBox.Show("Debe de ingresar el motivo de la solicitud de retiro");
            }
            else
            {
                try
                {
                    proyecto = (Proyecto)dgvProyectos.CurrentRow.DataBoundItem;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seleccione el proyecto del que desea retirarse.");
                }
                //proyectoBL.registrarSolicitud(operario, proyecto, txtMotivo.Text);
                MessageBox.Show("Se ha registrado la solicitud de retiro y se ha enviado un correo al Jefe de Proyecto");
            }
        }
    }
}
