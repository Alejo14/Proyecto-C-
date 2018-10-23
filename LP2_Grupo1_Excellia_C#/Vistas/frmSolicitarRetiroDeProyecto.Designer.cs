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
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSolicitarRetiro = new System.Windows.Forms.Button();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblSolicitarRetiro = new System.Windows.Forms.Label();
            this.lblIndicacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvProyectos.Location = new System.Drawing.Point(83, 101);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.Size = new System.Drawing.Size(758, 162);
            this.dgvProyectos.TabIndex = 0;
            this.dgvProyectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Seleccionar";
            this.Column5.Name = "Column5";
            this.Column5.Width = 75;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Etapa";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha de inicio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // btnSolicitarRetiro
            // 
            this.btnSolicitarRetiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolicitarRetiro.Location = new System.Drawing.Point(351, 439);
            this.btnSolicitarRetiro.Name = "btnSolicitarRetiro";
            this.btnSolicitarRetiro.Size = new System.Drawing.Size(116, 32);
            this.btnSolicitarRetiro.TabIndex = 1;
            this.btnSolicitarRetiro.Text = "Solicitar retiro";
            this.btnSolicitarRetiro.UseVisualStyleBackColor = true;
            this.btnSolicitarRetiro.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(83, 324);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(758, 63);
            this.txtMotivo.TabIndex = 2;
            // 
            // btnAtras
            // 
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Location = new System.Drawing.Point(538, 439);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(116, 32);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Regresar";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(80, 295);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(176, 16);
            this.lblMotivo.TabIndex = 4;
            this.lblMotivo.Text = "Especificar motivo del retiro:";
            // 
            // lblSolicitarRetiro
            // 
            this.lblSolicitarRetiro.AutoSize = true;
            this.lblSolicitarRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitarRetiro.Location = new System.Drawing.Point(313, 25);
            this.lblSolicitarRetiro.Name = "lblSolicitarRetiro";
            this.lblSolicitarRetiro.Size = new System.Drawing.Size(285, 24);
            this.lblSolicitarRetiro.TabIndex = 5;
            this.lblSolicitarRetiro.Text = "Solicitar retiro de un proyecto";
            this.lblSolicitarRetiro.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Location = new System.Drawing.Point(80, 73);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(225, 13);
            this.lblIndicacion.TabIndex = 6;
            this.lblIndicacion.Text = "Seleccione el proyecto del que desee retirarse";
            // 
            // frmSolicitarRetiroDeProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 522);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.lblSolicitarRetiro);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.btnSolicitarRetiro);
            this.Controls.Add(this.dgvProyectos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSolicitarRetiroDeProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSolicitarRetiroDeProyecto";
            this.Load += new System.EventHandler(this.frmSolicitarRetiroDeProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.Button btnSolicitarRetiro;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblSolicitarRetiro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblIndicacion;
    }
}

