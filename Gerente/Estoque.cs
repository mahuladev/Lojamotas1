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


namespace LojaMotas.Gerente
{
    public partial class Estoque : Form
    {
        EstoqueProduto estoque = new EstoqueProduto();
        public Estoque()
        {
            InitializeComponent();
        }
        private void ListarGrid()
        {
            estoque.LerDados(dgvListaDeProduto);

            FormatarGrid();
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
        private void Estoque_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            if (ValidarTexto())
            {
                estoque.InserirDados(txtMarca.Text, txtModelo.Text, txtCor.Text, txtPreco.Text, txtQuantidade.Text);

                LimparCampos();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            estoque.Apagar();

            ListarGrid();

            btnAdicionarProduto.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgvListaDeProduto.SelectedRows.Count > 0)
            {
                var coluna = dgvListaDeProduto.SelectedRows[0];

                txtMarca.Text = coluna.Cells["Marca"].Value.ToString();

                txtModelo.Text = coluna.Cells["Modelo"].Value.ToString();

                txtCor.Text = coluna.Cells["Cor"].Value.ToString();

                txtPreco.Text = coluna.Cells["Preço"].Value.ToString();

                txtQuantidade.Text = coluna.Cells["Quantidade"].Value.ToString();
            }

            estoque.Actualizar(txtMarca.Text,txtModelo.Text,txtCor.Text,txtPreco.Text,txtQuantidade.Text);
        }

        private bool ValidarTexto()
        {
            bool validacaoTexto;

            if (txtMarca.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe a Marca");
                txtMarca.Focus();
                validacaoTexto = false;
            }
            else if (txtModelo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe o Modelo");
                txtModelo.Focus();
                validacaoTexto = false;
            }
            else if (txtCor.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe a Cor");
                txtCor.Focus();
                validacaoTexto = false;
            }
            else if (txtPreco.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe o Preço");
                txtPreco.Focus();
                validacaoTexto = false;
            }
            else if (txtQuantidade.Text.Trim() == string.Empty)
            {
                MessageBox.Show("informe a quantidade");
                txtQuantidade.Focus();
                validacaoTexto = false;
            }
            else
            {
                validacaoTexto = true;
            }


            return validacaoTexto;
        }

        private void LimparCampos()
        {
            txtCor.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
        }


        private void dgvListaDeProduto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnAdicionarProduto.Enabled = false;

            string id = dgvListaDeProduto.CurrentRow.Cells[0].Value.ToString();
            txtMarca.Text = dgvListaDeProduto.CurrentRow.Cells[1].Value.ToString();
            txtModelo.Text = dgvListaDeProduto.CurrentRow.Cells[2].Value.ToString();
            txtCor.Text = dgvListaDeProduto.CurrentRow.Cells[3].Value.ToString();
            txtPreco.Text = dgvListaDeProduto.CurrentRow.Cells[4].Value.ToString();
            txtQuantidade.Text = dgvListaDeProduto.CurrentRow.Cells[5].Value.ToString();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            estoque.Buscar(txtPesquisar.Text,dgvListaDeProduto);

            FormatarGrid();
        }

        /*private void Alterar()
        {
            conexao.AbrirConexao();

            sql = "UPTADE SET produto WHERE id=@id";

            cmd = new MySqlCommand(sql, conexao.conexao);

            cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
            cmd.Parameters.AddWithValue("@marca", txtModelo.Text);
            cmd.Parameters.AddWithValue("@marca", txtCor.Text);
            cmd.Parameters.AddWithValue("@marca", txtPreco.Text);
            cmd.Parameters.AddWithValue("@marca", txtQuantidade.Text);

            cmd.ExecuteNonQuery();
        }*/
    }
}
