using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaMotas.Funcionario
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();

            //Inicia o Form De Venda sendo o principal
            this.pnlFuncionariosForms.Controls.Clear();
            Venda venda = new Venda() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            venda.FormBorderStyle = FormBorderStyle.None;
            this.pnlFuncionariosForms.Controls.Add(venda);
            venda.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            this.pnlFuncionariosForms.Controls.Clear();
            Caixa caixa = new Caixa() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            caixa.FormBorderStyle = FormBorderStyle.None;
            this.pnlFuncionariosForms.Controls.Add(caixa);
            caixa.Show();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            this.pnlFuncionariosForms.Controls.Clear();
            Venda venda = new Venda() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            venda.FormBorderStyle = FormBorderStyle.None;
            this.pnlFuncionariosForms.Controls.Add(venda);
            venda.Show();
        }

        private void btnListaDeProdutos_Click(object sender, EventArgs e)
        {
            this.pnlFuncionariosForms.Controls.Clear();
            ListaDeProdutos listaDeProdutos = new ListaDeProdutos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            listaDeProdutos.FormBorderStyle = FormBorderStyle.None;
            this.pnlFuncionariosForms.Controls.Add(listaDeProdutos);
            listaDeProdutos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.pnlFuncionariosForms.Controls.Clear();
            MeuPerfil meuPerfil = new MeuPerfil() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            meuPerfil.FormBorderStyle = FormBorderStyle.None;
            this.pnlFuncionariosForms.Controls.Add(meuPerfil);
            meuPerfil.Show();
        }

        private void btnDefinicoes_Click(object sender, EventArgs e)
        {
            this.pnlFuncionariosForms.Controls.Clear();
            Definicoes definicoes = new Definicoes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            definicoes.FormBorderStyle = FormBorderStyle.None;
            this.pnlFuncionariosForms.Controls.Add(definicoes);
            definicoes.Show();
        }

        private void pnlFuncionariosForms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var login = new Login();

            login.Show();

            this.Hide();
        }
    }
}
