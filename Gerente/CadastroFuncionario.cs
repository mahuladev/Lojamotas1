using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using LojaMotas.Model;

namespace LojaMotas.Gerente
{
    public partial class CadastroFuncionario : Form
    {
        FuncionarioBase funcionarioBase = new FuncionarioBase();

        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnGuardarCadastro_Click(object sender, EventArgs e)
        {
            if (ValidarTexto())
            {
                funcionarioBase.CadastrarFuncionario(txtNome.Text,txtEmail.Text,txtMorada.Text,txtTelefone.Text,txtSenha.Text,txtBilhete.Text,msktDataNascimento.Text,cmbCargo.Text);
            }
        }

        private void btnApagarCadastro_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

      
        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        //Método para verificação de caixas de texto

       

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "iamgens (*.jpg;*.png) | *.jpg;*.png"; //Mostra os arquivos de foto

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Pega o caminho da imagem selecionada
                funcionarioBase.foto = openFileDialog.FileName.ToString();
                pbFoto.ImageLocation = funcionarioBase.foto;
            }
        }

        private bool ValidarTexto()
        {
            bool ValidacaoTexto;

            if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o nome");
                txtNome.Focus();
                ValidacaoTexto = false;
            }
            else if (txtBilhete.Text == "")
            {
                MessageBox.Show("Informe o Nº do Bilhete");
                txtBilhete.Focus();
                ValidacaoTexto = false;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Informe o Email");
                txtEmail.Focus();
                ValidacaoTexto = false;
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Informe uma senha");
                txtSenha.Focus();
                ValidacaoTexto = false;
            }
            else if (cmbCargo.Text == "")
            {
                MessageBox.Show("O cargo é obrigatório");
                cmbCargo.Focus();
                ValidacaoTexto = false;
            }
            else if (msktDataNascimento.Text == "")
            {

                MessageBox.Show("Informe a Data De Nascimento");
                msktDataNascimento.Focus();
                ValidacaoTexto = false;
            }
            else
            {
                ValidacaoTexto = true;
            }


            return ValidacaoTexto;
        }

        public void LimparCampos()
        {
            txtBilhete.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtMorada.Clear();
            txtTelefone.Clear();
            txtSenha.Clear();

            msktDataNascimento.Clear();
        }
    }
}
