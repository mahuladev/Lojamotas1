namespace LojaMotas
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlLogin = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            lblLogin = new Label();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            lblEmail = new Label();
            label1 = new Label();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            ilLogin = new ImageList(components);
            btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            lklEsqueciSenha = new LinkLabel();
            lblImagemUsuario = new Label();
            label2 = new Label();
            lklCriarConta = new LinkLabel();
            btnSair = new Button();
            lblMensagem2 = new Label();
            lblMensagem = new Label();
            lblMensagemRestante = new Label();
            timerLogin = new System.Windows.Forms.Timer(components);
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.FromArgb(0, 64, 64);
            pnlLogin.BorderColor = Color.Yellow;
            pnlLogin.Controls.Add(pictureBox1);
            pnlLogin.Controls.Add(label4);
            pnlLogin.Controls.Add(label3);
            pnlLogin.CustomBorderColor = Color.Gray;
            pnlLogin.CustomizableEdges = customizableEdges1;
            pnlLogin.Dock = DockStyle.Left;
            pnlLogin.FillColor = Color.RosyBrown;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlLogin.Size = new Size(466, 510);
            pnlLogin.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.motorcycle_8316052_640;
            pictureBox1.Location = new Point(107, 275);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cooper Black", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(433, 85);
            label4.TabIndex = 13;
            label4.Text = "SEJA BEM-VINDO A:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(47, 205);
            label3.Name = "label3";
            label3.Size = new Size(330, 57);
            label3.TabIndex = 0;
            label3.Text = "BALDEX";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Century Schoolbook", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(604, 34);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(151, 39);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.BorderColor = Color.Black;
            txtEmail.BorderRadius = 6;
            txtEmail.CustomizableEdges = customizableEdges3;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Black;
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(563, 151);
            txtEmail.MaxLength = 150;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "Email";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtEmail.Size = new Size(258, 29);
            txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(563, 124);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(82, 18);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Usuário";
            lblEmail.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(563, 205);
            label1.Name = "label1";
            label1.Size = new Size(82, 18);
            label1.TabIndex = 4;
            label1.Text = "Senha";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtSenha
            // 
            txtSenha.BorderColor = Color.Black;
            txtSenha.BorderRadius = 6;
            txtSenha.CustomizableEdges = customizableEdges5;
            txtSenha.DefaultText = "";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.Black;
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(563, 232);
            txtSenha.MaxLength = 150;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSenha.Size = new Size(258, 30);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // ilLogin
            // 
            ilLogin.ColorDepth = ColorDepth.Depth32Bit;
            ilLogin.ImageStream = (ImageListStreamer)resources.GetObject("ilLogin.ImageStream");
            ilLogin.TransparentColor = Color.Transparent;
            ilLogin.Images.SetKeyName(0, "Male User.png");
            ilLogin.Images.SetKeyName(1, "Email.png");
            ilLogin.Images.SetKeyName(2, "round user icon.png");
            ilLogin.Images.SetKeyName(3, "Password.png");
            ilLogin.Images.SetKeyName(4, "Password1.png");
            ilLogin.Images.SetKeyName(5, "Passwordl.png");
            ilLogin.Images.SetKeyName(6, "cross_082449.png");
            ilLogin.Images.SetKeyName(7, "Close Window.png");
            ilLogin.Images.SetKeyName(8, "KeyTrans+arent.png");
            ilLogin.Images.SetKeyName(9, "Key.png");
            ilLogin.Images.SetKeyName(10, "KeyBW.png");
            ilLogin.Images.SetKeyName(11, "KeyYellow.png");
            // 
            // btnEntrar
            // 
            btnEntrar.Animated = true;
            btnEntrar.BackColor = Color.Transparent;
            btnEntrar.BorderColor = Color.Violet;
            btnEntrar.BorderRadius = 16;
            btnEntrar.BorderThickness = 1;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.CustomBorderColor = Color.Silver;
            btnEntrar.CustomizableEdges = customizableEdges7;
            btnEntrar.DisabledState.BorderColor = Color.DarkGray;
            btnEntrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEntrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEntrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEntrar.FillColor = Color.AliceBlue;
            btnEntrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.FromArgb(64, 64, 64);
            btnEntrar.Location = new Point(601, 344);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnEntrar.Size = new Size(180, 45);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Entrar";
            btnEntrar.Click += btnEntrar_Click;
            btnEntrar.MouseDown += btnEntrar_MouseDown;
            // 
            // lklEsqueciSenha
            // 
            lklEsqueciSenha.BackColor = Color.Transparent;
            lklEsqueciSenha.LinkColor = Color.White;
            lklEsqueciSenha.Location = new Point(632, 289);
            lklEsqueciSenha.Name = "lklEsqueciSenha";
            lklEsqueciSenha.Size = new Size(123, 26);
            lklEsqueciSenha.TabIndex = 8;
            lklEsqueciSenha.TabStop = true;
            lklEsqueciSenha.Text = "Esqueci a senha";
            lklEsqueciSenha.TextAlign = ContentAlignment.MiddleCenter;
            lklEsqueciSenha.VisitedLinkColor = Color.FromArgb(192, 192, 0);
            lklEsqueciSenha.LinkClicked += lklEsqueciSenha_LinkClicked;
            // 
            // lblImagemUsuario
            // 
            lblImagemUsuario.BackColor = Color.Transparent;
            lblImagemUsuario.ForeColor = Color.FromArgb(255, 128, 128);
            lblImagemUsuario.ImageKey = "round user icon.png";
            lblImagemUsuario.ImageList = ilLogin;
            lblImagemUsuario.Location = new Point(519, 151);
            lblImagemUsuario.Name = "lblImagemUsuario";
            lblImagemUsuario.Size = new Size(38, 27);
            lblImagemUsuario.TabIndex = 11;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.ImageKey = "KeyBW.png";
            label2.ImageList = ilLogin;
            label2.Location = new Point(519, 232);
            label2.Name = "label2";
            label2.Size = new Size(38, 27);
            label2.TabIndex = 12;
            // 
            // lklCriarConta
            // 
            lklCriarConta.BackColor = Color.Transparent;
            lklCriarConta.LinkColor = Color.White;
            lklCriarConta.Location = new Point(632, 450);
            lklCriarConta.Name = "lklCriarConta";
            lklCriarConta.Size = new Size(123, 26);
            lklCriarConta.TabIndex = 14;
            lklCriarConta.TabStop = true;
            lklCriarConta.Text = "Criar uma conta";
            lklCriarConta.TextAlign = ContentAlignment.MiddleCenter;
            lklCriarConta.VisitedLinkColor = Color.FromArgb(192, 192, 0);
            lklCriarConta.LinkClicked += lklCriarConta_LinkClicked;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.ForeColor = Color.White;
            btnSair.ImageKey = "Close Window.png";
            btnSair.ImageList = ilLogin;
            btnSair.Location = new Point(859, -1);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(27, 32);
            btnSair.TabIndex = 0;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // lblMensagem2
            // 
            lblMensagem2.ForeColor = Color.FromArgb(255, 192, 128);
            lblMensagem2.Location = new Point(563, 265);
            lblMensagem2.Name = "lblMensagem2";
            lblMensagem2.Size = new Size(192, 15);
            lblMensagem2.TabIndex = 16;
            lblMensagem2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMensagem
            // 
            lblMensagem.ForeColor = Color.FromArgb(255, 192, 128);
            lblMensagem.Location = new Point(563, 183);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(192, 15);
            lblMensagem.TabIndex = 17;
            lblMensagem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMensagemRestante
            // 
            lblMensagemRestante.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensagemRestante.ForeColor = Color.FromArgb(255, 192, 128);
            lblMensagemRestante.Location = new Point(549, 409);
            lblMensagemRestante.Name = "lblMensagemRestante";
            lblMensagemRestante.Size = new Size(302, 41);
            lblMensagemRestante.TabIndex = 18;
            lblMensagemRestante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerLogin
            // 
            timerLogin.Interval = 1000;
            timerLogin.Tick += timerLogin_Tick;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(887, 510);
            Controls.Add(lblMensagemRestante);
            Controls.Add(lblMensagem);
            Controls.Add(lblMensagem2);
            Controls.Add(btnSair);
            Controls.Add(lklCriarConta);
            Controls.Add(label2);
            Controls.Add(lblImagemUsuario);
            Controls.Add(lklEsqueciSenha);
            Controls.Add(btnEntrar);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblLogin);
            Controls.Add(pnlLogin);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Login_Load;
            pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlLogin;
        private Label lblLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Label lblEmail;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private ImageList ilLogin;
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private LinkLabel lklEsqueciSenha;
        private Label lblImagemUsuario;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel lklCriarConta;
        private Button btnSair;
        private Label lblMensagem2;
        private Label lblMensagem;
        private Label lblMensagemRestante;
        private System.Windows.Forms.Timer timerLogin;
        private PictureBox pictureBox1;
    }
}
