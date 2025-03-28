using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LojaMotas.Model;
using MySql.Data.MySqlClient;

namespace LojaMotas
{
    public partial class CadastroAdministrador : Form
    {
        CriarAdmin admin = new CriarAdmin();
        public CadastroAdministrador()
        {
            InitializeComponent();
        }

        private void CadastroAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastroAdmin_Click(object sender, EventArgs e)
        {
            if (VerificarCampo()) 
            {
                admin.InserirDados(txtEmailAdmin.Text, txtSenhaAdmin.Text);
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txtEmailAdmin.Clear();
            txtSenhaAdmin.Clear();
            txtEmailAdmin.Focus();
        }


        private void label6_Click(object sender, EventArgs e)
        {
            var login = new Login();

            login.Show();

            this.Hide();
        }

        private bool VerificarCampo()
        {
            bool campoVazio;  
            if (txtEmailAdmin.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Email não pode estar em branco");
                txtEmailAdmin.Focus();
                campoVazio = false;
            }
            else if(txtSenhaAdmin.Text.Trim()=="")
            {
                MessageBox.Show("Senha não pode estar em branco");
                txtSenhaAdmin.Focus();
                campoVazio = false;
            }
            else
            {
                campoVazio = true;
            }

            return campoVazio;
        }

    }
}
