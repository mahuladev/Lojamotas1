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
    public partial class MeuPerfil : Form
    {
        public MeuPerfil()
        {
            InitializeComponent();
        }

        private void MeuPerfil_Load(object sender, EventArgs e)
        {
            BuscarPerfil();
        }

        private void BuscarPerfil()
        {
                   
        }
    }
}
