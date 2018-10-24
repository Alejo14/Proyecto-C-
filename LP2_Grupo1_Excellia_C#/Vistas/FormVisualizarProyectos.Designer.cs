namespace Vistas
{
    partial class FormVisualizarProyectos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVisualizarProyectos = new System.Windows.Forms.DataGridView();
            this.colIdProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEtapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaFinEstimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProyectosEnCurso = new System.Windows.Forms.Label();
            this.dtpFechaComienzo = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblEtapa = new System.Windows.Forms.Label();
            this.cboEtapa = new System.Windows.Forms.ComboBox();
            this.btnRetirarOperario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisualizarProyectos
            // 
            this.dgvVisualizarProyectos.AllowUserToAddRows = false;
            this.dgvVisualizarProyectos.AllowUserToDeleteRows = false;
            this.dgvVisualizarProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProyecto,
            this.colNombre,
            this.colEtapa,
            this.Column1,
            this.colPrioridad,
            this.colFechaInicio,
            this.colFechaFinEstimada});
            this.dgvVisualizarProyectos.Location = new System.Drawing.Point(46, 168);
            this.dgvVisualizarProyectos.Name = "dgvVisualizarProyectos";
            this.dgvVisualizarProyectos.ReadOnly = true;
            this.dgvVisualizarProyectos.Size = new System.Drawing.Size(843, 266);
            this.dgvVisualizarProyectos.TabIndex = 0;
            this.dgvVisualizarProyectos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVisualizarProyectos_RowHeaderMouseDoubleClick);
            // 
            // colIdProyecto
            // 
            this.colIdProyecto.DataPropertyName = "IdProyecto";
            this.colIdProyecto.HeaderText = "ID";
            this.colIdProyecto.Name = "colIdProyecto";
            this.colIdProyecto.ReadOnly = true;
            this.colIdProyecto.Width = 50;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Nombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 220;
            // 
            // colEtapa
            // 
            this.colEtapa.DataPropertyName = "Etapa";
            this.colEtapa.HeaderText = "Etapa";
            this.colEtapa.Name = "colEtapa";
            this.colEtapa.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Presupuesto";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Presupuesto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // colPrioridad
            // 
            this.colPrioridad.DataPropertyName = "Prioridad";
            this.colPrioridad.HeaderText = "Prioridad";
            this.colPrioridad.Name = "colPrioridad";
            this.colPrioridad.ReadOnly = true;
            this.colPrioridad.Width = 80;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.DataPropertyName = "FechaInicio";
            this.colFechaInicio.HeaderText = "Fecha Inicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.ReadOnly = true;
            this.colFechaInicio.Width = 125;
            // 
            // colFechaFinEstimada
            // 
            this.colFechaFinEstimada.DataPropertyName = "FechaFinEstimada";
            this.colFechaFinEstimada.HeaderText = "Fecha Fin Estimada";
            this.colFechaFinEstimada.Name = "colFechaFinEstimada";
            this.colFechaFinEstimada.ReadOnly = true;
            this.colFechaFinEstimada.Width = 125;
            // 
            // lblProyectosEnCurso
            // 
            this.lblProyectosEnCurso.AutoSize = true;
            this.lblProyectosEnCurso.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyectosEnCurso.Location = new System.Drawing.Point(354, 51);
            this.lblProyectosEnCurso.Name = "lblProyectosEnCurso";
            this.lblProyectosEnCurso.Size = new System.Drawing.Size(260, 32);
            this.lblProyectosEnCurso.TabIndex = 2;
            this.lblProyectosEnCurso.Text = "Visualizar Proyectos";
            // 
            // dtpFechaComienzo
            // 
            this.dtpFechaComienzo.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dtpFechaComienzo.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpFechaComienzo.Location = new System.Drawing.Point(166, 126);
            this.dtpFechaComienzo.Name = "dtpFechaComienzo";
            this.dtpFechaComienzo.Size = new System.Drawing.Size(202, 20);
            this.dtpFechaComienzo.TabIndex = 3;
            this.dtpFechaComienzo.ValueChanged += new System.EventHandler(this.dtpFechaComienzo_ValueChanged);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(42, 123);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(118, 22);
            this.lblFechaInicio.TabIndex = 4;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblEtapa
            // 
            this.lblEtapa.AutoSize = true;
            this.lblEtapa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtapa.Location = new System.Drawing.Point(698, 123);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(64, 22);
            this.lblEtapa.TabIndex = 5;
            this.lblEtapa.Text = "Etapa:";
            // 
            // cboEtapa
            // 
            this.cboEtapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEtapa.FormattingEnabled = true;
            this.cboEtapa.Location = new System.Drawing.Point(768, 125);
            this.cboEtapa.Name = "cboEtapa";
            this.cboEtapa.Size = new System.Drawing.Size(121, 21);
            this.cboEtapa.TabIndex = 6;
            this.cboEtapa.SelectedIndexChanged += new System.EventHandler(this.cboEtapa_SelectedIndexChanged);
            // 
            // btnRetirarOperario
            // 
            this.btnRetirarOperario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirarOperario.Location = new System.Drawing.Point(736, 449);
            this.btnRetirarOperario.Name = "btnRetirarOperario";
            this.btnRetirarOperario.Size = new System.Drawing.Size(153, 38);
            this.btnRetirarOperario.TabIndex = 9;
            this.btnRetirarOperario.Text = "Retirar Operario";
            this.btnRetirarOperario.UseVisualStyleBackColor = true;
            this.btnRetirarOperario.Click += new System.EventHandler(this.btnRetirarOperario_Click);
            // 
            // FormVisualizarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(934, 522);
            this.Controls.Add(this.btnRetirarOperario);
            this.Controls.Add(this.cboEtapa);
            this.Controls.Add(this.lblEtapa);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaComienzo);
            this.Controls.Add(this.lblProyectosEnCurso);
            this.Controls.Add(this.dgvVisualizarProyectos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVisualizarProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVisualizarProyectos";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.FormVisualizarProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarProyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisualizarProyectos;
        private System.Windows.Forms.Label lblProyectosEnCurso;
        private System.Windows.Forms.DateTimePicker dtpFechaComienzo;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblEtapa;
        private System.Windows.Forms.ComboBox cboEtapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEtapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaFinEstimada;
        private System.Windows.Forms.Button btnRetirarOperario;
    }
}