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
using Mysqlx;

namespace LojaMotas.Gerente
{



    public partial class ListaDeFuncionario : Form
    {
        FuncionarioBase funcionario = new FuncionarioBase();
        private string id;
        public ListaDeFuncionario()
        {
            InitializeComponent();
        }

        private void ListaDeFuncionario_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        public void FormatarGrid()
        {
            dgvListaDeFuncionario.Columns[0].HeaderText = "Código";
            dgvListaDeFuncionario.Columns[1].HeaderText = "Nome";
            dgvListaDeFuncionario.Columns[2].HeaderText = "Email";
            dgvListaDeFuncionario.Columns[3].HeaderText = "Morada";
            dgvListaDeFuncionario.Columns[4].HeaderText = "Telefone";
            dgvListaDeFuncionario.Columns[5].HeaderText = "Senha";
            dgvListaDeFuncionario.Columns[6].HeaderText = "Bilhete";
            //dgvListaDeFuncionario.Columns[7].HeaderText = "Cargo";
            dgvListaDeFuncionario.Columns[7].HeaderText = "Data de Nascimento";
            dgvListaDeFuncionario.Columns[8].HeaderText = "Foto";

            dgvListaDeFuncionario.Columns[0].Visible = false;
            dgvListaDeFuncionario.Columns[5].Visible = false;
            dgvListaDeFuncionario.Columns[8].Visible = false;
        }
        public void ListarGrid()
        {
            funcionario.LerDados(dgvListaDeFuncionario);

            FormatarGrid();
        }

        private void btnAlterarFuncionario_Click(object sender, EventArgs e)
        {
            if (dgvListaDeFuncionario.SelectedCells.Count > 0)
            {
                //Pega o valor da célula selecionada
                var itemSelecionada = dgvListaDeFuncionario.SelectedCells[1].Value.ToString();
                var itemSelecionada1 = dgvListaDeFuncionario.SelectedCells[2].Value.ToString();
                var itemSelecionada2 = dgvListaDeFuncionario.SelectedCells[3].Value.ToString();
                var itemSelecionada3 = dgvListaDeFuncionario.SelectedCells[4].Value.ToString();
                var itemSelecionada4 = dgvListaDeFuncionario.SelectedCells[5].Value.ToString();
                var itemSelecionada5 = dgvListaDeFuncionario.SelectedCells[6].Value.ToString();
                var itemSelecionada6 = dgvListaDeFuncionario.SelectedCells[8].Value.ToString();


                //Nova instância do form Alterar 
                AlterarFuncionario alterarFuncionario = new AlterarFuncionario();
                alterarFuncionario.TextBoxValue = itemSelecionada;
                alterarFuncionario.TextBoxValue1 = itemSelecionada;
                alterarFuncionario.TextBoxValue2 = itemSelecionada;
                alterarFuncionario.TextBoxValue3 = itemSelecionada;
                alterarFuncionario.TextBoxValue4 = itemSelecionada;
                alterarFuncionario.TextBoxValue5 = itemSelecionada;
                alterarFuncionario.Show();

            }
        }

        private void btnApagarFuncionario_Click(object sender, EventArgs e)
        {
            funcionario.ApagarDados();
            ListarGrid();
        }
        private void dgvListaDeFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvListaDeFuncionario.CurrentRow.Cells[0].Value.ToString();
        }


        //Metódo para buscar registro na tabela
        private void Buscar()
        {
            funcionario.BuscarDados(txtBuscarFuncionario.Text, dgvListaDeFuncionario);
            FormatarGrid();
        }
        private void txtBuscarFuncionario_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dgvListaDeFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

