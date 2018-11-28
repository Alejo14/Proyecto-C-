namespace Vistas
{
    partial class frmDetalleReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvReporteProyectos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Reporte_JefeProyecto1 = new Vistas.Reporte_JefeProyecto();
            this.SuspendLayout();
            // 
            // crvReporteProyectos
            // 
            this.crvReporteProyectos.ActiveViewIndex = 0;
            this.crvReporteProyectos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporteProyectos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporteProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporteProyectos.Location = new System.Drawing.Point(0, 0);
            this.crvReporteProyectos.Name = "crvReporteProyectos";
            this.crvReporteProyectos.ReportSource = this.Reporte_JefeProyecto1;
            this.crvReporteProyectos.Size = new System.Drawing.Size(800, 450);
            this.crvReporteProyectos.TabIndex = 0;
            // 
            // frmDetalleReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvReporteProyectos);
            this.Name = "frmDetalleReporte";
            this.Text = "Detalle de reporte";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporteProyectos;
        private Reporte_JefeProyecto Reporte_JefeProyecto1;
    }
}