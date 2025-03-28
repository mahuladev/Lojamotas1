namespace LojaMotas.Funcionario
{
    partial class MeuPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeuPerfil));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlCentral = new Panel();
            lblMorada = new Label();
            lblTelefone = new Label();
            lblCargo = new Label();
            lblBilhete = new Label();
            lblEmail = new Label();
            lblNome = new Label();
            pbFoto = new Guna.UI2.WinForms.Guna2CircleButton();
            pnlCentral.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCentral
            // 
            pnlCentral.BackColor = Color.FromArgb(0, 64, 64);
            pnlCentral.Controls.Add(lblMorada);
            pnlCentral.Controls.Add(lblTelefone);
            pnlCentral.Controls.Add(lblCargo);
            pnlCentral.Controls.Add(lblBilhete);
            pnlCentral.Controls.Add(lblEmail);
            pnlCentral.Controls.Add(lblNome);
            pnlCentral.Location = new Point(224, 202);
            pnlCentral.Name = "pnlCentral";
            pnlCentral.Size = new Size(610, 461);
            pnlCentral.TabIndex = 0;
            // 
            // lblMorada
            // 
            lblMorada.BackColor = Color.Transparent;
            lblMorada.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMorada.ForeColor = Color.White;
            lblMorada.Location = new Point(391, 83);
            lblMorada.Name = "lblMorada";
            lblMorada.Size = new Size(59, 20);
            lblMorada.TabIndex = 6;
            lblMorada.Text = "Morada:";
            // 
            // lblTelefone
            // 
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefone.ForeColor = Color.White;
            lblTelefone.Location = new Point(391, 146);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(76, 20);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "Telefone:";
            // 
            // lblCargo
            // 
            lblCargo.BackColor = Color.Transparent;
            lblCargo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCargo.ForeColor = Color.White;
            lblCargo.Location = new Point(68, 204);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(59, 20);
            lblCargo.TabIndex = 4;
            lblCargo.Text = "Cargo:";
            // 
            // lblBilhete
            // 
            lblBilhete.BackColor = Color.Transparent;
            lblBilhete.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBilhete.ForeColor = Color.White;
            lblBilhete.Location = new Point(391, 204);
            lblBilhete.Name = "lblBilhete";
            lblBilhete.Size = new Size(59, 20);
            lblBilhete.TabIndex = 3;
            lblBilhete.Text = "Bilhete:";
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(68, 146);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblNome
            // 
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(68, 83);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(144, 21);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome Completo:";
            // 
            // pbFoto
            // 
            pbFoto.BackColor = Color.Transparent;
            pbFoto.BackgroundImage = (Image)resources.GetObject("pbFoto.BackgroundImage");
            pbFoto.BackgroundImageLayout = ImageLayout.Zoom;
            pbFoto.DisabledState.BorderColor = Color.DarkGray;
            pbFoto.DisabledState.CustomBorderColor = Color.DarkGray;
            pbFoto.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            pbFoto.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            pbFoto.FillColor = Color.Transparent;
            pbFoto.Font = new Font("Segoe UI", 9F);
            pbFoto.ForeColor = Color.White;
            pbFoto.Location = new Point(443, 12);
            pbFoto.Name = "pbFoto";
            pbFoto.ShadowDecoration.CustomizableEdges = customizableEdges1;
            pbFoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pbFoto.Size = new Size(173, 184);
            pbFoto.TabIndex = 1;
            // 
            // MeuPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1048, 700);
            Controls.Add(pbFoto);
            Controls.Add(pnlCentral);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MeuPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MeuPerfil";
            Load += MeuPerfil_Load;
            pnlCentral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCentral;
        private Label lblMorada;
        private Label lblTelefone;
        private Label lblCargo;
        private Label lblBilhete;
        private Label lblEmail;
        private Label lblNome;
        private Guna.UI2.WinForms.Guna2CircleButton pbFoto;
    }
}