namespace LojaMotas
{
    partial class EsqueceuSenha
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtEmailRecuperar = new Guna.UI2.WinForms.Guna2TextBox();
            btnEnviarCodigo = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            tmContador = new System.Windows.Forms.Timer(components);
            lblVoltar = new Label();
            label3 = new Label();
            lblContagem = new Label();
            pnlEnviarCodigo = new Panel();
            lblAguarde = new Label();
            lblCampoObrigatorio = new Label();
            pnlValidar = new Panel();
            pnlValidarCodigo = new Label();
            txtInserirCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            btnValidar = new Guna.UI2.WinForms.Guna2Button();
            pnlEnviarCodigo.SuspendLayout();
            pnlValidar.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmailRecuperar
            // 
            txtEmailRecuperar.BorderColor = Color.Black;
            txtEmailRecuperar.BorderRadius = 10;
            txtEmailRecuperar.CustomizableEdges = customizableEdges1;
            txtEmailRecuperar.DefaultText = "";
            txtEmailRecuperar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmailRecuperar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmailRecuperar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmailRecuperar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmailRecuperar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmailRecuperar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailRecuperar.ForeColor = Color.Black;
            txtEmailRecuperar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmailRecuperar.Location = new Point(69, 100);
            txtEmailRecuperar.Name = "txtEmailRecuperar";
            txtEmailRecuperar.PasswordChar = '\0';
            txtEmailRecuperar.PlaceholderText = "";
            txtEmailRecuperar.SelectedText = "";
            txtEmailRecuperar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtEmailRecuperar.Size = new Size(301, 41);
            txtEmailRecuperar.TabIndex = 1;
            txtEmailRecuperar.TextAlign = HorizontalAlignment.Center;
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.BorderColor = Color.Plum;
            btnEnviarCodigo.BorderRadius = 9;
            btnEnviarCodigo.BorderThickness = 1;
            btnEnviarCodigo.CustomizableEdges = customizableEdges3;
            btnEnviarCodigo.DisabledState.BorderColor = Color.DarkGray;
            btnEnviarCodigo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEnviarCodigo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEnviarCodigo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEnviarCodigo.FillColor = Color.SlateBlue;
            btnEnviarCodigo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviarCodigo.ForeColor = Color.White;
            btnEnviarCodigo.Location = new Point(137, 200);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEnviarCodigo.Size = new Size(165, 45);
            btnEnviarCodigo.TabIndex = 2;
            btnEnviarCodigo.Text = "Enviar Código";
            btnEnviarCodigo.Click += btnEnviarCodigo_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 27);
            label2.Name = "label2";
            label2.Size = new Size(379, 46);
            label2.TabIndex = 3;
            label2.Text = "Digite o seu email";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tmContador
            // 
            tmContador.Interval = 1000;
            tmContador.Tick += tmContador_Tick;
            // 
            // lblVoltar
            // 
            lblVoltar.AutoSize = true;
            lblVoltar.Cursor = Cursors.Hand;
            lblVoltar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVoltar.ForeColor = Color.White;
            lblVoltar.Location = new Point(37, 528);
            lblVoltar.Name = "lblVoltar";
            lblVoltar.Size = new Size(53, 20);
            lblVoltar.TabIndex = 6;
            lblVoltar.Text = "Voltar";
            lblVoltar.Click += lblVoltar_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(82, 57);
            label3.Name = "label3";
            label3.Size = new Size(433, 46);
            label3.TabIndex = 7;
            label3.Text = "Recuperação De Senha";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblContagem
            // 
            lblContagem.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContagem.ForeColor = Color.FromArgb(255, 192, 128);
            lblContagem.Location = new Point(179, 475);
            lblContagem.Name = "lblContagem";
            lblContagem.Size = new Size(238, 27);
            lblContagem.TabIndex = 5;
            lblContagem.TextAlign = ContentAlignment.MiddleCenter;
            lblContagem.Visible = false;
            // 
            // pnlEnviarCodigo
            // 
            pnlEnviarCodigo.Controls.Add(lblAguarde);
            pnlEnviarCodigo.Controls.Add(lblCampoObrigatorio);
            pnlEnviarCodigo.Controls.Add(label2);
            pnlEnviarCodigo.Controls.Add(txtEmailRecuperar);
            pnlEnviarCodigo.Controls.Add(btnEnviarCodigo);
            pnlEnviarCodigo.Location = new Point(82, 122);
            pnlEnviarCodigo.Name = "pnlEnviarCodigo";
            pnlEnviarCodigo.Size = new Size(433, 323);
            pnlEnviarCodigo.TabIndex = 8;
            // 
            // lblAguarde
            // 
            lblAguarde.ForeColor = Color.FromArgb(255, 192, 128);
            lblAguarde.Location = new Point(137, 248);
            lblAguarde.Name = "lblAguarde";
            lblAguarde.Size = new Size(165, 15);
            lblAguarde.TabIndex = 19;
            lblAguarde.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCampoObrigatorio
            // 
            lblCampoObrigatorio.ForeColor = Color.FromArgb(255, 192, 128);
            lblCampoObrigatorio.Location = new Point(69, 144);
            lblCampoObrigatorio.Name = "lblCampoObrigatorio";
            lblCampoObrigatorio.Size = new Size(192, 15);
            lblCampoObrigatorio.TabIndex = 18;
            lblCampoObrigatorio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlValidar
            // 
            pnlValidar.Controls.Add(pnlValidarCodigo);
            pnlValidar.Controls.Add(txtInserirCodigo);
            pnlValidar.Controls.Add(btnValidar);
            pnlValidar.Location = new Point(82, 119);
            pnlValidar.Name = "pnlValidar";
            pnlValidar.Size = new Size(433, 323);
            pnlValidar.TabIndex = 9;
            // 
            // pnlValidarCodigo
            // 
            pnlValidarCodigo.BackColor = Color.Transparent;
            pnlValidarCodigo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlValidarCodigo.ForeColor = Color.White;
            pnlValidarCodigo.Location = new Point(30, 27);
            pnlValidarCodigo.Name = "pnlValidarCodigo";
            pnlValidarCodigo.Size = new Size(379, 46);
            pnlValidarCodigo.TabIndex = 3;
            pnlValidarCodigo.Text = "Digite o código de confirmação";
            pnlValidarCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtInserirCodigo
            // 
            txtInserirCodigo.BorderColor = Color.Black;
            txtInserirCodigo.BorderRadius = 10;
            txtInserirCodigo.CustomizableEdges = customizableEdges5;
            txtInserirCodigo.DefaultText = "";
            txtInserirCodigo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtInserirCodigo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtInserirCodigo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtInserirCodigo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtInserirCodigo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtInserirCodigo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInserirCodigo.ForeColor = Color.Black;
            txtInserirCodigo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtInserirCodigo.Location = new Point(69, 100);
            txtInserirCodigo.Name = "txtInserirCodigo";
            txtInserirCodigo.PasswordChar = '\0';
            txtInserirCodigo.PlaceholderText = "";
            txtInserirCodigo.SelectedText = "";
            txtInserirCodigo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtInserirCodigo.Size = new Size(301, 41);
            txtInserirCodigo.TabIndex = 1;
            txtInserirCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnValidar
            // 
            btnValidar.BorderColor = Color.Purple;
            btnValidar.BorderRadius = 9;
            btnValidar.BorderThickness = 1;
            btnValidar.CustomizableEdges = customizableEdges7;
            btnValidar.DisabledState.BorderColor = Color.DarkGray;
            btnValidar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnValidar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnValidar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnValidar.FillColor = Color.PaleVioletRed;
            btnValidar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnValidar.ForeColor = Color.White;
            btnValidar.Location = new Point(137, 200);
            btnValidar.Name = "btnValidar";
            btnValidar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnValidar.Size = new Size(165, 45);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar Código";
            btnValidar.Click += btnValidar_Click;
            // 
            // EsqueceuSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(618, 567);
            Controls.Add(label3);
            Controls.Add(lblVoltar);
            Controls.Add(lblContagem);
            Controls.Add(pnlEnviarCodigo);
            Controls.Add(pnlValidar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EsqueceuSenha";
            StartPosition = FormStartPosition.CenterScreen;
            pnlEnviarCodigo.ResumeLayout(false);
            pnlValidar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtEmailRecuperar;
        private Guna.UI2.WinForms.Guna2Button btnEnviarCodigo;
        private Label label2;
        private System.Windows.Forms.Timer tmContador;
        private Label lblVoltar;
        private Label label3;
        private Label lblContagem;
        private Panel pnlEnviarCodigo;
        private Panel pnlValidar;
        private Label pnlValidarCodigo;
        private Guna.UI2.WinForms.Guna2TextBox txtInserirCodigo;
        private Guna.UI2.WinForms.Guna2Button btnValidar;
        private Label lblCampoObrigatorio;
        private Label lblAguarde;
    }
}