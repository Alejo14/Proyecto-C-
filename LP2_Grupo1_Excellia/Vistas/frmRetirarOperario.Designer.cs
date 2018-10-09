namespace Vistas
{
    partial class frmRetirarOperario
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
            this.cboProyecto = new System.Windows.Forms.ComboBox();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblRetirarOperario = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvOperarios = new System.Windows.Forms.DataGridView();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperarios)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProyecto
            // 
            this.cboProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProyecto.FormattingEnabled = true;
            this.cboProyecto.Location = new System.Drawing.Point(177, 70);
            this.cboProyecto.Name = "cboProyecto";
            this.cboProyecto.Size = new System.Drawing.Size(262, 21);
            this.cboProyecto.TabIndex = 0;
            this.cboProyecto.SelectedIndexChanged += new System.EventHandler(this.cboProyecto_SelectedIndexChanged);
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyecto.Location = new System.Drawing.Point(32, 71);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(139, 16);
            this.lblProyecto.TabIndex = 1;
            this.lblProyecto.Text = "Seleccionar proyecto:";
            this.lblProyecto.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRetirarOperario
            // 
            this.lblRetirarOperario.AutoSize = true;
            this.lblRetirarOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetirarOperario.Location = new System.Drawing.Point(148, 21);
            this.lblRetirarOperario.Name = "lblRetirarOperario";
            this.lblRetirarOperario.Size = new System.Drawing.Size(302, 24);
            this.lblRetirarOperario.TabIndex = 2;
            this.lblRetirarOperario.Text = "Retirar operario de un proyecto";
            this.lblRetirarOperario.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(464, 68);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvOperarios
            // 
            this.dgvOperarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.colRol,
            this.Column3});
            this.dgvOperarios.Location = new System.Drawing.Point(35, 120);
            this.dgvOperarios.Name = "dgvOperarios";
            this.dgvOperarios.RowHeadersVisible = false;
            this.dgvOperarios.Size = new System.Drawing.Size(524, 131);
            this.dgvOperarios.TabIndex = 4;
            this.dgvOperarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetirar.Location = new System.Drawing.Point(262, 273);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(91, 23);
            this.btnRetirar.TabIndex = 5;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // colRol
            // 
            this.colRol.Frozen = true;
            this.colRol.HeaderText = "Rol";
            this.colRol.Name = "colRol";
            this.colRol.ReadOnly = true;
            this.colRol.Width = 120;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Seleccionar";
            this.Column3.Name = "Column3";
            // 
            // frmRetirarOperario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 324);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.dgvOperarios);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblRetirarOperario);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.cboProyecto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRetirarOperario";
            this.Text = "frmRetirarOperario";
            this.Load += new System.EventHandler(this.frmRetirarOperario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProyecto;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblRetirarOperario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvOperarios;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
    }
}