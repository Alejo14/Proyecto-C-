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
            this.lblFEstimada = new System.Windows.Forms.Label();
            this.dtpFInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFEstimada = new System.Windows.Forms.DateTimePicker();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.ckbFechas = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloExportar
            // 
            this.lblTituloExportar.AutoSize = true;
            this.lblTituloExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloExportar.Location = new System.Drawing.Point(253, 53);
            this.lblTituloExportar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloExportar.Name = "lblTituloExportar";
            this.lblTituloExportar.Size = new System.Drawing.Size(234, 31);
            this.lblTituloExportar.TabIndex = 0;
            this.lblTituloExportar.Text = "Exportar Reportes";
            // 
            // lblFEstimada
            // 
            this.lblFEstimada.AutoSize = true;
            this.lblFEstimada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFEstimada.Location = new System.Drawing.Point(97, 240);
            this.lblFEstimada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFEstimada.Name = "lblFEstimada";
            this.lblFEstimada.Size = new System.Drawing.Size(141, 25);
            this.lblFEstimada.TabIndex = 8;
            this.lblFEstimada.Text = "Fecha Máxima";
            // 
            // dtpFInicial
            // 
            this.dtpFInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFInicial.Location = new System.Drawing.Point(345, 206);
            this.dtpFInicial.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFInicial.Name = "dtpFInicial";
            this.dtpFInicial.Size = new System.Drawing.Size(329, 22);
            this.dtpFInicial.TabIndex = 12;
            this.dtpFInicial.ValueChanged += new System.EventHandler(this.dtpFInicial_ValueChanged);
            // 
            // dtpFEstimada
            // 
            this.dtpFEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFEstimada.Location = new System.Drawing.Point(345, 240);
            this.dtpFEstimada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFEstimada.Name = "dtpFEstimada";
            this.dtpFEstimada.Size = new System.Drawing.Size(329, 22);
            this.dtpFEstimada.TabIndex = 13;
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicacion.Location = new System.Drawing.Point(70, 141);
            this.lblIndicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(473, 25);
            this.lblIndicacion.TabIndex = 15;
            this.lblIndicacion.Text = "Seleccione para ingresar la fecha mínima y/o máxima";
            // 
            // btnExportar
            // 
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = global::Vistas.Properties.Resources.Exportar_pequeño;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(514, 289);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(160, 53);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // ckbFechas
            // 
            this.ckbFechas.AutoSize = true;
            this.ckbFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFechas.Location = new System.Drawing.Point(75, 201);
            this.ckbFechas.Margin = new System.Windows.Forms.Padding(4);
            this.ckbFechas.Name = "ckbFechas";
            this.ckbFechas.Size = new System.Drawing.Size(157, 29);
            this.ckbFechas.TabIndex = 18;
            this.ckbFechas.Text = "Fecha Mínima";
            this.ckbFechas.UseVisualStyleBackColor = true;
            this.ckbFechas.CheckedChanged += new System.EventHandler(this.ckFechas_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblTituloExportar);
            this.panel1.Location = new System.Drawing.Point(-2, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 114);
            this.panel1.TabIndex = 19;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::Vistas.Properties.Resources.Back;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(75, 289);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(184, 53);
            this.btnRegresar.TabIndex = 20;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmExportarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 371);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.ckbFechas);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.dtpFEstimada);
            this.Controls.Add(this.dtpFInicial);
            this.Controls.Add(this.lblFEstimada);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExportarReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportarReportes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloExportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblFEstimada;
        private System.Windows.Forms.DateTimePicker dtpFInicial;
        private System.Windows.Forms.DateTimePicker dtpFEstimada;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.CheckBox ckbFechas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
    }
}