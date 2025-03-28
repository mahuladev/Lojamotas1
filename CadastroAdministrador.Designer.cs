namespace LojaMotas
{
    partial class CadastroAdministrador
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            btnCadastroAdmin = new Guna.UI2.WinForms.Guna2Button();
            txtEmailAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            txtSenhaAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            lblVoltar = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(122, 27);
            label1.Name = "label1";
            label1.Size = new Size(280, 23);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO ADMINISTRADOR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCadastroAdmin
            // 
            btnCadastroAdmin.BorderColor = Color.White;
            btnCadastroAdmin.BorderRadius = 10;
            btnCadastroAdmin.BorderThickness = 1;
            btnCadastroAdmin.CustomizableEdges = customizableEdges1;
            btnCadastroAdmin.DisabledState.BorderColor = Color.DarkGray;
            btnCadastroAdmin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCadastroAdmin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCadastroAdmin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCadastroAdmin.FillColor = Color.SlateBlue;
            btnCadastroAdmin.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastroAdmin.ForeColor = Color.White;
            btnCadastroAdmin.Location = new Point(189, 344);
            btnCadastroAdmin.Name = "btnCadastroAdmin";
            btnCadastroAdmin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCadastroAdmin.Size = new Size(146, 45);
            btnCadastroAdmin.TabIndex = 2;
            btnCadastroAdmin.Text = "CADASTRAR";
            btnCadastroAdmin.Click += btnCadastroAdmin_Click;
            // 
            // txtEmailAdmin
            // 
            txtEmailAdmin.BorderColor = Color.Black;
            txtEmailAdmin.BorderRadius = 8;
            txtEmailAdmin.CustomizableEdges = customizableEdges3;
            txtEmailAdmin.DefaultText = "";
            txtEmailAdmin.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmailAdmin.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmailAdmin.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmailAdmin.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmailAdmin.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmailAdmin.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailAdmin.ForeColor = Color.Black;
            txtEmailAdmin.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmailAdmin.Location = new Point(140, 128);
            txtEmailAdmin.Name = "txtEmailAdmin";
            txtEmailAdmin.PasswordChar = '\0';
            txtEmailAdmin.PlaceholderText = "";
            txtEmailAdmin.SelectedText = "";
            txtEmailAdmin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtEmailAdmin.Size = new Size(244, 34);
            txtEmailAdmin.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(140, 108);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtSenhaAdmin
            // 
            txtSenhaAdmin.BorderColor = Color.Black;
            txtSenhaAdmin.BorderRadius = 8;
            txtSenhaAdmin.CustomizableEdges = customizableEdges5;
            txtSenhaAdmin.DefaultText = "";
            txtSenhaAdmin.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenhaAdmin.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenhaAdmin.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenhaAdmin.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenhaAdmin.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenhaAdmin.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenhaAdmin.ForeColor = Color.Black;
            txtSenhaAdmin.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenhaAdmin.Location = new Point(140, 214);
            txtSenhaAdmin.Name = "txtSenhaAdmin";
            txtSenhaAdmin.PasswordChar = '\0';
            txtSenhaAdmin.PlaceholderText = "";
            txtSenhaAdmin.SelectedText = "";
            txtSenhaAdmin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSenhaAdmin.Size = new Size(244, 34);
            txtSenhaAdmin.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(140, 194);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 6;
            label4.Text = "Senha:";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblVoltar
            // 
            lblVoltar.AutoSize = true;
            lblVoltar.Cursor = Cursors.Hand;
            lblVoltar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVoltar.ForeColor = Color.White;
            lblVoltar.Location = new Point(38, 444);
            lblVoltar.Name = "lblVoltar";
            lblVoltar.Size = new Size(53, 20);
            lblVoltar.TabIndex = 10;
            lblVoltar.Text = "Voltar";
            lblVoltar.Click += label6_Click;
            // 
            // CadastroAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(537, 486);
            Controls.Add(lblVoltar);
            Controls.Add(txtSenhaAdmin);
            Controls.Add(label4);
            Controls.Add(txtEmailAdmin);
            Controls.Add(label3);
            Controls.Add(btnCadastroAdmin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroAdministrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroAdministrador";
            Load += CadastroAdministrador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCadastroAdmin;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailAdmin;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSenhaAdmin;
        private Label label4;
        private Label lblVoltar;
    }
}