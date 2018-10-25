namespace Vistas
{
    partial class frmGenerarProyecto
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
            this.dgvEruProyecto = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGenerarProyecto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEruProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEruProyecto
            // 
            this.dgvEruProyecto.AllowUserToAddRows = false;
            this.dgvEruProyecto.AllowUserToDeleteRows = false;
            this.dgvEruProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEruProyecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvEruProyecto.Location = new System.Drawing.Point(85, 155);
            this.dgvEruProyecto.Name = "dgvEruProyecto";
            this.dgvEruProyecto.ReadOnly = true;
            this.dgvEruProyecto.Size = new System.Drawing.Size(816, 290);
            this.dgvEruProyecto.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdERU";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Descripcion";
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NombreCliente";
            this.Column3.HeaderText = "Cliente";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FechaSolicitud";
            this.Column4.HeaderText = "Fecha Solicitud";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // lblGenerarProyecto
            // 
            this.lblGenerarProyecto.AutoSize = true;
            this.lblGenerarProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerarProyecto.Location = new System.Drawing.Point(395, 70);
            this.lblGenerarProyecto.Name = "lblGenerarProyecto";
            this.lblGenerarProyecto.Size = new System.Drawing.Size(181, 25);
            this.lblGenerarProyecto.TabIndex = 1;
            this.lblGenerarProyecto.Text = "Generar Proyecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccionar una ERU";
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::Vistas.Properties.Resources.Derivar1;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(807, 461);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 45);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmGenerarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblGenerarProyecto);
            this.Controls.Add(this.dgvEruProyecto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGenerarProyecto";
            this.Text = "frmGenerarProyecto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEruProyecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEruProyecto;
        private System.Windows.Forms.Label lblGenerarProyecto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label2;
    }
}