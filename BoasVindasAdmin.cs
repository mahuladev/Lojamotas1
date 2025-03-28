using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LojaMotas.Gerente;

namespace LojaMotas
{
    public partial class BoasVindasAdmin : Form
    {
        int contador;
        public BoasVindasAdmin()
        {
            InitializeComponent();
        }

        private void BoasVindasAdmin_Load(object sender, EventArgs e)
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

        private void tmrBoasVindas_Tick(object sender, EventArgs e)
        {
            if (contador < 20)
            {
                contador++;

                pbContador.Start();
            }
            else
            {
                pbContador.Stop();

                PararTimer();

                var telaPrincipalGerente = new TelaPrincipalGerente();

                telaPrincipalGerente.Show();

                this.Hide();
            }
        }

        private void PararTimer()
        {
            tmrBoasVindas.Stop();
        }
    }
}
