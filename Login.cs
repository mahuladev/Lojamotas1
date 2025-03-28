using LojaMotas.Funcionario;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System.Net.WebSockets;
using System.Reflection;
using LojaMotas.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using LojaMotas.Model;

namespace LojaMotas
{
    public partial class Login : Form
    {
        VerificaUsuario verificaUsuario = new VerificaUsuario();
        public Login()
        {
            InitializeComponent();

            txtEmail.Focus();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            TimeSpan TempoRestante = DateTime.Now - Settings.Default.liberaLogin;

            if (TempoRestante.TotalSeconds < 0)
            {
                //lblMensagemRestante.Text = "";
                btnEntrar.Enabled = false;
                timerLogin.Start();
                timerLogin.Enabled = true;
            }
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            txtEmail.Text.ToLower();

            if (Validacoes() == false)
            { 
                return;
            }
            else if (Email.ValidarEmail(txtEmail.Text) && verificaUsuario.LoginAdmin(txtEmail.Text,txtSenha.Text))
            {
                var boasVindasAdmin = new BoasVindasAdmin();

                boasVindasAdmin.Show();

                this.Hide();
            }
            else if (Email.ValidarEmail(txtEmail.Text) && verificaUsuario.FuncionarioLogin(txtEmail.Text, txtSenha.Text))
            {
                var boasvindas = new BoasVindas();

                boasvindas.Show();

                this.Hide();
            }
            else
            {
                Tentativas();

                LimparCampos();
            }
        }

       

        private void lklEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var esqueceuSenha = new EsqueceuSenha();

            esqueceuSenha.Show();

            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void lklCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var cadastroAdmin = new CadastroAdministrador();

            cadastroAdmin.Show();

            this.Hide();
        }


        //Metódo para tentativas de senha
        private void Tentativas()
        {
            Settings.Default.tentativas++;
            Settings.Default.Save();

            int resta = 5 - Settings.Default.tentativas;

            if (resta <= 0)
            {
                Bloquear();
                return;
            }
            else if (resta == 1) 
            { 
                lblMensagemRestante.Text = $"Restam somente uma tentativa antes do bloqueio temporário";
            }
            else 
            { 
                lblMensagemRestante.Text = $"Restam {resta} tentativas";
            }
        }

        private void Bloquear()
        {
            Settings.Default.tentativas = 0;
            Settings.Default.liberaLogin = DateTime.Now.AddSeconds(60);
            Settings.Default.Save();
            btnEntrar.Enabled = false;
            timerLogin.Enabled = true;
            timerLogin.Start();
            LimparCampos();
        }

        private bool Validacoes()
        {
            if (txtEmail.Text == string.Empty)
            {
                lblMensagem.Text = "Campo obrigatório";
                txtEmail.Focus();
                return false;
            }
            if (txtSenha.Text == string.Empty)
            {
                lblMensagem2.Text = "Campo obrigatório";
                txtSenha.Focus();
                return false;
            }

            return true;
        }

        private void timerLogin_Tick(object sender, EventArgs e)
        {
            TimeSpan TempoRestante = DateTime.Now - Settings.Default.liberaLogin;

            if(TempoRestante.TotalSeconds > 0)
            {
                lblMensagemRestante.Text = "";
                btnEntrar.Enabled = true;
                timerLogin.Stop();
                timerLogin.Enabled = false;
            }
            else
            {
                lblMensagemRestante.Text = "Libera Em: " + TempoRestante.ToString(@"mm\:ss");
            }
        }

        private void LimparCampos()
        {
            txtEmail.Clear();
            txtSenha.Clear();
        }
    }
}
