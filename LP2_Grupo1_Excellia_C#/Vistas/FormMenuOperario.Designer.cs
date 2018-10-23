﻿namespace Vistas
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExportarReportes = new System.Windows.Forms.Button();
            this.btnVisualizarProyectos = new System.Windows.Forms.Button();
            this.bttLogOut = new System.Windows.Forms.Button();
            this.btnSolicitarRetiroProyecto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Controls.Add(this.pictureBox2);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.btnSolicitarRetiroProyecto);
            this.pnlMenu.Controls.Add(this.bttLogOut);
            this.pnlMenu.Controls.Add(this.btnVisualizarProyectos);
            this.pnlMenu.Controls.Add(this.btnExportarReportes);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 45);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(262, 565);
            this.pnlMenu.TabIndex = 19;
            // 
            // btnExportarReportes
            // 
            this.btnExportarReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarReportes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExportarReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarReportes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarReportes.Image = global::Vistas.Properties.Resources.Exportar_pequeño;
            this.btnExportarReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarReportes.Location = new System.Drawing.Point(12, 301);
            this.btnExportarReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportarReportes.Name = "btnExportarReportes";
            this.btnExportarReportes.Size = new System.Drawing.Size(185, 56);
            this.btnExportarReportes.TabIndex = 4;
            this.btnExportarReportes.Text = "Exportar Reportes";
            this.btnExportarReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarReportes.UseVisualStyleBackColor = false;
            this.btnExportarReportes.Click += new System.EventHandler(this.btnExportarReportes_Click);
            // 
            // btnVisualizarProyectos
            // 
            this.btnVisualizarProyectos.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizarProyectos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVisualizarProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarProyectos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarProyectos.Image = global::Vistas.Properties.Resources.Visualizar_pequeño;
            this.btnVisualizarProyectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarProyectos.Location = new System.Drawing.Point(12, 184);
            this.btnVisualizarProyectos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisualizarProyectos.Name = "btnVisualizarProyectos";
            this.btnVisualizarProyectos.Size = new System.Drawing.Size(138, 50);
            this.btnVisualizarProyectos.TabIndex = 0;
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
            this.bttLogOut.Location = new System.Drawing.Point(12, 420);
            this.bttLogOut.Name = "bttLogOut";
            this.bttLogOut.Size = new System.Drawing.Size(156, 46);
            this.bttLogOut.TabIndex = 18;
            this.bttLogOut.Text = "Cerrar Sesión";
            this.bttLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttLogOut.UseVisualStyleBackColor = false;
            this.bttLogOut.Click += new System.EventHandler(this.bttLogOut_Click);
            // 
            // btnSolicitarRetiroProyecto
            // 
            this.btnSolicitarRetiroProyecto.BackColor = System.Drawing.Color.White;
            this.btnSolicitarRetiroProyecto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSolicitarRetiroProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitarRetiroProyecto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitarRetiroProyecto.Image = global::Vistas.Properties.Resources.Visualizar_pequeño;
            this.btnSolicitarRetiroProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicitarRetiroProyecto.Location = new System.Drawing.Point(12, 238);
            this.btnSolicitarRetiroProyecto.Margin = new System.Windows.Forms.Padding(2);
            this.btnSolicitarRetiroProyecto.Name = "btnSolicitarRetiroProyecto";
            this.btnSolicitarRetiroProyecto.Size = new System.Drawing.Size(240, 59);
            this.btnSolicitarRetiroProyecto.TabIndex = 2;
            this.btnSolicitarRetiroProyecto.Text = "Solicitar Retiro de Proyecto";
            this.btnSolicitarRetiroProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSolicitarRetiroProyecto.UseVisualStyleBackColor = false;
            this.btnSolicitarRetiroProyecto.Click += new System.EventHandler(this.btnSolicitarRetiroProyecto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vistas.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(12, 484);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vistas.Properties.Resources.Excellia_nombre;
            this.pictureBox2.Location = new System.Drawing.Point(33, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(262, 45);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(928, 565);
            this.panelContenedor.TabIndex = 21;
            // 
            // FormMenuOperario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1190, 610);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenuOperario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSolicitarRetiroProyecto;
        private System.Windows.Forms.Button bttLogOut;
        private System.Windows.Forms.Button btnVisualizarProyectos;
        private System.Windows.Forms.Button btnExportarReportes;
        private System.Windows.Forms.Panel panelContenedor;
    }
}