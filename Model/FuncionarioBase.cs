using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LojaMotas.Model
{
    public sealed class FuncionarioBase : Conexao
    {
        public string foto;

        public void CadastrarFuncionario(string nome,string email,string morada,string telefone,string senha,string bilhete,string dataDeNascimento,string cargo) 
        {
            try
            {
                AbrirConexao();

                string senhaHash = GerarHash(senha);

                sql = "INSERT INTO funcionario (nome,email,morada,telefone,senha,bilhete,nascimento,foto,cargo)" +
                    " VALUES (@nome,@email,@morada,@telefone,@senha,@bilhete,@nascimento,@foto,@cargo)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao)) 
                { 

                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@morada", morada);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@senha", senhaHash);
                    cmd.Parameters.AddWithValue("@bilhete", bilhete);
                    cmd.Parameters.AddWithValue("@nascimento", dataDeNascimento);
                    cmd.Parameters.AddWithValue("@foto", EnviarFoto());
                    cmd.Parameters.AddWithValue("@cargo", cargo);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Funcionário salvo com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("0correu um erro" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
            
        }
        //Lança os dados na tabela
        public void LerDados(DataGridView dgv) 
        {
            try
            {
                AbrirConexao();

                sql = "SELECT * FROM funcionario ORDER BY Nome ASC";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgv.DataSource = dt;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("ocorreu um erro" + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void ApagarDados()
        {
            var resposta = MessageBox.Show("Deseja realmente apagar?", "Apagar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                AbrirConexao();

                sql = "DELETE FROM funcionario WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }

                FecharConexao();

                MessageBox.Show("Excluido com sucesso", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void BuscarDados(string buscar,DataGridView dgv)
        {
            
            try
            {
                AbrirConexao();

                sql = "SELECT * FROM funcionario WHERE nome LIKE @nome ORDER BY nome ASC"; //LIKE Facilita na busca por aproximação

                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {

                    cmd.Parameters.AddWithValue("@nome", buscar + "%");

                    //cmd.ExecuteNonQuery();

                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

        }
        private string GerarHash(string senha)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(senha, BCrypt.Net.BCrypt.GenerateSalt(12));
            return hash;
        }

        private byte[] EnviarFoto()
        {
            byte[] bytes = null;

            try
            {
                FileStream fileStream = new FileStream(foto, FileMode.Open, FileAccess.Read);

                var binaryReader = new BinaryReader(fileStream);

                bytes = binaryReader.ReadBytes((int)fileStream.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar foto " + ex.Message);
            }

            return bytes;
        }
    }
}
