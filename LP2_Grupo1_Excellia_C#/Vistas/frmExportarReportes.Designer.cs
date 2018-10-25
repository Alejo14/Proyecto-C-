namespace Vistas
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
            this.gdvBuscarReporte = new System.Windows.Forms.DataGridView();
            this.lblFEstimada = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFInicial = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.dtpFInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFEstimada = new System.Windows.Forms.DateTimePicker();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBuscarReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloExportar
            // 
            this.lblTituloExportar.AutoSize = true;
            this.lblTituloExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloExportar.Location = new System.Drawing.Point(400, 48);
            this.lblTituloExportar.Name = "lblTituloExportar";
            this.lblTituloExportar.Size = new System.Drawing.Size(186, 25);
            this.lblTituloExportar.TabIndex = 0;
            this.lblTituloExportar.Text = "Exportar Reportes";
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(289, 160);
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
            this.cboEstado.Location = new System.Drawing.Point(689, 163);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 2;
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
            this.gdvBuscarReporte.Location = new System.Drawing.Point(171, 308);
            this.gdvBuscarReporte.Name = "gdvBuscarReporte";
            this.gdvBuscarReporte.Size = new System.Drawing.Size(639, 181);
            this.gdvBuscarReporte.TabIndex = 6;
            // 
            // lblFEstimada
            // 
            this.lblFEstimada.AutoSize = true;
            this.lblFEstimada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFEstimada.Location = new System.Drawing.Point(509, 212);
            this.lblFEstimada.Name = "lblFEstimada";
            this.lblFEstimada.Size = new System.Drawing.Size(160, 20);
            this.lblFEstimada.TabIndex = 8;
            this.lblFEstimada.Text = "Fecha final estimada:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(509, 161);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:";
            // 
            // lblFInicial
            // 
            this.lblFInicial.AutoSize = true;
            this.lblFInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFInicial.Location = new System.Drawing.Point(167, 213);
            this.lblFInicial.Name = "lblFInicial";
            this.lblFInicial.Size = new System.Drawing.Size(100, 20);
            this.lblFInicial.TabIndex = 10;
            this.lblFInicial.Text = "Fecha inicial:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(167, 158);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(77, 20);
            this.lblEmpresa.TabIndex = 11;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // dtpFInicial
            // 
            this.dtpFInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFInicial.Location = new System.Drawing.Point(289, 213);
            this.dtpFInicial.Name = "dtpFInicial";
            this.dtpFInicial.Size = new System.Drawing.Size(121, 20);
            this.dtpFInicial.TabIndex = 12;
            this.dtpFInicial.ValueChanged += new System.EventHandler(this.dtpFInicial_ValueChanged);
            // 
            // dtpFEstimada
            // 
            this.dtpFEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFEstimada.Location = new System.Drawing.Point(689, 212);
            this.dtpFEstimada.Name = "dtpFEstimada";
            this.dtpFEstimada.Size = new System.Drawing.Size(121, 20);
            this.dtpFEstimada.TabIndex = 13;
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicacion.Location = new System.Drawing.Point(167, 105);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(406, 20);
            this.lblIndicacion.TabIndex = 15;
            this.lblIndicacion.Text = "Seleccione uno o más criterios para realizar la búsqueda";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre del Proyecto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 185;
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
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Empresa cliente";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::Vistas.Properties.Resources.Search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(698, 249);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 43);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = global::Vistas.Properties.Resources.Exportar_pequeño;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(689, 505);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(121, 43);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmExportarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 585);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFEstimada);
            this.Controls.Add(this.dtpFInicial);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblFInicial);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFEstimada);
            this.Controls.Add(this.gdvBuscarReporte);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.cboEmpresa);
            this.Controls.Add(this.lblTituloExportar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExportarReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblFEstimada;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFInicial;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.DateTimePicker dtpFInicial;
        private System.Windows.Forms.DateTimePicker dtpFEstimada;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}