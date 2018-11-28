namespace Vistas
{
    partial class FormSubirArchivos
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
            this.lblSubirArchivo = new System.Windows.Forms.Label();
            this.btnAgregarArchivo = new System.Windows.Forms.Button();
            this.ofdArchivo = new System.Windows.Forms.OpenFileDialog();
            this.dgvArchivos = new System.Windows.Forms.DataGridView();
            this.colArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubirArchivos = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.foldDescarga = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDescargarArchivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubirArchivo
            // 
            this.lblSubirArchivo.AutoSize = true;
            this.lblSubirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSubirArchivo.Location = new System.Drawing.Point(54, 31);
            this.lblSubirArchivo.Name = "lblSubirArchivo";
            this.lblSubirArchivo.Size = new System.Drawing.Size(390, 31);
            this.lblSubirArchivo.TabIndex = 0;
            this.lblSubirArchivo.Text = "Archivos Adjuntos del Proyecto";
            this.lblSubirArchivo.Click += new System.EventHandler(this.lblSubirArchivo_Click);
            // 
            // btnAgregarArchivo
            // 
            this.btnAgregarArchivo.Location = new System.Drawing.Point(76, 100);
            this.btnAgregarArchivo.Name = "btnAgregarArchivo";
            this.btnAgregarArchivo.Size = new System.Drawing.Size(104, 29);
            this.btnAgregarArchivo.TabIndex = 1;
            this.btnAgregarArchivo.Text = "Agregar Archivo";
            this.btnAgregarArchivo.UseVisualStyleBackColor = true;
            this.btnAgregarArchivo.Click += new System.EventHandler(this.btnAgregarArchivo_Click);
            // 
            // ofdArchivo
            // 
            this.ofdArchivo.FileName = "openFileDialog1";
            this.ofdArchivo.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // dgvArchivos
            // 
            this.dgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArchivo});
            this.dgvArchivos.Location = new System.Drawing.Point(76, 154);
            this.dgvArchivos.Name = "dgvArchivos";
            this.dgvArchivos.Size = new System.Drawing.Size(333, 341);
            this.dgvArchivos.TabIndex = 2;
            this.dgvArchivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArchivos_CellContentClick);
            // 
            // colArchivo
            // 
            this.colArchivo.DataPropertyName = "NombreArchivo";
            this.colArchivo.HeaderText = "Nombre Archivo";
            this.colArchivo.Name = "colArchivo";
            this.colArchivo.Width = 400;
            // 
            // btnSubirArchivos
            // 
            this.btnSubirArchivos.Location = new System.Drawing.Point(76, 539);
            this.btnSubirArchivos.Name = "btnSubirArchivos";
            this.btnSubirArchivos.Size = new System.Drawing.Size(92, 30);
            this.btnSubirArchivos.TabIndex = 3;
            this.btnSubirArchivos.Text = "Subir Archivos";
            this.btnSubirArchivos.UseVisualStyleBackColor = true;
            this.btnSubirArchivos.Click += new System.EventHandler(this.btnSubirArchivos_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(317, 539);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDescargarArchivo
            // 
            this.btnDescargarArchivo.Location = new System.Drawing.Point(305, 100);
            this.btnDescargarArchivo.Name = "btnDescargarArchivo";
            this.btnDescargarArchivo.Size = new System.Drawing.Size(104, 29);
            this.btnDescargarArchivo.TabIndex = 5;
            this.btnDescargarArchivo.Text = "Descargar Archivo";
            this.btnDescargarArchivo.UseVisualStyleBackColor = true;
            this.btnDescargarArchivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSubirArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 609);
            this.Controls.Add(this.btnDescargarArchivo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSubirArchivos);
            this.Controls.Add(this.dgvArchivos);
            this.Controls.Add(this.btnAgregarArchivo);
            this.Controls.Add(this.lblSubirArchivo);
            this.Name = "FormSubirArchivos";
            this.Text = "FormSubirArchivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubirArchivo;
        private System.Windows.Forms.Button btnAgregarArchivo;
        private System.Windows.Forms.OpenFileDialog ofdArchivo;
        private System.Windows.Forms.DataGridView dgvArchivos;
        private System.Windows.Forms.Button btnSubirArchivos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArchivo;
        private System.Windows.Forms.FolderBrowserDialog foldDescarga;
        private System.Windows.Forms.Button btnDescargarArchivo;
    }
}