namespace Vistas
{
    partial class FormSolicitudRetiro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSolicitudRetiro = new System.Windows.Forms.Label();
            this.dgvSolicitudRetiro = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEtapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSolicitarRetiro = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMotivoSolicitud = new System.Windows.Forms.Label();
            this.txtMotivoSolicitud = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudRetiro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSolicitudRetiro
            // 
            this.lblSolicitudRetiro.AutoSize = true;
            this.lblSolicitudRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSolicitudRetiro.Location = new System.Drawing.Point(221, 44);
            this.lblSolicitudRetiro.Name = "lblSolicitudRetiro";
            this.lblSolicitudRetiro.Size = new System.Drawing.Size(223, 31);
            this.lblSolicitudRetiro.TabIndex = 0;
            this.lblSolicitudRetiro.Text = "Solicitud de retiro";
            this.lblSolicitudRetiro.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvSolicitudRetiro
            // 
            this.dgvSolicitudRetiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudRetiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colEtapa,
            this.colFechaInicio});
            this.dgvSolicitudRetiro.Location = new System.Drawing.Point(12, 78);
            this.dgvSolicitudRetiro.Name = "dgvSolicitudRetiro";
            this.dgvSolicitudRetiro.Size = new System.Drawing.Size(627, 186);
            this.dgvSolicitudRetiro.TabIndex = 1;
            this.dgvSolicitudRetiro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudRetiro_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 250;
            // 
            // colEtapa
            // 
            this.colEtapa.HeaderText = "Etapa";
            this.colEtapa.Name = "colEtapa";
            this.colEtapa.Width = 150;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.HeaderText = "Fecha Inicio";
            this.colFechaInicio.Name = "colFechaInicio";
            // 
            // btnSolicitarRetiro
            // 
            this.btnSolicitarRetiro.Location = new System.Drawing.Point(175, 381);
            this.btnSolicitarRetiro.Name = "btnSolicitarRetiro";
            this.btnSolicitarRetiro.Size = new System.Drawing.Size(97, 38);
            this.btnSolicitarRetiro.TabIndex = 2;
            this.btnSolicitarRetiro.Text = "Solicitar Retiro";
            this.btnSolicitarRetiro.UseVisualStyleBackColor = true;
            this.btnSolicitarRetiro.Click += new System.EventHandler(this.btnSolicitarRetiro_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(369, 381);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 37);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMotivoSolicitud
            // 
            this.lblMotivoSolicitud.AutoSize = true;
            this.lblMotivoSolicitud.Location = new System.Drawing.Point(12, 284);
            this.lblMotivoSolicitud.Name = "lblMotivoSolicitud";
            this.lblMotivoSolicitud.Size = new System.Drawing.Size(98, 13);
            this.lblMotivoSolicitud.TabIndex = 4;
            this.lblMotivoSolicitud.Text = "Motivo de solicitud:";
            // 
            // txtMotivoSolicitud
            // 
            this.txtMotivoSolicitud.Location = new System.Drawing.Point(109, 284);
            this.txtMotivoSolicitud.Multiline = true;
            this.txtMotivoSolicitud.Name = "txtMotivoSolicitud";
            this.txtMotivoSolicitud.Size = new System.Drawing.Size(449, 91);
            this.txtMotivoSolicitud.TabIndex = 5;
            this.txtMotivoSolicitud.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormSolicitudRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 456);
            this.Controls.Add(this.txtMotivoSolicitud);
            this.Controls.Add(this.lblMotivoSolicitud);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSolicitarRetiro);
            this.Controls.Add(this.dgvSolicitudRetiro);
            this.Controls.Add(this.lblSolicitudRetiro);
            this.Name = "FormSolicitudRetiro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudRetiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSolicitudRetiro;
        private System.Windows.Forms.DataGridView dgvSolicitudRetiro;
        private System.Windows.Forms.Button btnSolicitarRetiro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEtapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaInicio;
        private System.Windows.Forms.Label lblMotivoSolicitud;
        private System.Windows.Forms.TextBox txtMotivoSolicitud;
    }
}

