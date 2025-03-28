using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LojaMotas.Model;
using MySql.Data.MySqlClient;


namespace LojaMotas
{
    public partial class EsqueceuSenha : Form
    {
        public EsqueceuSenha()
        {
            InitializeComponent();
            txtEmailRecuperar.Focus();
        }
        
        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            string codigo = Funcoes.ChaveAleatoria();

            string assunto = "Código de Recuperação";

            string mensagem = "Este é o código de recuperação" + codigo;

            Email.EnviarEmail(txtEmailRecuperar.Text,assunto ,mensagem,lblAguarde,btnEnviarCodigo);

            pnlEnviarCodigo.Visible = false;
            TempoRecuperacao = DateTime.Now.AddMinutes(2);
            tmContador.Enabled = true;
            tmContador.Start();
            
            txtEmailRecuperar.Clear();
        }

        DateTime TempoRecuperacao;

        private void tmContador_Tick(object sender, EventArgs e)
        {
            TimeSpan tempoRestante = TempoRecuperacao - DateTime.Now;

            if (tempoRestante.TotalSeconds > 0)
            {
                lblContagem.Visible = true;

                lblContagem.Text = "Reenviar Código Em: " + tempoRestante.ToString(@"mm\:ss");
            }
            else
            {
                pnlEnviarCodigo.Visible = true;
                lblContagem.Text = "";
                tmContador.Enabled = false;
                tmContador.Stop();
            }
        }

        private void lblVoltar_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }


        //Botão de Validar se e o código enviado é igual

        private void btnValidar_Click(object sender, EventArgs e)
        {
            var redefinirSenha = new RedefinirSenha();

            redefinirSenha.Show();

            this.Hide();
        }


        
    }
}
