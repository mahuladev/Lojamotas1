using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LojaMotas.Funcionario;

namespace LojaMotas
{
    public partial class BoasVindas : Form
    {
        int contador;
        public BoasVindas()
        {
            InitializeComponent();
        }

        private void BoasVindas_Load(object sender, EventArgs e)
        {
            int hora = DateTime.Now.Hour;

            if (hora >= 6 && hora <= 12)
            {
                lblSaudacao.Text = "BOM DIA";
            }
            else if (hora >= 13 && hora <= 17)
            {
                lblSaudacao.Text = "BOA TARDE";
            }
            else
            {
                lblSaudacao.Text = "BOA NOITE";
            }
        }

        private void tmBoasVindas_Tick(object sender, EventArgs e)
        {

            if (contador < 20)
            {
                contador++;

                pgbProcessador.Start();
            }
            else
            {
                pgbProcessador.Stop();

                FechaTimer();

                var telaPrincipal = new TelaPrincipal();

                telaPrincipal.Show();

                this.Hide();
            }
        }

        private void FechaTimer()
        {
            tmBoasVindas.Stop();
        }

        private void lblBoasVindas_Click(object sender, EventArgs e)
        {

        }
    }
}
