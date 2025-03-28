using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LojaMotas
{
    public abstract class Conexao
    {
        public string fonteDados = "SERVER = localhost; DATABASE = motos; UID = root;PWD =;";

        public MySqlConnection conexao = null;

        public string sql = "";

        public int id;

        //Metódo para abrir e fechar conexão

        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(fonteDados);

                conexao.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }

        }

        public void FecharConexao()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
