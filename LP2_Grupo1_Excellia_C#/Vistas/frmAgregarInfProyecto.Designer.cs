namespace Vistas
{
    partial class frmAgregarInfProyecto
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
            this.lblAgregarInformación = new System.Windows.Forms.Label();
            this.cboPrioridad = new System.Windows.Forms.ComboBox();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblFEstimada = new System.Windows.Forms.Label();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecInicio = new System.Windows.Forms.Label();
            this.lblFFReal = new System.Windows.Forms.Label();
            this.dtpFInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFFEstimada = new System.Windows.Forms.DateTimePicker();
            this.dtpFFReal = new System.Windows.Forms.DateTimePicker();
            this.btnCrearProyecto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAgregarInformación
            // 
            this.lblAgregarInformación.AutoSize = true;
            this.lblAgregarInformación.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarInformación.Location = new System.Drawing.Point(150, 35);
            this.lblAgregarInformación.Name = "lblAgregarInformación";
            this.lblAgregarInformación.Size = new System.Drawing.Size(361, 25);
            this.lblAgregarInformación.TabIndex = 0;
            this.lblAgregarInformación.Text = "Agregar información del proyecto";
            // 
            // cboPrioridad
            // 
            this.cboPrioridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrioridad.FormattingEnabled = true;
            this.cboPrioridad.Location = new System.Drawing.Point(242, 178);
            this.cboPrioridad.Name = "cboPrioridad";
            this.cboPrioridad.Size = new System.Drawing.Size(348, 21);
            this.cboPrioridad.TabIndex = 27;
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.Location = new System.Drawing.Point(242, 137);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(348, 20);
            this.txtPresupuesto.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(242, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(348, 20);
            this.txtNombre.TabIndex = 23;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.Location = new System.Drawing.Point(68, 178);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(76, 16);
            this.lblPrioridad.TabIndex = 34;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // lblFEstimada
            // 
            this.lblFEstimada.AutoSize = true;
            this.lblFEstimada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFEstimada.Location = new System.Drawing.Point(68, 261);
            this.lblFEstimada.Name = "lblFEstimada";
            this.lblFEstimada.Size = new System.Drawing.Size(156, 16);
            this.lblFEstimada.TabIndex = 33;
            this.lblFEstimada.Text = "Fecha final estimada:";
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.Location = new System.Drawing.Point(68, 141);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(136, 16);
            this.lblPresupuesto.TabIndex = 31;
            this.lblPresupuesto.Text = "Presupuesto (S/.) :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(68, 102);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(159, 16);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre del Proyecto:";
            // 
            // lblFecInicio
            // 
            this.lblFecInicio.AutoSize = true;
            this.lblFecInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecInicio.Location = new System.Drawing.Point(68, 222);
            this.lblFecInicio.Name = "lblFecInicio";
            this.lblFecInicio.Size = new System.Drawing.Size(100, 16);
            this.lblFecInicio.TabIndex = 35;
            this.lblFecInicio.Text = "Fecha Inicial:";
            // 
            // lblFFReal
            // 
            this.lblFFReal.AutoSize = true;
            this.lblFFReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFFReal.Location = new System.Drawing.Point(68, 301);
            this.lblFFReal.Name = "lblFFReal";
            this.lblFFReal.Size = new System.Drawing.Size(119, 16);
            this.lblFFReal.TabIndex = 37;
            this.lblFFReal.Text = "Fecha final real:";
            // 
            // dtpFInicio
            // 
            this.dtpFInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFInicio.Location = new System.Drawing.Point(242, 218);
            this.dtpFInicio.Name = "dtpFInicio";
            this.dtpFInicio.Size = new System.Drawing.Size(348, 20);
            this.dtpFInicio.TabIndex = 38;
            this.dtpFInicio.ValueChanged += new System.EventHandler(this.dtpFInicio_ValueChanged);
            // 
            // dtpFFEstimada
            // 
            this.dtpFFEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFFEstimada.Location = new System.Drawing.Point(242, 261);
            this.dtpFFEstimada.Name = "dtpFFEstimada";
            this.dtpFFEstimada.Size = new System.Drawing.Size(348, 20);
            this.dtpFFEstimada.TabIndex = 39;
            this.dtpFFEstimada.ValueChanged += new System.EventHandler(this.dtpFFEstimada_ValueChanged);
            // 
            // dtpFFReal
            // 
            this.dtpFFReal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFFReal.Location = new System.Drawing.Point(242, 301);
            this.dtpFFReal.Name = "dtpFFReal";
            this.dtpFFReal.Size = new System.Drawing.Size(348, 20);
            this.dtpFFReal.TabIndex = 40;
            // 
            // btnCrearProyecto
            // 
            this.btnCrearProyecto.Location = new System.Drawing.Point(274, 348);
            this.btnCrearProyecto.Name = "btnCrearProyecto";
            this.btnCrearProyecto.Size = new System.Drawing.Size(113, 23);
            this.btnCrearProyecto.TabIndex = 41;
            this.btnCrearProyecto.Text = "Crear Proyecto";
            this.btnCrearProyecto.UseVisualStyleBackColor = true;
            this.btnCrearProyecto.Click += new System.EventHandler(this.btnCrearProyecto_Click);
            // 
            // frmAgregarInfProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.btnCrearProyecto);
            this.Controls.Add(this.dtpFFReal);
            this.Controls.Add(this.dtpFFEstimada);
            this.Controls.Add(this.dtpFInicio);
            this.Controls.Add(this.lblFFReal);
            this.Controls.Add(this.lblFecInicio);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.lblFEstimada);
            this.Controls.Add(this.lblPresupuesto);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cboPrioridad);
            this.Controls.Add(this.txtPresupuesto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblAgregarInformación);
            this.Name = "frmAgregarInfProyecto";
            this.Text = "frmAgregarInfProyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarInformación;
        private System.Windows.Forms.ComboBox cboPrioridad;
        private System.Windows.Forms.TextBox txtPresupuesto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblFEstimada;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecInicio;
        private System.Windows.Forms.Label lblFFReal;
        private System.Windows.Forms.DateTimePicker dtpFInicio;
        private System.Windows.Forms.DateTimePicker dtpFFEstimada;
        private System.Windows.Forms.DateTimePicker dtpFFReal;
        private System.Windows.Forms.Button btnCrearProyecto;
    }
}