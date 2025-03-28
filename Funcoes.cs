using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.ActiveDirectory;
using LojaMotas.Gerente;

namespace LojaMotas
{
    public static class Funcoes
    {
        public static string ChaveAleatoria(int tamanho=6)
        {
            Random random = new Random();

            string codigo = "";

            for (int i = 0; i < tamanho; i++)
            {
                codigo += random.Next(111111, 999999).ToString();
            }

            return codigo;
        }
        
    }
}
