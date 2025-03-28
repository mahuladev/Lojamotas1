
namespace LojaMotas.Funcionario
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            pnlMenuPrincipal = new Panel();
            btnVoltar = new Button();
            imageList1 = new ImageList(components);
            btnDefinicoes = new Button();
            button5 = new Button();
            button4 = new Button();
            btnCaixa = new Button();
            btnListaDeProdutos = new Button();
            btnVenda = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlTelaDeImagem = new Panel();
            lblNomeVendedor = new Label();
            pnlFuncionariosForms = new Panel();
            pnlMenuPrincipal.SuspendLayout();
            pnlTelaDeImagem.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuPrincipal
            // 
            pnlMenuPrincipal.BackColor = Color.Teal;
            pnlMenuPrincipal.Controls.Add(btnVoltar);
            pnlMenuPrincipal.Controls.Add(btnDefinicoes);
            pnlMenuPrincipal.Controls.Add(button5);
            pnlMenuPrincipal.Controls.Add(button4);
            pnlMenuPrincipal.Controls.Add(btnCaixa);
            pnlMenuPrincipal.Controls.Add(btnListaDeProdutos);
            pnlMenuPrincipal.Controls.Add(btnVenda);
            pnlMenuPrincipal.Controls.Add(label3);
            pnlMenuPrincipal.Controls.Add(label2);
            pnlMenuPrincipal.Controls.Add(label1);
            pnlMenuPrincipal.Controls.Add(pnlTelaDeImagem);
            pnlMenuPrincipal.Dock = DockStyle.Left;
            pnlMenuPrincipal.Location = new Point(0, 0);
            pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            pnlMenuPrincipal.Size = new Size(322, 700);
            pnlMenuPrincipal.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Honeydew;
            btnVoltar.Dock = DockStyle.Top;
            btnVoltar.FlatAppearance.BorderColor = Color.White;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatAppearance.MouseDownBackColor = Color.White;
            btnVoltar.FlatAppearance.MouseOverBackColor = Color.White;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.ImageAlign = ContentAlignment.BottomCenter;
            btnVoltar.ImageKey = "Logout.png";
            btnVoltar.ImageList = imageList1;
            btnVoltar.Location = new Point(56, 586);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(266, 60);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "SAIR";
            btnVoltar.TextAlign = ContentAlignment.TopCenter;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "0.png");
            imageList1.Images.SetKeyName(1, "Box.png");
            imageList1.Images.SetKeyName(2, "Customer.png");
            imageList1.Images.SetKeyName(3, "Fire Exit.png");
            imageList1.Images.SetKeyName(4, "Logout Rounded.png");
            imageList1.Images.SetKeyName(5, "Logout.png");
            imageList1.Images.SetKeyName(6, "Sale Price Tag.png");
            imageList1.Images.SetKeyName(7, "Test Account.png");
            imageList1.Images.SetKeyName(8, "Settings.png");
            // 
            // btnDefinicoes
            // 
            btnDefinicoes.BackColor = Color.Honeydew;
            btnDefinicoes.Dock = DockStyle.Top;
            btnDefinicoes.FlatAppearance.BorderColor = Color.White;
            btnDefinicoes.FlatAppearance.BorderSize = 0;
            btnDefinicoes.FlatAppearance.MouseDownBackColor = Color.White;
            btnDefinicoes.FlatAppearance.MouseOverBackColor = Color.White;
            btnDefinicoes.FlatStyle = FlatStyle.Flat;
            btnDefinicoes.ImageAlign = ContentAlignment.BottomCenter;
            btnDefinicoes.ImageKey = "Settings.png";
            btnDefinicoes.ImageList = imageList1;
            btnDefinicoes.Location = new Point(56, 526);
            btnDefinicoes.Name = "btnDefinicoes";
            btnDefinicoes.Size = new Size(266, 60);
            btnDefinicoes.TabIndex = 9;
            btnDefinicoes.Text = "DEFINIÇÕES";
            btnDefinicoes.TextAlign = ContentAlignment.TopCenter;
            btnDefinicoes.UseVisualStyleBackColor = false;
            btnDefinicoes.Click += btnDefinicoes_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Honeydew;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.White;
            button5.FlatAppearance.MouseOverBackColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ImageAlign = ContentAlignment.BottomCenter;
            button5.ImageKey = "Settings.png";
            button5.Location = new Point(56, 466);
            button5.Name = "button5";
            button5.Size = new Size(266, 60);
            button5.TabIndex = 8;
            button5.Text = "ssss";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Honeydew;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ImageAlign = ContentAlignment.BottomCenter;
            button4.ImageKey = "Customer.png";
            button4.ImageList = imageList1;
            button4.Location = new Point(56, 406);
            button4.Name = "button4";
            button4.Size = new Size(266, 60);
            button4.TabIndex = 7;
            button4.Text = "PERFIL";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnCaixa
            // 
            btnCaixa.BackColor = Color.Honeydew;
            btnCaixa.Dock = DockStyle.Top;
            btnCaixa.FlatAppearance.BorderColor = Color.White;
            btnCaixa.FlatAppearance.BorderSize = 0;
            btnCaixa.FlatAppearance.MouseOverBackColor = Color.White;
            btnCaixa.FlatStyle = FlatStyle.Flat;
            btnCaixa.ImageAlign = ContentAlignment.BottomCenter;
            btnCaixa.ImageKey = "Box.png";
            btnCaixa.ImageList = imageList1;
            btnCaixa.Location = new Point(56, 346);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(266, 60);
            btnCaixa.TabIndex = 6;
            btnCaixa.Text = "CAIXA";
            btnCaixa.TextAlign = ContentAlignment.TopCenter;
            btnCaixa.UseVisualStyleBackColor = false;
            btnCaixa.Click += btnCaixa_Click;
            // 
            // btnListaDeProdutos
            // 
            btnListaDeProdutos.BackColor = Color.Honeydew;
            btnListaDeProdutos.Dock = DockStyle.Top;
            btnListaDeProdutos.FlatAppearance.BorderColor = Color.White;
            btnListaDeProdutos.FlatAppearance.BorderSize = 0;
            btnListaDeProdutos.FlatAppearance.MouseOverBackColor = Color.White;
            btnListaDeProdutos.FlatStyle = FlatStyle.Flat;
            btnListaDeProdutos.ImageAlign = ContentAlignment.BottomCenter;
            btnListaDeProdutos.ImageKey = "0.png";
            btnListaDeProdutos.ImageList = imageList1;
            btnListaDeProdutos.Location = new Point(56, 286);
            btnListaDeProdutos.Name = "btnListaDeProdutos";
            btnListaDeProdutos.Size = new Size(266, 60);
            btnListaDeProdutos.TabIndex = 5;
            btnListaDeProdutos.Text = "LISTA DE PRODUTO";
            btnListaDeProdutos.TextAlign = ContentAlignment.TopCenter;
            btnListaDeProdutos.UseVisualStyleBackColor = false;
            btnListaDeProdutos.Click += btnListaDeProdutos_Click;
            // 
            // btnVenda
            // 
            btnVenda.BackColor = Color.Honeydew;
            btnVenda.Cursor = Cursors.Hand;
            btnVenda.Dock = DockStyle.Top;
            btnVenda.FlatAppearance.BorderColor = Color.White;
            btnVenda.FlatAppearance.BorderSize = 0;
            btnVenda.FlatAppearance.MouseDownBackColor = Color.White;
            btnVenda.FlatAppearance.MouseOverBackColor = Color.White;
            btnVenda.FlatStyle = FlatStyle.Flat;
            btnVenda.ImageAlign = ContentAlignment.BottomCenter;
            btnVenda.ImageKey = "Sale Price Tag.png";
            btnVenda.ImageList = imageList1;
            btnVenda.Location = new Point(56, 226);
            btnVenda.Name = "btnVenda";
            btnVenda.Size = new Size(266, 60);
            btnVenda.TabIndex = 4;
            btnVenda.Text = "VENDA";
            btnVenda.TextAlign = ContentAlignment.TopCenter;
            btnVenda.UseVisualStyleBackColor = false;
            btnVenda.Click += btnVenda_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(0, 64, 64);
            label3.Dock = DockStyle.Left;
            label3.Location = new Point(0, 226);
            label3.Name = "label3";
            label3.Size = new Size(56, 412);
            label3.TabIndex = 3;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(0, 64, 64);
            label2.Dock = DockStyle.Bottom;
            label2.Location = new Point(0, 638);
            label2.Name = "label2";
            label2.Size = new Size(322, 62);
            label2.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 64, 64);
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 176);
            label1.Name = "label1";
            label1.Size = new Size(322, 50);
            label1.TabIndex = 1;
            // 
            // pnlTelaDeImagem
            // 
            pnlTelaDeImagem.BackColor = Color.FromArgb(0, 64, 64);
            pnlTelaDeImagem.BackgroundImage = (Image)resources.GetObject("pnlTelaDeImagem.BackgroundImage");
            pnlTelaDeImagem.BackgroundImageLayout = ImageLayout.Center;
            pnlTelaDeImagem.Controls.Add(lblNomeVendedor);
            pnlTelaDeImagem.Dock = DockStyle.Top;
            pnlTelaDeImagem.Location = new Point(0, 0);
            pnlTelaDeImagem.Name = "pnlTelaDeImagem";
            pnlTelaDeImagem.Size = new Size(322, 176);
            pnlTelaDeImagem.TabIndex = 0;
            // 
            // lblNomeVendedor
            // 
            lblNomeVendedor.Dock = DockStyle.Bottom;
            lblNomeVendedor.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeVendedor.ForeColor = Color.White;
            lblNomeVendedor.Location = new Point(0, 149);
            lblNomeVendedor.Name = "lblNomeVendedor";
            lblNomeVendedor.Size = new Size(322, 27);
            lblNomeVendedor.TabIndex = 0;
            lblNomeVendedor.Text = "Vendedor";
            lblNomeVendedor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFuncionariosForms
            // 
            pnlFuncionariosForms.BackColor = Color.Transparent;
            pnlFuncionariosForms.Dock = DockStyle.Fill;
            pnlFuncionariosForms.Location = new Point(322, 0);
            pnlFuncionariosForms.Name = "pnlFuncionariosForms";
            pnlFuncionariosForms.Size = new Size(1048, 700);
            pnlFuncionariosForms.TabIndex = 1;
            pnlFuncionariosForms.Paint += pnlFuncionariosForms_Paint;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 700);
            Controls.Add(pnlFuncionariosForms);
            Controls.Add(pnlMenuPrincipal);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipal";
            pnlMenuPrincipal.ResumeLayout(false);
            pnlTelaDeImagem.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Panel pnlMenuPrincipal;
        private Label label2;
        private Label label1;
        private Panel pnlTelaDeImagem;
        private Button btnVoltar;
        private Button btnDefinicoes;
        private Button button5;
        private Button button4;
        private Button btnCaixa;
        private Button btnListaDeProdutos;
        private Button btnVenda;
        private Label label3;
        private Panel pnlFuncionariosForms;
        private ImageList imageList1;
        private Label lblNomeVendedor;
    }
}