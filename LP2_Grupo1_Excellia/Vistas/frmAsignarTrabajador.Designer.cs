namespace Vistas
{
    partial class frmAsignarTrabajador
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
            this.dgvTrabajador = new System.Windows.Forms.DataGridView();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnForm_Buscar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajador)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrabajador
            // 
            this.dgvTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck});
            this.dgvTrabajador.Location = new System.Drawing.Point(25, 216);
            this.dgvTrabajador.Name = "dgvTrabajador";
            this.dgvTrabajador.Size = new System.Drawing.Size(712, 238);
            this.dgvTrabajador.TabIndex = 0;
            // 
            // colCheck
            // 
            this.colCheck.HeaderText = "Seleccionar";
            this.colCheck.Name = "colCheck";
            this.colCheck.Width = 75;
            // 
            // btnForm_Buscar
            // 
            this.btnForm_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForm_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm_Buscar.Location = new System.Drawing.Point(636, 152);
            this.btnForm_Buscar.Name = "btnForm_Buscar";
            this.btnForm_Buscar.Size = new System.Drawing.Size(101, 39);
            this.btnForm_Buscar.TabIndex = 9;
            this.btnForm_Buscar.Text = "Aceptar";
            this.btnForm_Buscar.UseVisualStyleBackColor = true;
            this.btnForm_Buscar.Click += new System.EventHandler(this.btnForm_Buscar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(620, 481);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(117, 39);
            this.btnAsignar.TabIndex = 10;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(459, 481);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(117, 39);
            this.btnQuitar.TabIndex = 11;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(91, 101);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(646, 20);
            this.txtBuscar.TabIndex = 12;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(258, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(251, 18);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "ASIGNACIÓN DE TRABAJADOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar";
            // 
            // frmAsignarTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnForm_Buscar);
            this.Controls.Add(this.dgvTrabajador);
            this.Name = "frmAsignarTrabajador";
            this.Text = "Asignar Trabajador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrabajador;
        private System.Windows.Forms.Button btnForm_Buscar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
    }
}