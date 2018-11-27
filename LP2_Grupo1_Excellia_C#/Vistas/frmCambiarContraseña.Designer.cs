namespace Vistas
{
    partial class frmCambiarContraseña
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
            this.lblContra = new System.Windows.Forms.Label();
            this.lblContraRep = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtContraRep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.errorContra = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContraRep = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorContra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraRep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(30, 151);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(132, 18);
            this.lblContra.TabIndex = 0;
            this.lblContra.Text = "Contraseña nueva:";
            // 
            // lblContraRep
            // 
            this.lblContraRep.AutoSize = true;
            this.lblContraRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraRep.Location = new System.Drawing.Point(33, 195);
            this.lblContraRep.Name = "lblContraRep";
            this.lblContraRep.Size = new System.Drawing.Size(137, 18);
            this.lblContraRep.TabIndex = 1;
            this.lblContraRep.Text = "Repetir contraseña:";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(200, 152);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(268, 20);
            this.txtContra.TabIndex = 1;
            // 
            // txtContraRep
            // 
            this.txtContraRep.Location = new System.Drawing.Point(200, 196);
            this.txtContraRep.Name = "txtContraRep";
            this.txtContraRep.PasswordChar = '*';
            this.txtContraRep.Size = new System.Drawing.Size(268, 20);
            this.txtContraRep.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cambiar Contraseña";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.Image = global::Vistas.Properties.Resources.Exportar_pequeño;
            this.btnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCambios.Location = new System.Drawing.Point(298, 241);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(170, 48);
            this.btnGuardarCambios.TabIndex = 3;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlTitulo.Controls.Add(this.label3);
            this.pnlTitulo.Location = new System.Drawing.Point(0, -1);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(499, 107);
            this.pnlTitulo.TabIndex = 5;
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::Vistas.Properties.Resources.Back;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(36, 241);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(126, 48);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // errorContra
            // 
            this.errorContra.ContainerControl = this;
            // 
            // errorContraRep
            // 
            this.errorContraRep.ContainerControl = this;
            // 
            // frmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 306);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.txtContraRep);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.lblContraRep);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCambiarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Contraseña";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorContra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblContraRep;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtContraRep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ErrorProvider errorContra;
        private System.Windows.Forms.ErrorProvider errorContraRep;
    }
}