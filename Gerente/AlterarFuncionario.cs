using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaMotas.Gerente
{
    public partial class AlterarFuncionario : Form
    {
        //propriedade que armazena o valor enviado do Lista de Cadastro
        public string TextBoxValue { get; set; }
        public string TextBoxValue1 { get; set; }
        public string TextBoxValue2 { get; set; }
        public string TextBoxValue3 { get; set; }
        public string TextBoxValue4 { get; set; }
        public string TextBoxValue5 { get; set; }


        public AlterarFuncionario()
        {
            InitializeComponent();
        }

        private void AlterarFuncionario_Load(object sender, EventArgs e)
        {
            txtNomeAlterar.Text = TextBoxValue;
            txtBilheteAlterar.Text = TextBoxValue1;
            txtEmailAlterar.Text = TextBoxValue2;
            txtMoradaAlterar.Text = TextBoxValue3;
            txtTelefoneAlterar.Text = TextBoxValue4;
            txtSenhaAlterar.Text = TextBoxValue5;

        }

        private void btncancelarAlterar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
