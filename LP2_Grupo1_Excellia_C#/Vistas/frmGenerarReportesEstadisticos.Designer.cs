namespace Vistas
{
    partial class frmGenerarReportesEstadisticos
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
            this.lblTituloGenerarReporte = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFInicial = new System.Windows.Forms.Label();
            this.lblFFinal = new System.Windows.Forms.Label();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dtpFInicial = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtpFFinal = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTituloGenerarReporte
            // 
            this.lblTituloGenerarReporte.AutoSize = true;
            this.lblTituloGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGenerarReporte.Location = new System.Drawing.Point(171, 41);
            this.lblTituloGenerarReporte.Name = "lblTituloGenerarReporte";
            this.lblTituloGenerarReporte.Size = new System.Drawing.Size(248, 20);
            this.lblTituloGenerarReporte.TabIndex = 0;
            this.lblTituloGenerarReporte.Text = "Generar reportes estadísticos";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(98, 90);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(140, 16);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "Seleccionar empresa:";
            this.lblEmpresa.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(98, 123);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(128, 16);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Seleccionar estado:";
            // 
            // lblFInicial
            // 
            this.lblFInicial.AutoSize = true;
            this.lblFInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFInicial.Location = new System.Drawing.Point(98, 158);
            this.lblFInicial.Name = "lblFInicial";
            this.lblFInicial.Size = new System.Drawing.Size(156, 16);
            this.lblFInicial.TabIndex = 3;
            this.lblFInicial.Text = "Seleccionar fecha inicial:";
            // 
            // lblFFinal
            // 
            this.lblFFinal.AutoSize = true;
            this.lblFFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFFinal.Location = new System.Drawing.Point(98, 191);
            this.lblFFinal.Name = "lblFFinal";
            this.lblFFinal.Size = new System.Drawing.Size(146, 16);
            this.lblFFinal.TabIndex = 4;
            this.lblFFinal.Text = "Seleccionar fecha final:";
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(293, 89);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(200, 21);
            this.cboEmpresa.TabIndex = 5;
            // 
            // cboEstado
            // 
            this.cboEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(293, 123);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(200, 21);
            this.cboEstado.TabIndex = 6;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.Location = new System.Drawing.Point(206, 247);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(79, 36);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Location = new System.Drawing.Point(315, 247);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(79, 36);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // dtpFInicial
            // 
            this.dtpFInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFInicial.Location = new System.Drawing.Point(293, 158);
            this.dtpFInicial.Name = "dtpFInicial";
            this.dtpFInicial.Size = new System.Drawing.Size(200, 20);
            this.dtpFInicial.TabIndex = 11;
            this.dtpFInicial.ValueChanged += new System.EventHandler(this.dtpFInicial_ValueChanged);
            // 
            // dtpFFinal
            // 
            this.dtpFFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFFinal.Location = new System.Drawing.Point(293, 191);
            this.dtpFFinal.Name = "dtpFFinal";
            this.dtpFFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFFinal.TabIndex = 12;
            // 
            // frmGenerarReportesEstadisticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 311);
            this.Controls.Add(this.dtpFFinal);
            this.Controls.Add(this.dtpFInicial);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.cboEmpresa);
            this.Controls.Add(this.lblFFinal);
            this.Controls.Add(this.lblFInicial);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblTituloGenerarReporte);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenerarReportesEstadisticos";
            this.Text = "GenerarReportesEstadisticos";
            this.Load += new System.EventHandler(this.frmGenerarReportesEstadisticos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloGenerarReporte;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFInicial;
        private System.Windows.Forms.Label lblFFinal;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DateTimePicker dtpFInicial;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpFFinal;
    }
}