using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LojaMotas.Model
{
    internal class Produto:Conexao
    {

        public void CadastrarProduto(string marca,string modelo,string cor,string preco,string quantidade)
        {
            try
            {
                AbrirConexao();

                sql = "INSERT INTO produto (marca,modelo,cor,preco,quantidade) VALUES (@marca,@modelo,@cor,@preco,@quantidade)";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@marca", marca);

                cmd.Parameters.AddWithValue("@modelo", modelo);

                cmd.Parameters.AddWithValue("@cor", cor);

                cmd.Parameters.AddWithValue("@preco", preco);

                cmd.Parameters.AddWithValue("@quantidade", quantidade);

                cmd.ExecuteNonQuery();

                //Confirma a adição do novo produto

                MessageBox.Show("Adicionado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar produto" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        
        public void VerProdutos(DataGridView dgv)
        {
            try
            {
                AbrirConexao();

                sql = "SELECT * FROM Produto ORDER BY Marca ASC";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ver produtos" + ex.Message);
                throw;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void ApagarProduto()
        {
            try
            {
                var resposta = MessageBox.Show("Deseja realmente apagar?", "Apagar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    AbrirConexao();

                    sql = "DELETE FROM produto WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);

                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    FecharConexao();

                    MessageBox.Show("Excluido com sucesso", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar produto" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
            
        }

        public void AlterarProduto()
        {

        }
    }
}
