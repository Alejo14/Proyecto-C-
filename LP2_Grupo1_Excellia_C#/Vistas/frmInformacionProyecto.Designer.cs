namespace Vistas
{
    partial class frmInformacionProyecto
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTituloInfProyecto = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFInicial = new System.Windows.Forms.Label();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.lblEtapa = new System.Windows.Forms.Label();
            this.lblFEstimada = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFInicial = new System.Windows.Forms.TextBox();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.txtFEstimada = new System.Windows.Forms.TextBox();
            this.cboPrioridad = new System.Windows.Forms.ComboBox();
            this.btnCancelarProyecto = new System.Windows.Forms.Button();
            this.cboEtapa = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::Vistas.Properties.Resources.Yes;
            this.btnGuardar.Location = new System.Drawing.Point(554, 299);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(59, 48);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTituloInfProyecto
            // 
            this.lblTituloInfProyecto.AutoSize = true;
            this.lblTituloInfProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTituloInfProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInfProyecto.Location = new System.Drawing.Point(205, 40);
            this.lblTituloInfProyecto.Name = "lblTituloInfProyecto";
            this.lblTituloInfProyecto.Size = new System.Drawing.Size(249, 25);
            this.lblTituloInfProyecto.TabIndex = 2;
            this.lblTituloInfProyecto.Text = "Información del Proyecto";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(27, 175);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 18);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(27, 137);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFInicial
            // 
            this.lblFInicial.AutoSize = true;
            this.lblFInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFInicial.Location = new System.Drawing.Point(27, 204);
            this.lblFInicial.Name = "lblFInicial";
            this.lblFInicial.Size = new System.Drawing.Size(93, 18);
            this.lblFInicial.TabIndex = 5;
            this.lblFInicial.Text = "Fecha inicial:";
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.Location = new System.Drawing.Point(307, 175);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(96, 18);
            this.lblPresupuesto.TabIndex = 6;
            this.lblPresupuesto.Text = "Presupuesto:";
            // 
            // lblEtapa
            // 
            this.lblEtapa.AutoSize = true;
            this.lblEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtapa.Location = new System.Drawing.Point(27, 239);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(50, 18);
            this.lblEtapa.TabIndex = 7;
            this.lblEtapa.Text = "Etapa:";
            // 
            // lblFEstimada
            // 
            this.lblFEstimada.AutoSize = true;
            this.lblFEstimada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFEstimada.Location = new System.Drawing.Point(307, 206);
            this.lblFEstimada.Name = "lblFEstimada";
            this.lblFEstimada.Size = new System.Drawing.Size(147, 18);
            this.lblFEstimada.TabIndex = 8;
            this.lblFEstimada.Text = "Fecha final estimada:";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.Location = new System.Drawing.Point(307, 239);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(71, 18);
            this.lblPrioridad.TabIndex = 10;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(131, 170);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(156, 20);
            this.txtId.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(129, 133);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(493, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // txtFInicial
            // 
            this.txtFInicial.Enabled = false;
            this.txtFInicial.Location = new System.Drawing.Point(131, 204);
            this.txtFInicial.Name = "txtFInicial";
            this.txtFInicial.Size = new System.Drawing.Size(156, 20);
            this.txtFInicial.TabIndex = 13;
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.Enabled = false;
            this.txtPresupuesto.Location = new System.Drawing.Point(466, 170);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(156, 20);
            this.txtPresupuesto.TabIndex = 14;
            // 
            // txtFEstimada
            // 
            this.txtFEstimada.Enabled = false;
            this.txtFEstimada.Location = new System.Drawing.Point(466, 204);
            this.txtFEstimada.Name = "txtFEstimada";
            this.txtFEstimada.Size = new System.Drawing.Size(156, 20);
            this.txtFEstimada.TabIndex = 18;
            // 
            // cboPrioridad
            // 
            this.cboPrioridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrioridad.Enabled = false;
            this.cboPrioridad.FormattingEnabled = true;
            this.cboPrioridad.Location = new System.Drawing.Point(466, 234);
            this.cboPrioridad.Name = "cboPrioridad";
            this.cboPrioridad.Size = new System.Drawing.Size(156, 21);
            this.cboPrioridad.TabIndex = 19;
            // 
            // btnCancelarProyecto
            // 
            this.btnCancelarProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarProyecto.FlatAppearance.BorderSize = 0;
            this.btnCancelarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarProyecto.Image = global::Vistas.Properties.Resources.No;
            this.btnCancelarProyecto.Location = new System.Drawing.Point(437, 299);
            this.btnCancelarProyecto.Name = "btnCancelarProyecto";
            this.btnCancelarProyecto.Size = new System.Drawing.Size(53, 48);
            this.btnCancelarProyecto.TabIndex = 20;
            this.btnCancelarProyecto.UseVisualStyleBackColor = true;
            this.btnCancelarProyecto.Click += new System.EventHandler(this.btnCancelarProyecto_Click);
            // 
            // cboEtapa
            // 
            this.cboEtapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboEtapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEtapa.Enabled = false;
            this.cboEtapa.FormattingEnabled = true;
            this.cboEtapa.Location = new System.Drawing.Point(129, 237);
            this.cboEtapa.Name = "cboEtapa";
            this.cboEtapa.Size = new System.Drawing.Size(156, 21);
            this.cboEtapa.TabIndex = 21;
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::Vistas.Properties.Resources.Evaluar;
            this.btnEditar.Location = new System.Drawing.Point(320, 302);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(43, 40);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::Vistas.Properties.Resources.Back;
            this.btnAtras.Location = new System.Drawing.Point(30, 300);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(47, 46);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Editar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cancelar Proyecto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Guardar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Regresar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 94);
            this.panel1.TabIndex = 32;
            // 
            // frmInformacionProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 392);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cboEtapa);
            this.Controls.Add(this.btnCancelarProyecto);
            this.Controls.Add(this.cboPrioridad);
            this.Controls.Add(this.txtFEstimada);
            this.Controls.Add(this.txtPresupuesto);
            this.Controls.Add(this.txtFInicial);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.lblFEstimada);
            this.Controls.Add(this.lblEtapa);
            this.Controls.Add(this.lblPresupuesto);
            this.Controls.Add(this.lblFInicial);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTituloInfProyecto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInformacionProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del Proyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTituloInfProyecto;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFInicial;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.Label lblEtapa;
        private System.Windows.Forms.Label lblFEstimada;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFInicial;
        private System.Windows.Forms.TextBox txtPresupuesto;
        private System.Windows.Forms.TextBox txtFEstimada;
        private System.Windows.Forms.ComboBox cboPrioridad;
        private System.Windows.Forms.Button btnCancelarProyecto;
        private System.Windows.Forms.ComboBox cboEtapa;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}