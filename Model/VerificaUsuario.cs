using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LojaMotas.Model
{
    public sealed class VerificaUsuario:Conexao
    {
        public bool FuncionarioLogin(string email, string senha)
        {
            AbrirConexao();

            sql = "SELECT senha FROM funcionario WHERE email=@email";

            using (MySqlCommand cmd = new MySqlCommand(sql, conexao)) { 

                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    string hashArmazenado = resultado.ToString();

                    return VerificarSenha(senha, hashArmazenado);
                }
            }

            MessageBox.Show("Login feito com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FecharConexao();

            return false;
        }

        public bool LoginAdmin(string email, string senha)
        {
            AbrirConexao();

            sql = "SELECT senha FROM usuario WHERE email=@email";
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                    cmd.Parameters.AddWithValue("@email", email);
                    //cmd.Parameters.AddWithValue("@senha", senha);

                    object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    string hashArmazenado = resultado.ToString();

                    return VerificarSenha(senha, hashArmazenado);
                }
            }

            MessageBox.Show("Login feito com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FecharConexao();

            return false;
        }

        //Verificar sehha pelo hash do banco 
        private bool VerificarSenha(string senha, string hashArmazenado)
        {
            //Verificar se a senha fornecida corresponde ao hash armazenado 
            return BCrypt.Net.BCrypt.Verify(senha, hashArmazenado);
        }
    }
}
