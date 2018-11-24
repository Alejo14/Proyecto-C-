namespace Vistas
{
    partial class frmMenuJefeProyecto
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.scJefeProyecto = new System.Windows.Forms.SplitContainer();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.btnGestionRequerimientos = new System.Windows.Forms.Button();
            this.btnGenerarProyecto = new System.Windows.Forms.Button();
            this.ptbUsuarios = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnBuscarContacto = new System.Windows.Forms.Button();
            this.btnExportarReportes = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnlogoInicio = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scJefeProyecto)).BeginInit();
            this.scJefeProyecto.Panel1.SuspendLayout();
            this.scJefeProyecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pbMinimizar);
            this.panel2.Controls.Add(this.pbExit);
            this.panel2.Controls.Add(this.btnSlide);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1190, 44);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.Image = global::Vistas.Properties.Resources.icon_minimizar;
            this.pbMinimizar.Location = new System.Drawing.Point(1101, 8);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(32, 30);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizar.TabIndex = 3;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.Image = global::Vistas.Properties.Resources.icon_cerrar2;
            this.pbExit.Location = new System.Drawing.Point(1151, 8);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(27, 30);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 1;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Image = global::Vistas.Properties.Resources.Menu1;
            this.btnSlide.Location = new System.Drawing.Point(3, 3);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(43, 39);
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // scJefeProyecto
            // 
            this.scJefeProyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scJefeProyecto.IsSplitterFixed = true;
            this.scJefeProyecto.Location = new System.Drawing.Point(0, 44);
            this.scJefeProyecto.Name = "scJefeProyecto";
            // 
            // scJefeProyecto.Panel1
            // 
            this.scJefeProyecto.Panel1.BackColor = System.Drawing.Color.White;
            this.scJefeProyecto.Panel1.Controls.Add(this.lblUsuarios);
            this.scJefeProyecto.Panel1.Controls.Add(this.btnGestionRequerimientos);
            this.scJefeProyecto.Panel1.Controls.Add(this.btnGenerarProyecto);
            this.scJefeProyecto.Panel1.Controls.Add(this.ptbUsuarios);
            this.scJefeProyecto.Panel1.Controls.Add(this.btnCerrarSesion);
            this.scJefeProyecto.Panel1.Controls.Add(this.btnBuscarContacto);
            this.scJefeProyecto.Panel1.Controls.Add(this.btnExportarReportes);
            this.scJefeProyecto.Panel1.Controls.Add(this.btnHome);
            this.scJefeProyecto.Panel1.Controls.Add(this.btnlogoInicio);
            this.scJefeProyecto.Size = new System.Drawing.Size(1190, 566);
            this.scJefeProyecto.SplitterDistance = 235;
            this.scJefeProyecto.TabIndex = 2;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(74, 483);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(68, 15);
            this.lblUsuarios.TabIndex = 19;
            this.lblUsuarios.Text = "txtUsuarios";
            // 
            // btnGestionRequerimientos
            // 
            this.btnGestionRequerimientos.FlatAppearance.BorderSize = 0;
            this.btnGestionRequerimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionRequerimientos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionRequerimientos.Image = global::Vistas.Properties.Resources.folder_guardar_paste_save_icon_32;
            this.btnGestionRequerimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionRequerimientos.Location = new System.Drawing.Point(8, 314);
            this.btnGestionRequerimientos.Name = "btnGestionRequerimientos";
            this.btnGestionRequerimientos.Size = new System.Drawing.Size(209, 41);
            this.btnGestionRequerimientos.TabIndex = 18;
            this.btnGestionRequerimientos.Text = "Gestión de Requisitos";
            this.btnGestionRequerimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionRequerimientos.UseVisualStyleBackColor = true;
            this.btnGestionRequerimientos.Click += new System.EventHandler(this.btnGestionRequerimientos_Click);
            // 
            // btnGenerarProyecto
            // 
            this.btnGenerarProyecto.FlatAppearance.BorderSize = 0;
            this.btnGenerarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarProyecto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarProyecto.Image = global::Vistas.Properties.Resources.Derivar;
            this.btnGenerarProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarProyecto.Location = new System.Drawing.Point(8, 165);
            this.btnGenerarProyecto.Name = "btnGenerarProyecto";
            this.btnGenerarProyecto.Size = new System.Drawing.Size(213, 41);
            this.btnGenerarProyecto.TabIndex = 17;
            this.btnGenerarProyecto.Text = "Generar Proyecto";
            this.btnGenerarProyecto.UseVisualStyleBackColor = true;
            this.btnGenerarProyecto.Click += new System.EventHandler(this.btnGenerarProyecto_Click);
            // 
            // ptbUsuarios
            // 
            this.ptbUsuarios.Image = global::Vistas.Properties.Resources.account_customer_man_profile_user_icon_64;
            this.ptbUsuarios.Location = new System.Drawing.Point(8, 473);
            this.ptbUsuarios.Name = "ptbUsuarios";
            this.ptbUsuarios.Size = new System.Drawing.Size(60, 63);
            this.ptbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbUsuarios.TabIndex = 16;
            this.ptbUsuarios.TabStop = false;
            this.ptbUsuarios.Click += new System.EventHandler(this.ptbUsuarios_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Image = global::Vistas.Properties.Resources.LogOut;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(8, 417);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(201, 50);
            this.btnCerrarSesion.TabIndex = 15;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnBuscarContacto
            // 
            this.btnBuscarContacto.FlatAppearance.BorderSize = 0;
            this.btnBuscarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarContacto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarContacto.Image = global::Vistas.Properties.Resources.folder_guardar_paste_save_icon_32;
            this.btnBuscarContacto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarContacto.Location = new System.Drawing.Point(8, 264);
            this.btnBuscarContacto.Name = "btnBuscarContacto";
            this.btnBuscarContacto.Size = new System.Drawing.Size(213, 41);
            this.btnBuscarContacto.TabIndex = 14;
            this.btnBuscarContacto.Text = "Buscar Contacto";
            this.btnBuscarContacto.UseVisualStyleBackColor = true;
            this.btnBuscarContacto.Click += new System.EventHandler(this.btnBuscarContacto_Click);
            // 
            // btnExportarReportes
            // 
            this.btnExportarReportes.FlatAppearance.BorderSize = 0;
            this.btnExportarReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarReportes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarReportes.Image = global::Vistas.Properties.Resources.folder_guardar_paste_save_icon_32;
            this.btnExportarReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarReportes.Location = new System.Drawing.Point(8, 212);
            this.btnExportarReportes.Name = "btnExportarReportes";
            this.btnExportarReportes.Size = new System.Drawing.Size(225, 46);
            this.btnExportarReportes.TabIndex = 11;
            this.btnExportarReportes.Text = "Exportar Reportes";
            this.btnExportarReportes.UseVisualStyleBackColor = true;
            this.btnExportarReportes.Click += new System.EventHandler(this.btnExportarReportes_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = global::Vistas.Properties.Resources.doc_document_new_note_icon_32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(8, 109);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(148, 50);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnVisualizarProyectos_Click);
            // 
            // btnlogoInicio
            // 
            this.btnlogoInicio.Image = global::Vistas.Properties.Resources.Name1;
            this.btnlogoInicio.Location = new System.Drawing.Point(21, 21);
            this.btnlogoInicio.Name = "btnlogoInicio";
            this.btnlogoInicio.Size = new System.Drawing.Size(180, 66);
            this.btnlogoInicio.TabIndex = 9;
            this.btnlogoInicio.TabStop = false;
            // 
            // frmMenuJefeProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 610);
            this.Controls.Add(this.scJefeProyecto);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuJefeProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuJefeProyecto";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.scJefeProyecto.Panel1.ResumeLayout(false);
            this.scJefeProyecto.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scJefeProyecto)).EndInit();
            this.scJefeProyecto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.SplitContainer scJefeProyecto;
        private System.Windows.Forms.Button btnGenerarProyecto;
        private System.Windows.Forms.PictureBox ptbUsuarios;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnExportarReportes;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox btnlogoInicio;
        private System.Windows.Forms.Button btnBuscarContacto;
        private System.Windows.Forms.Button btnGestionRequerimientos;
        private System.Windows.Forms.Label lblUsuarios;
    }
}