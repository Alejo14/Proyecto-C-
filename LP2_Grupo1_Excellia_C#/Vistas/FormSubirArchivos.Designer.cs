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
            this.foldDescarga = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDescargarArchivo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSubirArchivo
            // 
            this.lblSubirArchivo.AutoSize = true;
            this.lblSubirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubirArchivo.Location = new System.Drawing.Point(197, 40);
            this.lblSubirArchivo.Name = "lblSubirArchivo";
            this.lblSubirArchivo.Size = new System.Drawing.Size(311, 25);
            this.lblSubirArchivo.TabIndex = 0;
            this.lblSubirArchivo.Text = "Archivos Adjuntos del Proyecto";
            this.lblSubirArchivo.Click += new System.EventHandler(this.lblSubirArchivo_Click);
            // 
            // btnAgregarArchivo
            // 
            this.btnAgregarArchivo.FlatAppearance.BorderSize = 0;
            this.btnAgregarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArchivo.Image = global::Vistas.Properties.Resources.Derivar;
            this.btnAgregarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarArchivo.Location = new System.Drawing.Point(540, 456);
            this.btnAgregarArchivo.Name = "btnAgregarArchivo";
            this.btnAgregarArchivo.Size = new System.Drawing.Size(101, 52);
            this.btnAgregarArchivo.TabIndex = 1;
            this.btnAgregarArchivo.Text = "Cargar";
            this.btnAgregarArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.dgvArchivos.AllowUserToAddRows = false;
            this.dgvArchivos.AllowUserToDeleteRows = false;
            this.dgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArchivo});
            this.dgvArchivos.Location = new System.Drawing.Point(47, 117);
            this.dgvArchivos.Name = "dgvArchivos";
            this.dgvArchivos.ReadOnly = true;
            this.dgvArchivos.Size = new System.Drawing.Size(594, 322);
            this.dgvArchivos.TabIndex = 2;
            this.dgvArchivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArchivos_CellContentClick);
            // 
            // btnSubirArchivos
            // 
            this.btnSubirArchivos.FlatAppearance.BorderSize = 0;
            this.btnSubirArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirArchivos.Image = global::Vistas.Properties.Resources.folder_guardar_paste_save_icon_32;
            this.btnSubirArchivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubirArchivos.Location = new System.Drawing.Point(422, 456);
            this.btnSubirArchivos.Name = "btnSubirArchivos";
            this.btnSubirArchivos.Size = new System.Drawing.Size(93, 50);
            this.btnSubirArchivos.TabIndex = 3;
            this.btnSubirArchivos.Text = "Subir";
            this.btnSubirArchivos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubirArchivos.UseVisualStyleBackColor = true;
            this.btnSubirArchivos.Click += new System.EventHandler(this.btnSubirArchivos_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Vistas.Properties.Resources.Back;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(47, 456);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 51);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Regresar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDescargarArchivo
            // 
            this.btnDescargarArchivo.FlatAppearance.BorderSize = 0;
            this.btnDescargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarArchivo.Image = global::Vistas.Properties.Resources.Visualizar_pequeño;
            this.btnDescargarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescargarArchivo.Location = new System.Drawing.Point(271, 455);
            this.btnDescargarArchivo.Name = "btnDescargarArchivo";
            this.btnDescargarArchivo.Size = new System.Drawing.Size(120, 51);
            this.btnDescargarArchivo.TabIndex = 5;
            this.btnDescargarArchivo.Text = "Descargar";
            this.btnDescargarArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescargarArchivo.UseVisualStyleBackColor = true;
            this.btnDescargarArchivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblSubirArchivo);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 83);
            this.panel1.TabIndex = 6;
            // 
            // colArchivo
            // 
            this.colArchivo.DataPropertyName = "NombreArchivo";
            this.colArchivo.HeaderText = "Nombre Archivo";
            this.colArchivo.Name = "colArchivo";
            this.colArchivo.ReadOnly = true;
            this.colArchivo.Width = 550;
            // 
            // FormSubirArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 532);
            this.Controls.Add(this.btnDescargarArchivo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSubirArchivos);
            this.Controls.Add(this.dgvArchivos);
            this.Controls.Add(this.btnAgregarArchivo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSubirArchivos";
            this.Text = "Administrar Archivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSubirArchivo;
        private System.Windows.Forms.Button btnAgregarArchivo;
        private System.Windows.Forms.OpenFileDialog ofdArchivo;
        private System.Windows.Forms.DataGridView dgvArchivos;
        private System.Windows.Forms.Button btnSubirArchivos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.FolderBrowserDialog foldDescarga;
        private System.Windows.Forms.Button btnDescargarArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArchivo;
        private System.Windows.Forms.Panel panel1;
    }
}