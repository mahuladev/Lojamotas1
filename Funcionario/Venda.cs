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

namespace LojaMotas.Funcionario
{
    public partial class Venda : Form
    {
        MySqlCommand cmd;

        public Venda()
        {
            InitializeComponent();
        }

        public void ListarGrid()
        {
            FormatarGrid();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            var faturar = new Faturar();

            faturar.Show();

            Desabilitar();
        }
        private void btnApagarItens_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void Desabilitar()
        {
            btnFacturar.Enabled = false;
        }

        private void LimparCampos()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtCor.Clear();
            txtPreco.Clear();
        }

        public void FormatarGrid()
        {
            dgvListaProduto.Columns[0].HeaderText = "Código";
            dgvListaProduto.Columns[1].HeaderText = "Marca";
            dgvListaProduto.Columns[2].HeaderText = "Modelo";
            dgvListaProduto.Columns[3].HeaderText = "Cor";
            dgvListaProduto.Columns[4].HeaderText = "Preço";
            dgvListaProduto.Columns[5].HeaderText = "Quantidade";

            dgvListaProduto.Columns[0].Visible = false;
        }
       
        private void Venda_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        //Metódo para ValidarTextos

        /* private bool ValidarTexto()
        {
            bool validacaoTexto;

            if(txtMarca.Text.Trim() == "")
            {
                MessageBox.Show("Informe a Marca");
                txtMarca.Focus();
                validacaoTexto = false;
            }
            else if (txtModelo.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Modelo");
                txtModelo.Focus();
                validacaoTexto = false;
            }
            else if (txtCor.Text.Trim() == "")
            {
                MessageBox.Show("Informe a Cor");
                txtCor.Focus();
                validacaoTexto = false;
            }
            else if (txtPreco.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Preço");
                txtPreco.Focus();
                validacaoTexto = false;
            }
            else
            {
                validacaoTexto = true;
            }

            return validacaoTexto;
        }*/
    }
}
