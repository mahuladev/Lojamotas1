using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaMotas
{
    public partial class RedefinirSenha : Form
    {
        public RedefinirSenha()
        {
            InitializeComponent();
        }

        private void btnRedefinirSenha_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text == string.Empty)
            {
                lblContexto1.Text = "Campo Obrigatório";
            }
            else if (txtNovaSenha.Text == string.Empty)
            {
                lblContexto2.Text = "Campo Obrigatório";
            }
            else
            {
                lblContexto1.Visible = false;
                lblContexto2.Visible = false;
            }
            if (txtNovaSenha.Text != txtConfirmarSenha.Text)
            {
                lblContexto2.Visible = false;

                lblContexto3.Text = "As senhas não podem ser diferentes!";
            }
            else
            {
                lblContexto3.Visible = false;
            }


            var login = new Login();

            login.Show();

            this.Hide();

        }

        private void pbVerNovaSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtNovaSenha.UseSystemPasswordChar = false;
        }

        private void pbVerNovaSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtNovaSenha.UseSystemPasswordChar = true;
        }

        private void pbConfirmarSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmarSenha.UseSystemPasswordChar = false;
        }

        private void pbConfirmarSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmarSenha.UseSystemPasswordChar = true;
        }
    }
}
