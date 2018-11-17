namespace Vistas
{
    partial class frmEvaluacionSolicitudCambio
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
            this.lblEvaluacionRechazo = new System.Windows.Forms.Label();
            this.lblMotivoRechazo = new System.Windows.Forms.Label();
            this.txtMotivoRechazo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEvaluacionRechazo
            // 
            this.lblEvaluacionRechazo.AutoSize = true;
            this.lblEvaluacionRechazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaluacionRechazo.Location = new System.Drawing.Point(304, 40);
            this.lblEvaluacionRechazo.Name = "lblEvaluacionRechazo";
            this.lblEvaluacionRechazo.Size = new System.Drawing.Size(231, 25);
            this.lblEvaluacionRechazo.TabIndex = 0;
            this.lblEvaluacionRechazo.Text = "Evaluación de rechazo";
            // 
            // lblMotivoRechazo
            // 
            this.lblMotivoRechazo.AutoSize = true;
            this.lblMotivoRechazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoRechazo.Location = new System.Drawing.Point(28, 105);
            this.lblMotivoRechazo.Name = "lblMotivoRechazo";
            this.lblMotivoRechazo.Size = new System.Drawing.Size(402, 16);
            this.lblMotivoRechazo.TabIndex = 1;
            this.lblMotivoRechazo.Text = "Por favor, ingrese el motivo del rechazo (máximo 4000 caracteres):";
            // 
            // txtMotivoRechazo
            // 
            this.txtMotivoRechazo.Location = new System.Drawing.Point(31, 124);
            this.txtMotivoRechazo.Multiline = true;
            this.txtMotivoRechazo.Name = "txtMotivoRechazo";
            this.txtMotivoRechazo.Size = new System.Drawing.Size(751, 310);
            this.txtMotivoRechazo.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(224, 477);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(541, 477);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmEvaluacionSolicitudCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 534);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtMotivoRechazo);
            this.Controls.Add(this.lblMotivoRechazo);
            this.Controls.Add(this.lblEvaluacionRechazo);
            this.Name = "frmEvaluacionSolicitudCambio";
            this.Text = "frmEvaluacionSolicitudCambio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvaluacionRechazo;
        private System.Windows.Forms.Label lblMotivoRechazo;
        private System.Windows.Forms.TextBox txtMotivoRechazo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}