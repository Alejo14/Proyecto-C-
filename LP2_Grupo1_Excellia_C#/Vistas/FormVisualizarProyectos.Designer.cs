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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVisualizarProyectos = new System.Windows.Forms.DataGridView();
            this.colIdProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEtapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaFinEstimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblProyectosEnCurso = new System.Windows.Forms.Label();
            this.dtpFechaComienzo = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblEtapa = new System.Windows.Forms.Label();
            this.cboEtapa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgvVisualizarProyectos.Location = new System.Drawing.Point(46, 145);
            this.dgvVisualizarProyectos.Name = "dgvVisualizarProyectos";
            this.dgvVisualizarProyectos.ReadOnly = true;
            this.dgvVisualizarProyectos.Size = new System.Drawing.Size(843, 298);
            this.dgvVisualizarProyectos.TabIndex = 0;
            this.dgvVisualizarProyectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisualizarProyectos_CellContentClick);
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
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
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
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(46, 463);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(119, 33);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblProyectosEnCurso
            // 
            this.lblProyectosEnCurso.AutoSize = true;
            this.lblProyectosEnCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyectosEnCurso.Location = new System.Drawing.Point(341, 35);
            this.lblProyectosEnCurso.Name = "lblProyectosEnCurso";
            this.lblProyectosEnCurso.Size = new System.Drawing.Size(281, 31);
            this.lblProyectosEnCurso.TabIndex = 2;
            this.lblProyectosEnCurso.Text = "Visualizar Proyectos";
            this.lblProyectosEnCurso.Click += new System.EventHandler(this.lblProyectosEnCurso_Click);
            // 
            // dtpFechaComienzo
            // 
            this.dtpFechaComienzo.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dtpFechaComienzo.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpFechaComienzo.Location = new System.Drawing.Point(153, 111);
            this.dtpFechaComienzo.Name = "dtpFechaComienzo";
            this.dtpFechaComienzo.Size = new System.Drawing.Size(202, 20);
            this.dtpFechaComienzo.TabIndex = 3;
            this.dtpFechaComienzo.ValueChanged += new System.EventHandler(this.dtpFechaComienzo_ValueChanged);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(42, 111);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(108, 20);
            this.lblFechaInicio.TabIndex = 4;
            this.lblFechaInicio.Text = "Fecha Incio:";
            // 
            // lblEtapa
            // 
            this.lblEtapa.AutoSize = true;
            this.lblEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtapa.Location = new System.Drawing.Point(686, 111);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(62, 20);
            this.lblEtapa.TabIndex = 5;
            this.lblEtapa.Text = "Etapa:";
            // 
            // cboEtapa
            // 
            this.cboEtapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEtapa.FormattingEnabled = true;
            this.cboEtapa.Location = new System.Drawing.Point(768, 110);
            this.cboEtapa.Name = "cboEtapa";
            this.cboEtapa.Size = new System.Drawing.Size(121, 21);
            this.cboEtapa.TabIndex = 6;
            this.cboEtapa.SelectedIndexChanged += new System.EventHandler(this.cboEtapa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 2);
            this.label1.TabIndex = 7;
            // 
            // btnRetirarOperario
            // 
            this.btnRetirarOperario.Location = new System.Drawing.Point(770, 463);
            this.btnRetirarOperario.Name = "btnRetirarOperario";
            this.btnRetirarOperario.Size = new System.Drawing.Size(119, 33);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEtapa);
            this.Controls.Add(this.lblEtapa);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaComienzo);
            this.Controls.Add(this.lblProyectosEnCurso);
            this.Controls.Add(this.btnRegresar);
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
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblProyectosEnCurso;
        private System.Windows.Forms.DateTimePicker dtpFechaComienzo;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblEtapa;
        private System.Windows.Forms.ComboBox cboEtapa;
        private System.Windows.Forms.Label label1;
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