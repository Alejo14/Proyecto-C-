namespace Vistas
{
    partial class frmChat
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
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHistorialChat = new System.Windows.Forms.TextBox();
            this.txtMessenger = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsuario});
            this.dgvUsuario.Location = new System.Drawing.Point(16, 15);
            this.dgvUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(327, 725);
            this.dgvUsuario.TabIndex = 1;
            // 
            // colUsuario
            // 
            this.colUsuario.HeaderText = "Usuarios Conectados";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Width = 200;
            // 
            // txtHistorialChat
            // 
            this.txtHistorialChat.BackColor = System.Drawing.Color.White;
            this.txtHistorialChat.Location = new System.Drawing.Point(385, 15);
            this.txtHistorialChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHistorialChat.Multiline = true;
            this.txtHistorialChat.Name = "txtHistorialChat";
            this.txtHistorialChat.ReadOnly = true;
            this.txtHistorialChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistorialChat.Size = new System.Drawing.Size(767, 678);
            this.txtHistorialChat.TabIndex = 2;
            // 
            // txtMessenger
            // 
            this.txtMessenger.AcceptsReturn = true;
            this.txtMessenger.AcceptsTab = true;
            this.txtMessenger.Location = new System.Drawing.Point(385, 714);
            this.txtMessenger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMessenger.Multiline = true;
            this.txtMessenger.Name = "txtMessenger";
            this.txtMessenger.Size = new System.Drawing.Size(457, 25);
            this.txtMessenger.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(867, 705);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(132, 38);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1021, 705);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 791);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMessenger);
            this.Controls.Add(this.txtHistorialChat);
            this.Controls.Add(this.dgvUsuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChat";
            this.Text = "Chat";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.TextBox txtHistorialChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.TextBox txtMessenger;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button button1;
    }
}