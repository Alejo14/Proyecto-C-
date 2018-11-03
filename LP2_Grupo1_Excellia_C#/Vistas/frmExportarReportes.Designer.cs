﻿namespace Vistas
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFEstimada = new System.Windows.Forms.Label();
            this.dtpFInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFEstimada = new System.Windows.Forms.DateTimePicker();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.ckbEmpresa = new System.Windows.Forms.CheckBox();
            this.ckbEtapa = new System.Windows.Forms.CheckBox();
            this.ckbFechas = new System.Windows.Forms.CheckBox();
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
            this.cboEmpresa.Location = new System.Drawing.Point(382, 142);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(248, 21);
            this.cboEmpresa.TabIndex = 1;
            this.cboEmpresa.SelectedIndexChanged += new System.EventHandler(this.cboEmpresa_SelectedIndexChanged);
            // 
            // cboEstado
            // 
            this.cboEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(382, 173);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(248, 21);
            this.cboEstado.TabIndex = 2;
            // 
            // gdvBuscarReporte
            // 
            this.gdvBuscarReporte.AllowUserToAddRows = false;
            this.gdvBuscarReporte.AllowUserToDeleteRows = false;
            this.gdvBuscarReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvBuscarReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gdvBuscarReporte.Location = new System.Drawing.Point(173, 288);
            this.gdvBuscarReporte.Name = "gdvBuscarReporte";
            this.gdvBuscarReporte.ReadOnly = true;
            this.gdvBuscarReporte.Size = new System.Drawing.Size(639, 201);
            this.gdvBuscarReporte.TabIndex = 6;
            this.gdvBuscarReporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvBuscarReporte_CellContentClick);
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
            // lblFEstimada
            // 
            this.lblFEstimada.AutoSize = true;
            this.lblFEstimada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFEstimada.Location = new System.Drawing.Point(196, 235);
            this.lblFEstimada.Name = "lblFEstimada";
            this.lblFEstimada.Size = new System.Drawing.Size(160, 20);
            this.lblFEstimada.TabIndex = 8;
            this.lblFEstimada.Text = "Fecha final estimada:";
            // 
            // dtpFInicial
            // 
            this.dtpFInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFInicial.Location = new System.Drawing.Point(382, 207);
            this.dtpFInicial.Name = "dtpFInicial";
            this.dtpFInicial.Size = new System.Drawing.Size(248, 20);
            this.dtpFInicial.TabIndex = 12;
            this.dtpFInicial.ValueChanged += new System.EventHandler(this.dtpFInicial_ValueChanged);
            // 
            // dtpFEstimada
            // 
            this.dtpFEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFEstimada.Location = new System.Drawing.Point(382, 235);
            this.dtpFEstimada.Name = "dtpFEstimada";
            this.dtpFEstimada.Size = new System.Drawing.Size(248, 20);
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
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::Vistas.Properties.Resources.Search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(700, 212);
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
            // ckbEmpresa
            // 
            this.ckbEmpresa.AutoSize = true;
            this.ckbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEmpresa.Location = new System.Drawing.Point(179, 143);
            this.ckbEmpresa.Name = "ckbEmpresa";
            this.ckbEmpresa.Size = new System.Drawing.Size(149, 24);
            this.ckbEmpresa.TabIndex = 16;
            this.ckbEmpresa.Text = "Empresa Cliente:";
            this.ckbEmpresa.UseVisualStyleBackColor = true;
            this.ckbEmpresa.CheckedChanged += new System.EventHandler(this.ckbEmpresa_CheckedChanged);
            // 
            // ckbEtapa
            // 
            this.ckbEtapa.AutoSize = true;
            this.ckbEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEtapa.Location = new System.Drawing.Point(179, 173);
            this.ckbEtapa.Name = "ckbEtapa";
            this.ckbEtapa.Size = new System.Drawing.Size(75, 24);
            this.ckbEtapa.TabIndex = 17;
            this.ckbEtapa.Text = "Etapa:";
            this.ckbEtapa.UseVisualStyleBackColor = true;
            this.ckbEtapa.CheckedChanged += new System.EventHandler(this.ckbEtapa_CheckedChanged);
            // 
            // ckbFechas
            // 
            this.ckbFechas.AutoSize = true;
            this.ckbFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFechas.Location = new System.Drawing.Point(179, 203);
            this.ckbFechas.Name = "ckbFechas";
            this.ckbFechas.Size = new System.Drawing.Size(121, 24);
            this.ckbFechas.TabIndex = 18;
            this.ckbFechas.Text = "Fecha Inicial:";
            this.ckbFechas.UseVisualStyleBackColor = true;
            this.ckbFechas.CheckedChanged += new System.EventHandler(this.ckFechas_CheckedChanged);
            // 
            // frmExportarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 585);
            this.Controls.Add(this.ckbFechas);
            this.Controls.Add(this.ckbEtapa);
            this.Controls.Add(this.ckbEmpresa);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFEstimada);
            this.Controls.Add(this.dtpFInicial);
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
        private System.Windows.Forms.DateTimePicker dtpFInicial;
        private System.Windows.Forms.DateTimePicker dtpFEstimada;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.CheckBox ckbEmpresa;
        private System.Windows.Forms.CheckBox ckbEtapa;
        private System.Windows.Forms.CheckBox ckbFechas;
    }
}