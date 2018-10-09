namespace Vistas
{
    partial class FormAgregarRequerimiento
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
            this.lblAgregarRequerimiento = new System.Windows.Forms.Label();
            this.lblDescripcionRequerimiento = new System.Windows.Forms.Label();
            this.txtDescripcionRequerimiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoRequerimiento = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAgregarRequerimiento
            // 
            this.lblAgregarRequerimiento.AutoSize = true;
            this.lblAgregarRequerimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblAgregarRequerimiento.Location = new System.Drawing.Point(308, 76);
            this.lblAgregarRequerimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregarRequerimiento.Name = "lblAgregarRequerimiento";
            this.lblAgregarRequerimiento.Size = new System.Drawing.Size(369, 39);
            this.lblAgregarRequerimiento.TabIndex = 0;
            this.lblAgregarRequerimiento.Text = "Agregar Requerimiento";
            // 
            // lblDescripcionRequerimiento
            // 
            this.lblDescripcionRequerimiento.AutoSize = true;
            this.lblDescripcionRequerimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDescripcionRequerimiento.Location = new System.Drawing.Point(56, 258);
            this.lblDescripcionRequerimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionRequerimiento.Name = "lblDescripcionRequerimiento";
            this.lblDescripcionRequerimiento.Size = new System.Drawing.Size(240, 20);
            this.lblDescripcionRequerimiento.TabIndex = 1;
            this.lblDescripcionRequerimiento.Text = "Descripción de Requerimiento:";
            // 
            // txtDescripcionRequerimiento
            // 
            this.txtDescripcionRequerimiento.Location = new System.Drawing.Point(375, 257);
            this.txtDescripcionRequerimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionRequerimiento.Multiline = true;
            this.txtDescripcionRequerimiento.Name = "txtDescripcionRequerimiento";
            this.txtDescripcionRequerimiento.Size = new System.Drawing.Size(443, 125);
            this.txtDescripcionRequerimiento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(60, 439);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Requerimiento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbTipoRequerimiento
            // 
            this.cbTipoRequerimiento.FormattingEnabled = true;
            this.cbTipoRequerimiento.Items.AddRange(new object[] {
            "Funcional",
            "No Funcional"});
            this.cbTipoRequerimiento.Location = new System.Drawing.Point(375, 439);
            this.cbTipoRequerimiento.Name = "cbTipoRequerimiento";
            this.cbTipoRequerimiento.Size = new System.Drawing.Size(443, 24);
            this.cbTipoRequerimiento.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(315, 557);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(602, 557);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormAgregarRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 645);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbTipoRequerimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcionRequerimiento);
            this.Controls.Add(this.lblDescripcionRequerimiento);
            this.Controls.Add(this.lblAgregarRequerimiento);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAgregarRequerimiento";
            this.Text = "FormAgregarRequerimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarRequerimiento;
        private System.Windows.Forms.Label lblDescripcionRequerimiento;
        private System.Windows.Forms.TextBox txtDescripcionRequerimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoRequerimiento;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}