namespace Vistas
{
    partial class FormMenuOperario
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
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.scOperario = new System.Windows.Forms.SplitContainer();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ptbUsuario = new System.Windows.Forms.PictureBox();
            this.btnSolicitarRetiroProyecto = new System.Windows.Forms.Button();
            this.btnVisualizarProyectos = new System.Windows.Forms.Button();
            this.bttLogOut = new System.Windows.Forms.Button();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scOperario)).BeginInit();
            this.scOperario.Panel1.SuspendLayout();
            this.scOperario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.barraTitulo.Controls.Add(this.iconMinimizar);
            this.barraTitulo.Controls.Add(this.iconCerrar);
            this.barraTitulo.Controls.Add(this.btnMenu);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1190, 45);
            this.barraTitulo.TabIndex = 20;
            this.barraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.barraTitulo_Paint);
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = global::Vistas.Properties.Resources.icon_minimizar;
            this.iconMinimizar.Location = new System.Drawing.Point(1119, 12);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(28, 25);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 2;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            this.iconMinimizar.MouseEnter += new System.EventHandler(this.iconMinimizar_MouseEnter);
            this.iconMinimizar.MouseLeave += new System.EventHandler(this.iconMinimizar_MouseLeave);
            // 
            // iconCerrar
            // 
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Image = global::Vistas.Properties.Resources.icon_cerrar2;
            this.iconCerrar.Location = new System.Drawing.Point(1153, 12);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(25, 25);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerrar.TabIndex = 1;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            this.iconCerrar.MouseEnter += new System.EventHandler(this.iconCerrar_MouseEnter);
            this.iconCerrar.MouseLeave += new System.EventHandler(this.iconCerrar_MouseLeave);
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMenu.Image = global::Vistas.Properties.Resources.Menu;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(61, 45);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // scOperario
            // 
            this.scOperario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scOperario.IsSplitterFixed = true;
            this.scOperario.Location = new System.Drawing.Point(0, 45);
            this.scOperario.Name = "scOperario";
            // 
            // scOperario.Panel1
            // 
            this.scOperario.Panel1.BackColor = System.Drawing.Color.White;
            this.scOperario.Panel1.Controls.Add(this.lblUsuarios);
            this.scOperario.Panel1.Controls.Add(this.pictureBox2);
            this.scOperario.Panel1.Controls.Add(this.ptbUsuario);
            this.scOperario.Panel1.Controls.Add(this.btnSolicitarRetiroProyecto);
            this.scOperario.Panel1.Controls.Add(this.btnVisualizarProyectos);
            this.scOperario.Panel1.Controls.Add(this.bttLogOut);
            // 
            // scOperario.Panel2
            // 
            this.scOperario.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.scOperario.Size = new System.Drawing.Size(1190, 565);
            this.scOperario.SplitterDistance = 259;
            this.scOperario.TabIndex = 21;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(87, 473);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(74, 16);
            this.lblUsuarios.TabIndex = 28;
            this.lblUsuarios.Text = "txtUsuarios";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vistas.Properties.Resources.Excellia_nombre;
            this.pictureBox2.Location = new System.Drawing.Point(34, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // ptbUsuario
            // 
            this.ptbUsuario.Image = global::Vistas.Properties.Resources.User;
            this.ptbUsuario.Location = new System.Drawing.Point(13, 464);
            this.ptbUsuario.Name = "ptbUsuario";
            this.ptbUsuario.Size = new System.Drawing.Size(68, 68);
            this.ptbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbUsuario.TabIndex = 26;
            this.ptbUsuario.TabStop = false;
            this.ptbUsuario.Click += new System.EventHandler(this.ptbUsuario_Click);
            // 
            // btnSolicitarRetiroProyecto
            // 
            this.btnSolicitarRetiroProyecto.BackColor = System.Drawing.Color.White;
            this.btnSolicitarRetiroProyecto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSolicitarRetiroProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitarRetiroProyecto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitarRetiroProyecto.Image = global::Vistas.Properties.Resources.Visualizar_pequeño;
            this.btnSolicitarRetiroProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicitarRetiroProyecto.Location = new System.Drawing.Point(9, 290);
            this.btnSolicitarRetiroProyecto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSolicitarRetiroProyecto.Name = "btnSolicitarRetiroProyecto";
            this.btnSolicitarRetiroProyecto.Size = new System.Drawing.Size(240, 59);
            this.btnSolicitarRetiroProyecto.TabIndex = 23;
            this.btnSolicitarRetiroProyecto.Text = "Solicitar Retiro de Proyecto";
            this.btnSolicitarRetiroProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSolicitarRetiroProyecto.UseVisualStyleBackColor = false;
            this.btnSolicitarRetiroProyecto.Click += new System.EventHandler(this.btnSolicitarRetiroProyecto_Click);
            // 
            // btnVisualizarProyectos
            // 
            this.btnVisualizarProyectos.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizarProyectos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVisualizarProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarProyectos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarProyectos.Image = global::Vistas.Properties.Resources.Visualizar_pequeño;
            this.btnVisualizarProyectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarProyectos.Location = new System.Drawing.Point(9, 236);
            this.btnVisualizarProyectos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVisualizarProyectos.Name = "btnVisualizarProyectos";
            this.btnVisualizarProyectos.Size = new System.Drawing.Size(138, 50);
            this.btnVisualizarProyectos.TabIndex = 22;
            this.btnVisualizarProyectos.Text = "Home";
            this.btnVisualizarProyectos.UseVisualStyleBackColor = false;
            this.btnVisualizarProyectos.Click += new System.EventHandler(this.btnVisualizarProyectos_Click);
            // 
            // bttLogOut
            // 
            this.bttLogOut.BackColor = System.Drawing.Color.White;
            this.bttLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttLogOut.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLogOut.Image = global::Vistas.Properties.Resources.LogOut;
            this.bttLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttLogOut.Location = new System.Drawing.Point(13, 412);
            this.bttLogOut.Name = "bttLogOut";
            this.bttLogOut.Size = new System.Drawing.Size(156, 46);
            this.bttLogOut.TabIndex = 25;
            this.bttLogOut.Text = "Cerrar Sesión";
            this.bttLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttLogOut.UseVisualStyleBackColor = false;
            this.bttLogOut.Click += new System.EventHandler(this.bttLogOut_Click);
            // 
            // FormMenuOperario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1190, 610);
            this.Controls.Add(this.scOperario);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMenuOperario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            this.scOperario.Panel1.ResumeLayout(false);
            this.scOperario.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scOperario)).EndInit();
            this.scOperario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.SplitContainer scOperario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ptbUsuario;
        private System.Windows.Forms.Button btnSolicitarRetiroProyecto;
        private System.Windows.Forms.Button btnVisualizarProyectos;
        private System.Windows.Forms.Button bttLogOut;
        private System.Windows.Forms.Label lblUsuarios;
    }
}