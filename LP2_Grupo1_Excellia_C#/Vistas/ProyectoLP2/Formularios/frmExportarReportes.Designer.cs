namespace Formularios
{
    partial class frmExportarReportes
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
            this.lblTituloExportar = new System.Windows.Forms.Label();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.gdvBuscarReporte = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblFEstimada = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFInicial = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.dtpFInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFEstimada = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblIndicacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBuscarReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloExportar
            // 
            this.lblTituloExportar.AutoSize = true;
            this.lblTituloExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloExportar.Location = new System.Drawing.Point(187, 17);
            this.lblTituloExportar.Name = "lblTituloExportar";
            this.lblTituloExportar.Size = new System.Drawing.Size(179, 24);
            this.lblTituloExportar.TabIndex = 0;
            this.lblTituloExportar.Text = "Exportar Reportes";
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(120, 92);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cboEmpresa.TabIndex = 1;
            this.cboEmpresa.SelectedIndexChanged += new System.EventHandler(this.cboEmpresa_SelectedIndexChanged);
            // 
            // cboEstado
            // 
            this.cboEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(405, 92);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 2;
            // 
            // btnExportar
            // 
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Location = new System.Drawing.Point(243, 316);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // gdvBuscarReporte
            // 
            this.gdvBuscarReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvBuscarReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gdvBuscarReporte.Location = new System.Drawing.Point(35, 182);
            this.gdvBuscarReporte.Name = "gdvBuscarReporte";
            this.gdvBuscarReporte.Size = new System.Drawing.Size(491, 116);
            this.gdvBuscarReporte.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre del Proyecto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Estado";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Presupuesto";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Empresa cliente";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Location = new System.Drawing.Point(344, 316);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // lblFEstimada
            // 
            this.lblFEstimada.AutoSize = true;
            this.lblFEstimada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFEstimada.Location = new System.Drawing.Point(264, 131);
            this.lblFEstimada.Name = "lblFEstimada";
            this.lblFEstimada.Size = new System.Drawing.Size(135, 16);
            this.lblFEstimada.TabIndex = 8;
            this.lblFEstimada.Text = "Fecha final estimada:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(264, 94);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 16);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:";
            // 
            // lblFInicial
            // 
            this.lblFInicial.AutoSize = true;
            this.lblFInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFInicial.Location = new System.Drawing.Point(31, 131);
            this.lblFInicial.Name = "lblFInicial";
            this.lblFInicial.Size = new System.Drawing.Size(86, 16);
            this.lblFInicial.TabIndex = 10;
            this.lblFInicial.Text = "Fecha inicial:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(31, 95);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(66, 16);
            this.lblEmpresa.TabIndex = 11;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // dtpFInicial
            // 
            this.dtpFInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFInicial.Location = new System.Drawing.Point(120, 130);
            this.dtpFInicial.Name = "dtpFInicial";
            this.dtpFInicial.Size = new System.Drawing.Size(121, 20);
            this.dtpFInicial.TabIndex = 12;
            this.dtpFInicial.ValueChanged += new System.EventHandler(this.dtpFInicial_ValueChanged);
            // 
            // dtpFEstimada
            // 
            this.dtpFEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFEstimada.Location = new System.Drawing.Point(405, 130);
            this.dtpFEstimada.Name = "dtpFEstimada";
            this.dtpFEstimada.Size = new System.Drawing.Size(121, 20);
            this.dtpFEstimada.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(140, 316);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Location = new System.Drawing.Point(31, 64);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(272, 13);
            this.lblIndicacion.TabIndex = 15;
            this.lblIndicacion.Text = "Seleccione uno o más criterios para realizar la búsqueda";
            // 
            // frmExportarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 358);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFEstimada);
            this.Controls.Add(this.dtpFInicial);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblFInicial);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFEstimada);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gdvBuscarReporte);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.cboEmpresa);
            this.Controls.Add(this.lblTituloExportar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExportarReportes";
            this.Text = "ExportarReportes";
            this.Load += new System.EventHandler(this.ExportarReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvBuscarReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloExportar;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridView gdvBuscarReporte;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblFEstimada;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFInicial;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DateTimePicker dtpFInicial;
        private System.Windows.Forms.DateTimePicker dtpFEstimada;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblIndicacion;
    }
}