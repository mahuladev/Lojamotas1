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

namespace LojaMotas.Funcionario
{
    public partial class Faturar : Form
    {
        Cliente cliente = new Cliente();
        public Faturar()
        {
            InitializeComponent();


        }

        private void Faturar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (ValidarCampos()) 
            {
                cliente.RegistrarCliente(txtNome.Text,txtTelefone.Text,txtBilhete.Text,txtEndereco.Text);

                LimparCampos();
            }
        }

        private bool ValidarCampos()
        {
            bool retorno;

            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório");
                txtNome.Focus();
                retorno = false;
            }
            if (txtTelefone.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório");
                retorno = false;
                txtTelefone.Focus();
            }
            if (txtBilhete.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório");
                retorno = false;
                txtBilhete.Focus();
            }
            if (txtEndereco.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório");
                retorno = false;
                txtEndereco.Focus();
            }
            else
            {
                retorno = true;
            }

            return retorno;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtBilhete.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
        }
    }
}
