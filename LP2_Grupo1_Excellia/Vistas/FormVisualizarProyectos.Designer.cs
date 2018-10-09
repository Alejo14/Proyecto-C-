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
            this.dgvVisualizarProyectos = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblProyectosEnCurso = new System.Windows.Forms.Label();
            this.colIdProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEtapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaFinEstimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFechaComienzo = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblEtapa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisualizarProyectos
            // 
            this.dgvVisualizarProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProyecto,
            this.colNombre,
            this.colEtapa,
            this.colPrioridad,
            this.colFechaInicio,
            this.colFechaFinEstimada});
            this.dgvVisualizarProyectos.Location = new System.Drawing.Point(52, 182);
            this.dgvVisualizarProyectos.Name = "dgvVisualizarProyectos";
            this.dgvVisualizarProyectos.Size = new System.Drawing.Size(1144, 360);
            this.dgvVisualizarProyectos.TabIndex = 0;
            this.dgvVisualizarProyectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisualizarProyectos_CellContentClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(566, 578);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(139, 44);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblProyectosEnCurso
            // 
            this.lblProyectosEnCurso.AutoSize = true;
            this.lblProyectosEnCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblProyectosEnCurso.Location = new System.Drawing.Point(529, 29);
            this.lblProyectosEnCurso.Name = "lblProyectosEnCurso";
            this.lblProyectosEnCurso.Size = new System.Drawing.Size(253, 31);
            this.lblProyectosEnCurso.TabIndex = 2;
            this.lblProyectosEnCurso.Text = "Proyectos en Curso";
            // 
            // colIdProyecto
            // 
            this.colIdProyecto.HeaderText = "ID";
            this.colIdProyecto.Name = "colIdProyecto";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 400;
            // 
            // colEtapa
            // 
            this.colEtapa.HeaderText = "Etapa";
            this.colEtapa.Name = "colEtapa";
            this.colEtapa.Width = 200;
            // 
            // colPrioridad
            // 
            this.colPrioridad.HeaderText = "Prioridad";
            this.colPrioridad.Name = "colPrioridad";
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.HeaderText = "Fecha Inicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.Width = 150;
            // 
            // colFechaFinEstimada
            // 
            this.colFechaFinEstimada.HeaderText = "Fecha Fin Estimada";
            this.colFechaFinEstimada.Name = "colFechaFinEstimada";
            this.colFechaFinEstimada.Width = 150;
            // 
            // dtpFechaComienzo
            // 
            this.dtpFechaComienzo.Location = new System.Drawing.Point(193, 125);
            this.dtpFechaComienzo.Name = "dtpFechaComienzo";
            this.dtpFechaComienzo.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaComienzo.TabIndex = 3;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(75, 125);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(66, 13);
            this.lblFechaInicio.TabIndex = 4;
            this.lblFechaInicio.Text = "Fecha Incio:";
            // 
            // lblEtapa
            // 
            this.lblEtapa.AutoSize = true;
            this.lblEtapa.Location = new System.Drawing.Point(830, 132);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(35, 13);
            this.lblEtapa.TabIndex = 5;
            this.lblEtapa.Text = "Etapa";
            // 
            // FormVisualizarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 640);
            this.Controls.Add(this.lblEtapa);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaComienzo);
            this.Controls.Add(this.lblProyectosEnCurso);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgvVisualizarProyectos);
            this.Name = "FormVisualizarProyectos";
            this.Text = "FormVisualizarProyectos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarProyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisualizarProyectos;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblProyectosEnCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEtapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaFinEstimada;
        private System.Windows.Forms.DateTimePicker dtpFechaComienzo;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblEtapa;
    }
}