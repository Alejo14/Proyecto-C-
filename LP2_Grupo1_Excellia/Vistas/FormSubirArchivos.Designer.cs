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
            this.btnSubirArchivos = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.colArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubirArchivo
            // 
            this.lblSubirArchivo.AutoSize = true;
            this.lblSubirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSubirArchivo.Location = new System.Drawing.Point(184, 64);
            this.lblSubirArchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubirArchivo.Name = "lblSubirArchivo";
            this.lblSubirArchivo.Size = new System.Drawing.Size(220, 39);
            this.lblSubirArchivo.TabIndex = 0;
            this.lblSubirArchivo.Text = "Subir Archivo";
            // 
            // btnAgregarArchivo
            // 
            this.btnAgregarArchivo.Location = new System.Drawing.Point(101, 123);
            this.btnAgregarArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarArchivo.Name = "btnAgregarArchivo";
            this.btnAgregarArchivo.Size = new System.Drawing.Size(139, 36);
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
            this.dgvArchivos.Location = new System.Drawing.Point(101, 190);
            this.dgvArchivos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArchivos.Name = "dgvArchivos";
            this.dgvArchivos.Size = new System.Drawing.Size(444, 420);
            this.dgvArchivos.TabIndex = 2;
            // 
            // btnSubirArchivos
            // 
            this.btnSubirArchivos.Location = new System.Drawing.Point(101, 672);
            this.btnSubirArchivos.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubirArchivos.Name = "btnSubirArchivos";
            this.btnSubirArchivos.Size = new System.Drawing.Size(123, 28);
            this.btnSubirArchivos.TabIndex = 3;
            this.btnSubirArchivos.Text = "Subir Archivos";
            this.btnSubirArchivos.UseVisualStyleBackColor = true;
            this.btnSubirArchivos.Click += new System.EventHandler(this.btnSubirArchivos_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(422, 672);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 28);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // colArchivo
            // 
            this.colArchivo.DataPropertyName = "NombreArchivo";
            this.colArchivo.HeaderText = "Nombre Archivo";
            this.colArchivo.Name = "colArchivo";
            this.colArchivo.Width = 400;
            // 
            // FormSubirArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 798);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSubirArchivos);
            this.Controls.Add(this.dgvArchivos);
            this.Controls.Add(this.btnAgregarArchivo);
            this.Controls.Add(this.lblSubirArchivo);
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}