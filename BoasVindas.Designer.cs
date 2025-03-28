namespace LojaMotas
{
    partial class BoasVindas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblSaudacao = new Label();
            lblBoasVindas = new Label();
            pgbProcessador = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            tmBoasVindas = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblSaudacao
            // 
            lblSaudacao.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaudacao.ForeColor = Color.DarkTurquoise;
            lblSaudacao.Location = new Point(62, 49);
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(680, 68);
            lblSaudacao.TabIndex = 0;
            lblSaudacao.Text = "Saudação";
            lblSaudacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBoasVindas.ForeColor = Color.White;
            lblBoasVindas.Location = new Point(47, 172);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(695, 65);
            lblBoasVindas.TabIndex = 1;
            lblBoasVindas.Text = "Seja Bem-Vindo(a)";
            lblBoasVindas.TextAlign = ContentAlignment.MiddleCenter;
            lblBoasVindas.Click += lblBoasVindas_Click;
            // 
            // pgbProcessador
            // 
            pgbProcessador.Location = new Point(341, 294);
            pgbProcessador.Name = "pgbProcessador";
            pgbProcessador.ShadowDecoration.CustomizableEdges = customizableEdges1;
            pgbProcessador.Size = new Size(105, 103);
            pgbProcessador.TabIndex = 2;
            // 
            // tmBoasVindas
            // 
            tmBoasVindas.Enabled = true;
            tmBoasVindas.Interval = 300;
            tmBoasVindas.Tick += tmBoasVindas_Tick;
            // 
            // BoasVindas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 462);
            Controls.Add(pgbProcessador);
            Controls.Add(lblBoasVindas);
            Controls.Add(lblSaudacao);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BoasVindas";
            StartPosition = FormStartPosition.CenterScreen;
            Load += BoasVindas_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblSaudacao;
        private Label lblBoasVindas;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator pgbProcessador;
        private System.Windows.Forms.Timer tmBoasVindas;
    }
}