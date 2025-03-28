using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LojaMotas.Model
{
    public class CriarAdmin:Conexao
    {
        public CriarAdmin() { }

        public void InserirDados(string email,string senha)
        {
            string senhaHash = GerarHash(senha);

            sql = "INSERT INTO usuario (email,senha) VALUES (@email,@senha)";

            using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senhaHash);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Adicionado com sucesso");

        }

        private string GerarHash(string senha)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(senha, BCrypt.Net.BCrypt.GenerateSalt(12));
            return hash;
        }
    }
}
