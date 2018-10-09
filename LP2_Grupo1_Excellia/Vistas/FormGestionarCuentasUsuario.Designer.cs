namespace Vistas
{
    partial class FormGestionarCuentasUsuario
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
            this.lblGestionarCuentasUsuario = new System.Windows.Forms.Label();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionarCuentasUsuario
            // 
            this.lblGestionarCuentasUsuario.AutoSize = true;
            this.lblGestionarCuentasUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblGestionarCuentasUsuario.Location = new System.Drawing.Point(541, 76);
            this.lblGestionarCuentasUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestionarCuentasUsuario.Name = "lblGestionarCuentasUsuario";
            this.lblGestionarCuentasUsuario.Size = new System.Drawing.Size(474, 39);
            this.lblGestionarCuentasUsuario.TabIndex = 0;
            this.lblGestionarCuentasUsuario.Text = "Gestionar Cuentas de Usuario";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(453, 191);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(144, 41);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNomUsuario,
            this.colTipoUsuario});
            this.dgvUsuarios.Location = new System.Drawing.Point(453, 298);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(659, 315);
            this.dgvUsuarios.TabIndex = 2;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(968, 191);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(144, 41);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "IdCuenta";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            // 
            // colNomUsuario
            // 
            this.colNomUsuario.DataPropertyName = "NombUsuario";
            this.colNomUsuario.HeaderText = "Nombre Usuario";
            this.colNomUsuario.Name = "colNomUsuario";
            this.colNomUsuario.Width = 200;
            // 
            // colTipoUsuario
            // 
            this.colTipoUsuario.HeaderText = "Tipo de Usuario";
            this.colTipoUsuario.Name = "colTipoUsuario";
            this.colTipoUsuario.Width = 150;
            // 
            // FormGestionarCuentasUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 772);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.lblGestionarCuentasUsuario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGestionarCuentasUsuario";
            this.Text = "FormGestionarCuentasUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionarCuentasUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoUsuario;
    }
}