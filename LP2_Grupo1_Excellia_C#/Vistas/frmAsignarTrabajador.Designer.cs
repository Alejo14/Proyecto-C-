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
            this.components = new System.ComponentModel.Container();
            this.dgvTrabajador = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.errorProviderDNI = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAvanzada = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnForm_Buscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrabajador
            // 
            this.dgvTrabajador.AllowUserToAddRows = false;
            this.dgvTrabajador.AllowUserToDeleteRows = false;
            this.dgvTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nombre,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.Correo,
            this.Telefono});
            this.dgvTrabajador.Location = new System.Drawing.Point(39, 290);
            this.dgvTrabajador.Name = "dgvTrabajador";
            this.dgvTrabajador.ReadOnly = true;
            this.dgvTrabajador.Size = new System.Drawing.Size(643, 211);
            this.dgvTrabajador.TabIndex = 0;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "Dni";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.DataPropertyName = "ApellidoPaterno";
            this.ApellidoPaterno.HeaderText = "Apellido Paterno";
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.ReadOnly = true;
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.DataPropertyName = "ApellidoMaterno";
            this.ApellidoMaterno.HeaderText = "Apellido Materno";
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(239, 146);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(333, 20);
            this.txtDNI.TabIndex = 12;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(259, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 25);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Asignar Trabajadores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(239, 191);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(333, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // errorProviderDNI
            // 
            this.errorProviderDNI.ContainerControl = this;
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.ContainerControl = this;
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicacion.Location = new System.Drawing.Point(125, 107);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(406, 20);
            this.lblIndicacion.TabIndex = 21;
            this.lblIndicacion.Text = "Seleccione uno o más criterios para realizar la búsqueda";
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::Vistas.Properties.Resources.Back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(141, 516);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 49);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Regresar";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAvanzada
            // 
            this.btnAvanzada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvanzada.FlatAppearance.BorderSize = 0;
            this.btnAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvanzada.Image = global::Vistas.Properties.Resources.Más_pequeño;
            this.btnAvanzada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvanzada.Location = new System.Drawing.Point(129, 222);
            this.btnAvanzada.Name = "btnAvanzada";
            this.btnAvanzada.Size = new System.Drawing.Size(118, 49);
            this.btnAvanzada.TabIndex = 19;
            this.btnAvanzada.Text = "Avanzada";
            this.btnAvanzada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAvanzada.UseVisualStyleBackColor = true;
            this.btnAvanzada.Click += new System.EventHandler(this.btnAvanzada_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Image = global::Vistas.Properties.Resources.Derivar;
            this.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignar.Location = new System.Drawing.Point(463, 516);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(109, 49);
            this.btnAsignar.TabIndex = 10;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnForm_Buscar
            // 
            this.btnForm_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForm_Buscar.FlatAppearance.BorderSize = 0;
            this.btnForm_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm_Buscar.Image = global::Vistas.Properties.Resources.Search;
            this.btnForm_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForm_Buscar.Location = new System.Drawing.Point(471, 228);
            this.btnForm_Buscar.Name = "btnForm_Buscar";
            this.btnForm_Buscar.Size = new System.Drawing.Size(101, 36);
            this.btnForm_Buscar.TabIndex = 9;
            this.btnForm_Buscar.Text = "Buscar";
            this.btnForm_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnForm_Buscar.UseVisualStyleBackColor = true;
            this.btnForm_Buscar.Click += new System.EventHandler(this.btnForm_Buscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 81);
            this.panel1.TabIndex = 22;
            // 
            // frmAsignarTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 580);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAvanzada);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnForm_Buscar);
            this.Controls.Add(this.dgvTrabajador);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAsignarTrabajador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Trabajador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrabajador;
        private System.Windows.Forms.Button btnForm_Buscar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAvanzada;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.ErrorProvider errorProviderDNI;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.Panel panel1;
    }
}