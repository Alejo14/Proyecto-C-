namespace Vistas
{
    partial class FormularioModificacionRequerimiento
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
            this.lblModificacionReq = new System.Windows.Forms.Label();
            this.btnAgregarRequerimiento = new System.Windows.Forms.Button();
            this.btnEliminarRequerimiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModificacionReq
            // 
            this.lblModificacionReq.AutoSize = true;
            this.lblModificacionReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblModificacionReq.Location = new System.Drawing.Point(154, 48);
            this.lblModificacionReq.Name = "lblModificacionReq";
            this.lblModificacionReq.Size = new System.Drawing.Size(374, 31);
            this.lblModificacionReq.TabIndex = 0;
            this.lblModificacionReq.Text = "Modificación de requerimiento";
            // 
            // btnAgregarRequerimiento
            // 
            this.btnAgregarRequerimiento.Location = new System.Drawing.Point(160, 274);
            this.btnAgregarRequerimiento.Name = "btnAgregarRequerimiento";
            this.btnAgregarRequerimiento.Size = new System.Drawing.Size(151, 34);
            this.btnAgregarRequerimiento.TabIndex = 1;
            this.btnAgregarRequerimiento.Text = "Agregar Requerimiento";
            this.btnAgregarRequerimiento.UseVisualStyleBackColor = true;
            // 
            // btnEliminarRequerimiento
            // 
            this.btnEliminarRequerimiento.Location = new System.Drawing.Point(377, 274);
            this.btnEliminarRequerimiento.Name = "btnEliminarRequerimiento";
            this.btnEliminarRequerimiento.Size = new System.Drawing.Size(151, 34);
            this.btnEliminarRequerimiento.TabIndex = 2;
            this.btnEliminarRequerimiento.Text = "Eliminar Requerimiento";
            this.btnEliminarRequerimiento.UseVisualStyleBackColor = true;
            // 
            // FormularioModificacionRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 477);
            this.Controls.Add(this.btnEliminarRequerimiento);
            this.Controls.Add(this.btnAgregarRequerimiento);
            this.Controls.Add(this.lblModificacionReq);
            this.Name = "FormularioModificacionRequerimiento";
            this.Text = "FormularioModificacionRequerimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModificacionReq;
        private System.Windows.Forms.Button btnAgregarRequerimiento;
        private System.Windows.Forms.Button btnEliminarRequerimiento;
    }
}