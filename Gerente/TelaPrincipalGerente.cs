using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaMotas.Gerente
{
    public partial class TelaPrincipalGerente : Form
    {
        public TelaPrincipalGerente()
        {
            InitializeComponent();

            this.pnlCentroAdministrador.Controls.Clear();
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario() { Dock = DockStyle.None, TopLevel = false, TopMost = true };
            cadastroFuncionario.FormBorderStyle = FormBorderStyle.None;
            this.pnlCentroAdministrador.Controls.Add(cadastroFuncionario);
            cadastroFuncionario.Show();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            this.pnlCentroAdministrador.Controls.Clear();
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario() { Dock = DockStyle.None, TopLevel = false, TopMost = true };
            cadastroFuncionario.FormBorderStyle = FormBorderStyle.None;
            this.pnlCentroAdministrador.Controls.Add(cadastroFuncionario);
            cadastroFuncionario.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }


        //Botão que leva ao form De Lista de Funcionário
        private void btnListaDeFuncionarios_Click(object sender, EventArgs e)
        {
            this.pnlCentroAdministrador.Controls.Clear();
            ListaDeFuncionario listaDeFuncionario = new ListaDeFuncionario() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            listaDeFuncionario.FormBorderStyle = FormBorderStyle.None;
            this.pnlCentroAdministrador.Controls.Add(listaDeFuncionario);
            listaDeFuncionario.Show();
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            this.pnlCentroAdministrador.Controls.Clear();
            Contactos contactos = new Contactos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            contactos.FormBorderStyle = FormBorderStyle.None;
            this.pnlCentroAdministrador.Controls.Add(contactos);
            contactos.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            this.pnlCentroAdministrador.Controls.Clear();
            Estoque estoque = new Estoque() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            estoque.FormBorderStyle = FormBorderStyle.None;
            this.pnlCentroAdministrador.Controls.Add(estoque);
            estoque.Show();
        }
    }
}
