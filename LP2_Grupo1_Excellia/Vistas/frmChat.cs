using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class frmChat : Form
    {
        public frmChat()
        {
            InitializeComponent();

            dgvUsuario.Rows.Add("Alejandro López");
            dgvUsuario.Rows.Add("Roberto Paredes");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(txtMessenger.Text != "")
            {
                if (txtHistorialChat.Text != "")
                {
                    txtHistorialChat.Text = txtHistorialChat.Text + Environment.NewLine + "Usuario: " + txtMessenger.Text;
                }
                else
                {
                    txtHistorialChat.Text = "Usuario: " + txtMessenger.Text;
                }
            }
            txtMessenger.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
