using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.Shared;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Vistas
{
    public partial class frmDetalleReporte : Form
    {
        public frmDetalleReporte(ParameterFields parametrosReporte)
        {
            InitializeComponent();
            ReportDocument dir = new ReportDocument();
            dir.Load(Application.StartupPath + "\\Reporte_JefeProyecto.rpt");
            crvReporteProyectos.ReportSource = dir;
            crvReporteProyectos.ParameterFieldInfo = parametrosReporte;
        }
    }
}
