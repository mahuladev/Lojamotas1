namespace LojaMotas
{
    partial class BoasVindasAdmin
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
            tmrBoasVindas = new System.Windows.Forms.Timer(components);
            pbContador = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            label1 = new Label();
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
            // tmrBoasVindas
            // 
            tmrBoasVindas.Enabled = true;
            tmrBoasVindas.Interval = 300;
            tmrBoasVindas.Tick += tmrBoasVindas_Tick;
            // 
            // pbContador
            // 
            pbContador.Location = new Point(341, 294);
            pbContador.Name = "pbContador";
            pbContador.ShadowDecoration.CustomizableEdges = customizableEdges1;
            pbContador.Size = new Size(105, 103);
            pbContador.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 165);
            label1.Name = "label1";
            label1.Size = new Size(695, 65);
            label1.TabIndex = 2;
            label1.Text = "Seja Bem-Vindo(a)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BoasVindasAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 462);
            Controls.Add(label1);
            Controls.Add(pbContador);
            Controls.Add(lblSaudacao);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(47, 172);
            Name = "BoasVindasAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BoasVindasAdmin";
            Load += BoasVindasAdmin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblSaudacao;
        private System.Windows.Forms.Timer tmrBoasVindas;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator pbContador;
        private Label label1;
    }
}