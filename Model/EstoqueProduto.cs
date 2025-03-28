using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LojaMotas.Model
{
    public class EstoqueProduto:Conexao
    {
        MySqlCommand cmd;
        public void InserirDados(string marca,string modelo,string cor,string preco,string quantidade)
        {
            try
            {
                AbrirConexao();

                sql = "INSERT INTO produto (marca,modelo,cor,preco,quantidade) VALUES (@marca,@modelo,@cor,@preco,@quantidade)";

                cmd = new MySqlCommand(sql, conexao);
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
                MessageBox.Show("Erro ao salvar" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void LerDados(DataGridView dgv)
        {
            try
            {
                AbrirConexao();

                sql = "SELECT * FROM produto ORDER BY Marca ASC";

                cmd = new MySqlCommand(sql, conexao);

                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler dados" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
            
            
        }

        public void Actualizar(string marca, string modelo, string cor, string preco, string quantidade)
        {
            try
            {
                AbrirConexao();

                sql = "UPDATE produto SET marca=@marca,modelo=@modelo,preco=@preco,quantidade=@quantidade WHERE id=@id";

                cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@cor", cor);
                cmd.Parameters.AddWithValue("@preco", preco);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);

                int colunasAfectadas = cmd.ExecuteNonQuery();

                if (colunasAfectadas > 0)
                {
                    MessageBox.Show("Actualizado com sucesso");

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao actualizar" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Apagar()
        {
            var resposta = MessageBox.Show("Deseja realmente apagar?", "Apagar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                AbrirConexao();

                sql = "DELETE FROM produto WHERE id=@id";

                cmd = new MySqlCommand(sql,conexao);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                FecharConexao();

                MessageBox.Show("Excluido com sucesso", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Buscar(string buscar,DataGridView dgv)
        {
            try
            {
                AbrirConexao();

                sql = "SELECT * FROM produto WHERE marca LIKE @marca ORDER BY marca ASC"; //LIKE Facilita na busca por aproximação

                cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@marca", buscar + "%");

                //cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao buscar produto");
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
