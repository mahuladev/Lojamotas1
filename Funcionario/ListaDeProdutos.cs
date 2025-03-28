using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Compression;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using LojaMotas.Model;
using MySql.Data.MySqlClient;
using RestSharp;


namespace LojaMotas.Funcionario
{
    public partial class ListaDeProdutos : Form
    {
        Produto produto = new Produto();

        public ListaDeProdutos()
        {
            InitializeComponent();
        }
        public void FormatarGrid()
        {
            dgvListaDeProduto.Columns[0].HeaderText = "Código";
            dgvListaDeProduto.Columns[1].HeaderText = "Marca";
            dgvListaDeProduto.Columns[2].HeaderText = "Modelo";
            dgvListaDeProduto.Columns[3].HeaderText = "Cor";
            dgvListaDeProduto.Columns[4].HeaderText = "Preço";
            dgvListaDeProduto.Columns[5].HeaderText = "Quantidade";

            dgvListaDeProduto.Columns[0].Visible = false;
        }

        public void ListarGrid()
        {
            produto.VerProdutos(dgvListaDeProduto);

            FormatarGrid();
        }

        //Botão para adicionar produto
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidarTexto())
            {
                produto.CadastrarProduto(txtMarcaProduto.Text, txtModeloProduto.Text, txtCorProduto.Text, txtPrecoProduto.Text, txtQuantidadeProduto.Text);
                LimparCampos();
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnApagarProdutosDaLista_Click(object sender, EventArgs e)
        {
            produto.ApagarProduto();

            ListarGrid();
        }


        private void ListaDeProdutos_Load(object sender, EventArgs e)
        {
            //Load do Formulário

            ListarGrid();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            LimparCampos();

            HabilitarCampos();

            btnAdicionar.Enabled = true;
        }

        //Metódo para Habilitar Campos

        public void HabilitarCampos()
        {
            txtMarcaProduto.Enabled = true;
            txtModeloProduto.Enabled = true;
            txtCorProduto.Enabled = true;
            txtPrecoProduto.Enabled = true;
            txtQuantidadeProduto.Enabled = true;
            txtMarcaProduto.Focus();
        }
        public void DesabilitarBotoes()
        {
            btnNovoProduto.Enabled = false;
            btnAlterar.Enabled = false;
            btnApagarProdutosDaLista.Enabled = false;
            btnAdicionar.Enabled = false;
        }
        public void LimparCampos()
        {
            txtCorProduto.Clear();
            txtMarcaProduto.Clear();
            txtModeloProduto.Clear();
            txtPrecoProduto.Clear();
            txtQuantidadeProduto.Clear();
        }

        private void dgvListaDeProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos();

            btnAdicionar.Enabled = false;
            btnNovoProduto.Enabled = true;

            string id = dgvListaDeProduto.CurrentRow.Cells[0].Value.ToString();
            txtMarcaProduto.Text = dgvListaDeProduto.CurrentRow.Cells[1].Value.ToString();
            txtModeloProduto.Text = dgvListaDeProduto.CurrentRow.Cells[2].Value.ToString();
            txtCorProduto.Text = dgvListaDeProduto.CurrentRow.Cells[3].Value.ToString();
            txtPrecoProduto.Text = dgvListaDeProduto.CurrentRow.Cells[4].Value.ToString();
            txtQuantidadeProduto.Text = dgvListaDeProduto.CurrentRow.Cells[5].Value.ToString();
        }

        //Méoto para validarTexto

        private bool ValidarTexto()
        {
            bool validacaoTexto;

            if (txtMarcaProduto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe a Marca");
                txtMarcaProduto.Focus();
                validacaoTexto = false;
            }
            else if (txtModeloProduto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe o Modelo");
                txtModeloProduto.Focus();
                validacaoTexto = false;
            }
            else if (txtCorProduto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe a Cor");
                txtCorProduto.Focus();
                validacaoTexto = false;
            }
            else if (txtPrecoProduto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe o Preço");
                txtPrecoProduto.Focus();
                validacaoTexto = false;
            }
            else
            {
                validacaoTexto = true;
            }


            return validacaoTexto;
        }

       
    }
}