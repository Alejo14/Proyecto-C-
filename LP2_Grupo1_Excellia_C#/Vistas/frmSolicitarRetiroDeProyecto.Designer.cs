namespace Vistas
{
    partial class frmSolicitarRetiroDeProyecto
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
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this.btnSolicitarRetiro = new System.Windows.Forms.Button();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblSolicitarRetiro = new System.Windows.Forms.Label();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.AllowUserToAddRows = false;
            this.dgvProyectos.AllowUserToDeleteRows = false;
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvProyectos.Location = new System.Drawing.Point(111, 138);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.ReadOnly = true;
            this.dgvProyectos.Size = new System.Drawing.Size(758, 182);
            this.dgvProyectos.TabIndex = 0;
            // 
            // btnSolicitarRetiro
            // 
            this.btnSolicitarRetiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolicitarRetiro.FlatAppearance.BorderSize = 0;
            this.btnSolicitarRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitarRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitarRetiro.Image = global::Vistas.Properties.Resources.Send;
            this.btnSolicitarRetiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicitarRetiro.Location = new System.Drawing.Point(568, 475);
            this.btnSolicitarRetiro.Name = "btnSolicitarRetiro";
            this.btnSolicitarRetiro.Size = new System.Drawing.Size(116, 49);
            this.btnSolicitarRetiro.TabIndex = 1;
            this.btnSolicitarRetiro.Text = "Enviar";
            this.btnSolicitarRetiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSolicitarRetiro.UseVisualStyleBackColor = true;
            this.btnSolicitarRetiro.Click += new System.EventHandler(this.btnSolicitarRetiro_Click);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(111, 376);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(758, 77);
            this.txtMotivo.TabIndex = 2;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblMotivo.Location = new System.Drawing.Point(108, 346);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(191, 18);
            this.lblMotivo.TabIndex = 4;
            this.lblMotivo.Text = "Especificar motivo del retiro";
            // 
            // lblSolicitarRetiro
            // 
            this.lblSolicitarRetiro.AutoSize = true;
            this.lblSolicitarRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitarRetiro.Location = new System.Drawing.Point(338, 44);
            this.lblSolicitarRetiro.Name = "lblSolicitarRetiro";
            this.lblSolicitarRetiro.Size = new System.Drawing.Size(327, 29);
            this.lblSolicitarRetiro.TabIndex = 5;
            this.lblSolicitarRetiro.Text = "Solicitar retiro de un proyecto";
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIndicacion.Location = new System.Drawing.Point(108, 104);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(311, 18);
            this.lblIndicacion.TabIndex = 6;
            this.lblIndicacion.Text = "Seleccione el proyecto del que desee retirarse";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Vistas.Properties.Resources.No;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(305, 475);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 49);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdProyecto";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nombre";
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Etapa";
            this.Column3.HeaderText = "Etapa";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 165;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FechaInicio";
            this.Column4.HeaderText = "Fecha de inicio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // frmSolicitarRetiroDeProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 577);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.lblSolicitarRetiro);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.btnSolicitarRetiro);
            this.Controls.Add(this.dgvProyectos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSolicitarRetiroDeProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSolicitarRetiroDeProyecto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.Button btnSolicitarRetiro;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblSolicitarRetiro;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

