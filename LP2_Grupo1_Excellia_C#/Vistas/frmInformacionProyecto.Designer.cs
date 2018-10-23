﻿namespace Vistas
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
            this.btnAtras = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsignarTrabajador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Location = new System.Drawing.Point(217, 255);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "Regresar";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(394, 255);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTituloInfProyecto
            // 
            this.lblTituloInfProyecto.AutoSize = true;
            this.lblTituloInfProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInfProyecto.Location = new System.Drawing.Point(219, 23);
            this.lblTituloInfProyecto.Name = "lblTituloInfProyecto";
            this.lblTituloInfProyecto.Size = new System.Drawing.Size(242, 24);
            this.lblTituloInfProyecto.TabIndex = 2;
            this.lblTituloInfProyecto.Text = "Información del Proyecto";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(33, 126);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 16);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id:";
            this.lblId.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(33, 94);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFInicial
            // 
            this.lblFInicial.AutoSize = true;
            this.lblFInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFInicial.Location = new System.Drawing.Point(33, 161);
            this.lblFInicial.Name = "lblFInicial";
            this.lblFInicial.Size = new System.Drawing.Size(100, 16);
            this.lblFInicial.TabIndex = 5;
            this.lblFInicial.Text = "Fecha inicial:";
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.Location = new System.Drawing.Point(313, 132);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(99, 16);
            this.lblPresupuesto.TabIndex = 6;
            this.lblPresupuesto.Text = "Presupuesto:";
            // 
            // lblEtapa
            // 
            this.lblEtapa.AutoSize = true;
            this.lblEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtapa.Location = new System.Drawing.Point(33, 196);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(53, 16);
            this.lblEtapa.TabIndex = 7;
            this.lblEtapa.Text = "Etapa:";
            // 
            // lblFEstimada
            // 
            this.lblFEstimada.AutoSize = true;
            this.lblFEstimada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFEstimada.Location = new System.Drawing.Point(313, 163);
            this.lblFEstimada.Name = "lblFEstimada";
            this.lblFEstimada.Size = new System.Drawing.Size(156, 16);
            this.lblFEstimada.TabIndex = 8;
            this.lblFEstimada.Text = "Fecha final estimada:";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.Location = new System.Drawing.Point(313, 196);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(76, 16);
            this.lblPrioridad.TabIndex = 10;
            this.lblPrioridad.Text = "Prioridad:";
            this.lblPrioridad.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(137, 127);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(156, 20);
            this.txtId.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(135, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(493, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // txtFInicial
            // 
            this.txtFInicial.Enabled = false;
            this.txtFInicial.Location = new System.Drawing.Point(137, 161);
            this.txtFInicial.Name = "txtFInicial";
            this.txtFInicial.Size = new System.Drawing.Size(156, 20);
            this.txtFInicial.TabIndex = 13;
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.Enabled = false;
            this.txtPresupuesto.Location = new System.Drawing.Point(472, 127);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(156, 20);
            this.txtPresupuesto.TabIndex = 14;
            // 
            // txtFEstimada
            // 
            this.txtFEstimada.Enabled = false;
            this.txtFEstimada.Location = new System.Drawing.Point(472, 161);
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
            this.cboPrioridad.Location = new System.Drawing.Point(472, 191);
            this.cboPrioridad.Name = "cboPrioridad";
            this.cboPrioridad.Size = new System.Drawing.Size(156, 21);
            this.cboPrioridad.TabIndex = 19;
            this.cboPrioridad.SelectedIndexChanged += new System.EventHandler(this.cboPrioridad_SelectedIndexChanged);
            // 
            // btnCancelarProyecto
            // 
            this.btnCancelarProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarProyecto.Location = new System.Drawing.Point(483, 255);
            this.btnCancelarProyecto.Name = "btnCancelarProyecto";
            this.btnCancelarProyecto.Size = new System.Drawing.Size(117, 23);
            this.btnCancelarProyecto.TabIndex = 20;
            this.btnCancelarProyecto.Text = "Cancelar proyecto";
            this.btnCancelarProyecto.UseVisualStyleBackColor = true;
            this.btnCancelarProyecto.Click += new System.EventHandler(this.btnCancelarProyecto_Click);
            // 
            // cboEtapa
            // 
            this.cboEtapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboEtapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEtapa.Enabled = false;
            this.cboEtapa.FormattingEnabled = true;
            this.cboEtapa.Location = new System.Drawing.Point(135, 194);
            this.cboEtapa.Name = "cboEtapa";
            this.cboEtapa.Size = new System.Drawing.Size(156, 21);
            this.cboEtapa.TabIndex = 21;
            this.cboEtapa.SelectedIndexChanged += new System.EventHandler(this.cboEtapa_SelectedIndexChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Location = new System.Drawing.Point(306, 255);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 2);
            this.label2.TabIndex = 24;
            // 
            // btnAsignarTrabajador
            // 
            this.btnAsignarTrabajador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarTrabajador.Location = new System.Drawing.Point(89, 255);
            this.btnAsignarTrabajador.Name = "btnAsignarTrabajador";
            this.btnAsignarTrabajador.Size = new System.Drawing.Size(115, 23);
            this.btnAsignarTrabajador.TabIndex = 25;
            this.btnAsignarTrabajador.Text = "Asignar Trabajador";
            this.btnAsignarTrabajador.UseVisualStyleBackColor = true;
            this.btnAsignarTrabajador.Click += new System.EventHandler(this.btnAsignarTrabajador_Click);
            // 
            // frmInformacionProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(669, 313);
            this.Controls.Add(this.btnAsignarTrabajador);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInformacionProyecto";
            this.Text = "frmInformacionProyecto";
            this.Load += new System.EventHandler(this.frmInformacionProyecto_Load);
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
        private System.Windows.Forms.Button btnAsignarTrabajador;
    }
}