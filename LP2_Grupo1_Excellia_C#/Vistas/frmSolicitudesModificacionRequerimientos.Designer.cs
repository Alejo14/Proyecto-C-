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
            this.lblSolicitudesModificacionRequerimientos = new System.Windows.Forms.Label();
            this.btnRevisarSolicitud = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProyecto,
            this.colCli,
            this.colEmpresa,
            this.colFechaSolicitud});
            this.dgvSolicitudes.Location = new System.Drawing.Point(121, 171);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.Size = new System.Drawing.Size(733, 280);
            this.dgvSolicitudes.TabIndex = 0;
            // 
            // lblSolicitudesModificacionRequerimientos
            // 
            this.lblSolicitudesModificacionRequerimientos.AutoSize = true;
            this.lblSolicitudesModificacionRequerimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitudesModificacionRequerimientos.Location = new System.Drawing.Point(278, 71);
            this.lblSolicitudesModificacionRequerimientos.Name = "lblSolicitudesModificacionRequerimientos";
            this.lblSolicitudesModificacionRequerimientos.Size = new System.Drawing.Size(422, 25);
            this.lblSolicitudesModificacionRequerimientos.TabIndex = 1;
            this.lblSolicitudesModificacionRequerimientos.Text = "Solicitudes Modificación de requerimientos";
            // 
            // btnRevisarSolicitud
            // 
            this.btnRevisarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevisarSolicitud.Location = new System.Drawing.Point(725, 467);
            this.btnRevisarSolicitud.Name = "btnRevisarSolicitud";
            this.btnRevisarSolicitud.Size = new System.Drawing.Size(129, 34);
            this.btnRevisarSolicitud.TabIndex = 2;
            this.btnRevisarSolicitud.Text = "Revisar Solicitud";
            this.btnRevisarSolicitud.UseVisualStyleBackColor = true;
            this.btnRevisarSolicitud.Click += new System.EventHandler(this.btnRevisarSolicitud_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione una solicitud para proceder a la revisión";
            // 
            // colProyecto
            // 
            this.colProyecto.DataPropertyName = "NombreProyecto";
            this.colProyecto.HeaderText = "Nombre Proyecto";
            this.colProyecto.Name = "colProyecto";
            this.colProyecto.ReadOnly = true;
            this.colProyecto.Width = 190;
            // 
            // colCli
            // 
            this.colCli.DataPropertyName = "NombreCliente";
            this.colCli.HeaderText = "Cliente";
            this.colCli.Name = "colCli";
            this.colCli.ReadOnly = true;
            this.colCli.Width = 200;
            // 
            // colEmpresa
            // 
            this.colEmpresa.DataPropertyName = "NombreEmpresa";
            this.colEmpresa.HeaderText = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.ReadOnly = true;
            this.colEmpresa.Width = 150;
            // 
            // colFechaSolicitud
            // 
            this.colFechaSolicitud.DataPropertyName = "FechaSolicitud";
            this.colFechaSolicitud.HeaderText = "Fecha de solicitud";
            this.colFechaSolicitud.Name = "colFechaSolicitud";
            this.colFechaSolicitud.ReadOnly = true;
            this.colFechaSolicitud.Width = 150;
            // 
            // frmSolicitudesModificacionRequerimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRevisarSolicitud);
            this.Controls.Add(this.lblSolicitudesModificacionRequerimientos);
            this.Controls.Add(this.dgvSolicitudes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSolicitudesModificacionRequerimientos";
            this.Text = "frmSolicitudesModificacionRequerimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Label lblSolicitudesModificacionRequerimientos;
        private System.Windows.Forms.Button btnRevisarSolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaSolicitud;
    }
}