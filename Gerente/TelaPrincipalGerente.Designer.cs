namespace LojaMotas.Gerente
{
    partial class TelaPrincipalGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalGerente));
            pnlPrincipalGerente = new Panel();
            btnSair = new Button();
            imageList1 = new ImageList(components);
            btnContactos = new Button();
            button4 = new Button();
            btnEstoque = new Button();
            button2 = new Button();
            btnListaDeFuncionarios = new Button();
            btnCadastrarFuncionario = new Button();
            pnlBaixo = new Panel();
            pnlImagemGerente = new Panel();
            imageList2 = new ImageList(components);
            pnlCentroAdministrador = new Panel();
            pictureBox1 = new PictureBox();
            pnlPrincipalGerente.SuspendLayout();
            pnlImagemGerente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlPrincipalGerente
            // 
            pnlPrincipalGerente.BackColor = Color.White;
            pnlPrincipalGerente.Controls.Add(btnSair);
            pnlPrincipalGerente.Controls.Add(btnContactos);
            pnlPrincipalGerente.Controls.Add(button4);
            pnlPrincipalGerente.Controls.Add(btnEstoque);
            pnlPrincipalGerente.Controls.Add(button2);
            pnlPrincipalGerente.Controls.Add(btnListaDeFuncionarios);
            pnlPrincipalGerente.Controls.Add(btnCadastrarFuncionario);
            pnlPrincipalGerente.Controls.Add(pnlBaixo);
            pnlPrincipalGerente.Controls.Add(pnlImagemGerente);
            pnlPrincipalGerente.Dock = DockStyle.Left;
            pnlPrincipalGerente.Location = new Point(0, 0);
            pnlPrincipalGerente.Name = "pnlPrincipalGerente";
            pnlPrincipalGerente.Size = new Size(322, 700);
            pnlPrincipalGerente.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Teal;
            btnSair.Dock = DockStyle.Top;
            btnSair.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.ForeColor = Color.White;
            btnSair.ImageAlign = ContentAlignment.BottomCenter;
            btnSair.ImageKey = "Logout Rounded.png";
            btnSair.ImageList = imageList1;
            btnSair.Location = new Point(0, 489);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(322, 54);
            btnSair.TabIndex = 8;
            btnSair.Text = "SAIR";
            btnSair.TextAlign = ContentAlignment.TopCenter;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Collaborator Male.png");
            imageList1.Images.SetKeyName(1, "Customer.png");
            imageList1.Images.SetKeyName(2, "dashboard screen app.png");
            imageList1.Images.SetKeyName(3, "Email.png");
            imageList1.Images.SetKeyName(4, "Logout Rounded.png");
            imageList1.Images.SetKeyName(5, "Logout.png");
            imageList1.Images.SetKeyName(6, "Profile.png");
            imageList1.Images.SetKeyName(7, "Administrator Male.png");
            imageList1.Images.SetKeyName(8, "Contact.png");
            imageList1.Images.SetKeyName(9, "Contactj.png");
            imageList1.Images.SetKeyName(10, "Contacty.png");
            imageList1.Images.SetKeyName(11, "Control Panel.png");
            imageList1.Images.SetKeyName(12, "communication_assistance_help_support_service_information_icon_230498.png");
            // 
            // btnContactos
            // 
            btnContactos.BackColor = Color.Teal;
            btnContactos.Dock = DockStyle.Top;
            btnContactos.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btnContactos.FlatAppearance.BorderSize = 0;
            btnContactos.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            btnContactos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            btnContactos.FlatStyle = FlatStyle.Flat;
            btnContactos.ForeColor = Color.White;
            btnContactos.ImageAlign = ContentAlignment.BottomCenter;
            btnContactos.ImageKey = "communication_assistance_help_support_service_information_icon_230498.png";
            btnContactos.ImageList = imageList1;
            btnContactos.Location = new Point(0, 435);
            btnContactos.Name = "btnContactos";
            btnContactos.Size = new Size(322, 54);
            btnContactos.TabIndex = 7;
            btnContactos.Text = "CONTACTOS";
            btnContactos.TextAlign = ContentAlignment.TopCenter;
            btnContactos.UseVisualStyleBackColor = false;
            btnContactos.Click += btnContactos_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 381);
            button4.Name = "button4";
            button4.Size = new Size(322, 54);
            button4.TabIndex = 6;
            button4.Text = "CADASTRAR FUNCIONÁRIO";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnEstoque
            // 
            btnEstoque.BackColor = Color.Teal;
            btnEstoque.Dock = DockStyle.Top;
            btnEstoque.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btnEstoque.FlatAppearance.BorderSize = 0;
            btnEstoque.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            btnEstoque.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.ForeColor = Color.White;
            btnEstoque.ImageAlign = ContentAlignment.BottomCenter;
            btnEstoque.ImageKey = "Control Panel.png";
            btnEstoque.ImageList = imageList1;
            btnEstoque.Location = new Point(0, 327);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(322, 54);
            btnEstoque.TabIndex = 5;
            btnEstoque.Text = "ESTOQUE";
            btnEstoque.TextAlign = ContentAlignment.TopCenter;
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.BottomCenter;
            button2.ImageKey = "dashboard screen app.png";
            button2.ImageList = imageList1;
            button2.Location = new Point(0, 273);
            button2.Name = "button2";
            button2.Size = new Size(322, 54);
            button2.TabIndex = 4;
            button2.Text = "RELATÓRIOS";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // btnListaDeFuncionarios
            // 
            btnListaDeFuncionarios.BackColor = Color.Teal;
            btnListaDeFuncionarios.Dock = DockStyle.Top;
            btnListaDeFuncionarios.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btnListaDeFuncionarios.FlatAppearance.BorderSize = 0;
            btnListaDeFuncionarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            btnListaDeFuncionarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            btnListaDeFuncionarios.FlatStyle = FlatStyle.Flat;
            btnListaDeFuncionarios.ForeColor = Color.White;
            btnListaDeFuncionarios.ImageAlign = ContentAlignment.BottomCenter;
            btnListaDeFuncionarios.ImageKey = "Profile.png";
            btnListaDeFuncionarios.ImageList = imageList1;
            btnListaDeFuncionarios.Location = new Point(0, 219);
            btnListaDeFuncionarios.Name = "btnListaDeFuncionarios";
            btnListaDeFuncionarios.Size = new Size(322, 54);
            btnListaDeFuncionarios.TabIndex = 3;
            btnListaDeFuncionarios.Text = "LISTA DE FUNCIONÁRIOS";
            btnListaDeFuncionarios.TextAlign = ContentAlignment.TopCenter;
            btnListaDeFuncionarios.UseVisualStyleBackColor = false;
            btnListaDeFuncionarios.Click += btnListaDeFuncionarios_Click;
            // 
            // btnCadastrarFuncionario
            // 
            btnCadastrarFuncionario.BackColor = Color.Teal;
            btnCadastrarFuncionario.Dock = DockStyle.Top;
            btnCadastrarFuncionario.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btnCadastrarFuncionario.FlatAppearance.BorderSize = 0;
            btnCadastrarFuncionario.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            btnCadastrarFuncionario.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            btnCadastrarFuncionario.FlatStyle = FlatStyle.Flat;
            btnCadastrarFuncionario.ForeColor = Color.White;
            btnCadastrarFuncionario.ImageAlign = ContentAlignment.BottomCenter;
            btnCadastrarFuncionario.ImageKey = "Customer.png";
            btnCadastrarFuncionario.ImageList = imageList1;
            btnCadastrarFuncionario.Location = new Point(0, 165);
            btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            btnCadastrarFuncionario.Size = new Size(322, 54);
            btnCadastrarFuncionario.TabIndex = 2;
            btnCadastrarFuncionario.Text = "CADASTRAR FUNCIONÁRIO";
            btnCadastrarFuncionario.TextAlign = ContentAlignment.TopCenter;
            btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            btnCadastrarFuncionario.Click += btnCadastrarFuncionario_Click;
            // 
            // pnlBaixo
            // 
            pnlBaixo.BackColor = Color.Transparent;
            pnlBaixo.Dock = DockStyle.Bottom;
            pnlBaixo.Location = new Point(0, 535);
            pnlBaixo.Name = "pnlBaixo";
            pnlBaixo.Size = new Size(322, 165);
            pnlBaixo.TabIndex = 1;
            // 
            // pnlImagemGerente
            // 
            pnlImagemGerente.BackColor = Color.Transparent;
            pnlImagemGerente.Controls.Add(pictureBox1);
            pnlImagemGerente.Dock = DockStyle.Top;
            pnlImagemGerente.Location = new Point(0, 0);
            pnlImagemGerente.Name = "pnlImagemGerente";
            pnlImagemGerente.Size = new Size(322, 165);
            pnlImagemGerente.TabIndex = 0;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "Administrator Male.png");
            imageList2.Images.SetKeyName(1, "man-1351317_640.png");
            // 
            // pnlCentroAdministrador
            // 
            pnlCentroAdministrador.Dock = DockStyle.Fill;
            pnlCentroAdministrador.Location = new Point(322, 0);
            pnlCentroAdministrador.Name = "pnlCentroAdministrador";
            pnlCentroAdministrador.Size = new Size(1048, 700);
            pnlCentroAdministrador.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.man_1351317_640;
            pictureBox1.Location = new Point(88, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TelaPrincipalGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(1370, 700);
            Controls.Add(pnlCentroAdministrador);
            Controls.Add(pnlPrincipalGerente);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaPrincipalGerente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipalGerente";
            pnlPrincipalGerente.ResumeLayout(false);
            pnlImagemGerente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipalGerente;
        private Panel pnlCentralGerente;
        private Panel pnlBaixo;
        private Panel pnlImagemGerente;
        private Button btnCadastrarFuncionario;
        private ImageList imageList1;
        private Button btnSair;
        private Button btnContactos;
        private Button button4;
        private Button btnEstoque;
        private Button button2;
        private Button btnListaDeFuncionarios;
        private ImageList imageList2;
        private Label label1;
        private Panel pnlCentroAdministrador;
        private PictureBox pictureBox1;
    }
}