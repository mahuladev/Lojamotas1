using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LojaMotas.Model
{
    public class Cliente:Conexao
    {
    public void RegistrarCliente(string nome, string telefone, string bilhete, string endereco)
    {
            try
            {
                AbrirConexao();

                sql = "INSERT INTO cliente (nome,telefone,bilhete,endereco) VALUES(@nome,@telefone,bilhete,@endereco)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@bilhete", bilhete);
                    cmd.Parameters.AddWithValue("@endereco", endereco);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar cliente" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
