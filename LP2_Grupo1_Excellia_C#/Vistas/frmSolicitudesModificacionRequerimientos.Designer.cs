namespace Vistas
{
    partial class frmSolicitudesModificacionRequerimientos
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
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.colProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSolicitudesModificacionRequerimientos = new System.Windows.Forms.Label();
            this.btnRevisarSolicitud = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProyecto,
            this.colCli,
            this.colEmpresa,
            this.colFechaSolicitud});
            this.dgvSolicitudes.Location = new System.Drawing.Point(86, 104);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.Size = new System.Drawing.Size(742, 336);
            this.dgvSolicitudes.TabIndex = 0;
            // 
            // colProyecto
            // 
            this.colProyecto.HeaderText = "Nombre Proyecto";
            this.colProyecto.Name = "colProyecto";
            this.colProyecto.Width = 150;
            // 
            // colCli
            // 
            this.colCli.HeaderText = "Cliente";
            this.colCli.Name = "colCli";
            // 
            // colEmpresa
            // 
            this.colEmpresa.HeaderText = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            // 
            // colFechaSolicitud
            // 
            this.colFechaSolicitud.HeaderText = "Fecha de solicitud";
            this.colFechaSolicitud.Name = "colFechaSolicitud";
            this.colFechaSolicitud.Width = 150;
            // 
            // lblSolicitudesModificacionRequerimientos
            // 
            this.lblSolicitudesModificacionRequerimientos.AutoSize = true;
            this.lblSolicitudesModificacionRequerimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitudesModificacionRequerimientos.Location = new System.Drawing.Point(253, 38);
            this.lblSolicitudesModificacionRequerimientos.Name = "lblSolicitudesModificacionRequerimientos";
            this.lblSolicitudesModificacionRequerimientos.Size = new System.Drawing.Size(422, 25);
            this.lblSolicitudesModificacionRequerimientos.TabIndex = 1;
            this.lblSolicitudesModificacionRequerimientos.Text = "Solicitudes Modificación de requerimientos";
            // 
            // btnRevisarSolicitud
            // 
            this.btnRevisarSolicitud.Location = new System.Drawing.Point(721, 75);
            this.btnRevisarSolicitud.Name = "btnRevisarSolicitud";
            this.btnRevisarSolicitud.Size = new System.Drawing.Size(98, 23);
            this.btnRevisarSolicitud.TabIndex = 2;
            this.btnRevisarSolicitud.Text = "Revisar Solicitud";
            this.btnRevisarSolicitud.UseVisualStyleBackColor = true;
            this.btnRevisarSolicitud.Click += new System.EventHandler(this.btnRevisarSolicitud_Click);
            // 
            // frmSolicitudesModificacionRequerimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 484);
            this.Controls.Add(this.btnRevisarSolicitud);
            this.Controls.Add(this.lblSolicitudesModificacionRequerimientos);
            this.Controls.Add(this.dgvSolicitudes);
            this.Name = "frmSolicitudesModificacionRequerimientos";
            this.Text = "frmSolicitudesModificacionRequerimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Label lblSolicitudesModificacionRequerimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaSolicitud;
        private System.Windows.Forms.Button btnRevisarSolicitud;
    }
}