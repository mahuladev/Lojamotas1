using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LojaMotas.Model
{
    public class Email
    {
        public static bool ValidarEmail(string email)
        {
            try
            {
                var enderecoEmail = new System.Net.Mail.MailAddress(email);

                return enderecoEmail.Address == email;
            }
            catch 
            {
                return false;
            }
        }

        public static void EnviarEmail(string destinatario, string assunto, string mensagem, Control mensagemAguarde = null, Control botao = null)
        {
            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.Host = "smtp@gmail.com";

                smtp.EnableSsl = true;

                smtp.Credentials = new NetworkCredential("mahulasolutions@gmail.com", "uock rcep jsyz pcee");

                using (MailMessage msg = new MailMessage())
                {
                    msg.From = new MailAddress("mahulasolutions@gmail.com", "Mahula Solutions");

                    msg.To.Add(destinatario);

                    msg.Subject = assunto;

                    msg.Body = mensagem;

                    try
                    {

                        if (mensagemAguarde != null || botao != null)
                        {
                            mensagemAguarde.Text = "Aguarde enviando email...";
                            botao.Enabled = false;
                            botao.Cursor = Cursors.WaitCursor;
                            Application.DoEvents();
                        }
                        smtp.Send(msg);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao enviar mensagem" + ex.Message);
                    }


                    if (mensagemAguarde != null)
                    {
                        mensagemAguarde.Visible = false;
                        botao.Enabled = true;
                        botao.Cursor = Cursors.Default;
                    }
                }

            }
        }


        private void ChaveAleatoria()
        {

        }

    }
}
