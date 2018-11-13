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
    public partial class frmSolicitudesModificacionRequerimientos : Form
    {
        private SolicitudCambio solicitudCambioForm;
        private int idJefeProyecto;
        public frmSolicitudesModificacionRequerimientos(int idJefe)
        {
            InitializeComponent();
            idJefeProyecto = idJefe;
            SolicitudCambioBL solicitudCambioBL = new SolicitudCambioBL();
            dgvSolicitudes.AutoGenerateColumns = false;
            dgvSolicitudes.DataSource = solicitudCambioBL.obtenerSolicitudesCambio(idJefeProyecto);

        }

        private void btnRevisarSolicitud_Click(object sender, EventArgs e)
        {
            solicitudCambioForm = (SolicitudCambio)dgvSolicitudes.CurrentRow.DataBoundItem;
            frmRevisarSolicitudRequerimiento sr = new frmRevisarSolicitudRequerimiento();
            if (sr.ShowDialog() == DialogResult.OK)
            { 
                
            }
        }
    }
}
