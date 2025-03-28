namespace LojaMotas.Gerente
{
    partial class Contactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contactos));
            panel1 = new Panel();
            btnEnviarMensagem = new Guna.UI2.WinForms.Guna2Button();
            lblComentario = new Label();
            txtComentario = new TextBox();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            lklWhatsapp = new LinkLabel();
            label3 = new Label();
            imageList1 = new ImageList(components);
            label2 = new Label();
            label1 = new Label();
            lblWhatsapp = new Label();
            lblApoio = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEnviarMensagem);
            panel1.Controls.Add(lblComentario);
            panel1.Controls.Add(txtComentario);
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(lklWhatsapp);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblWhatsapp);
            panel1.Location = new Point(244, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 524);
            panel1.TabIndex = 0;
            // 
            // btnEnviarMensagem
            // 
            btnEnviarMensagem.BorderColor = Color.FromArgb(64, 64, 64);
            btnEnviarMensagem.BorderRadius = 8;
            btnEnviarMensagem.CustomizableEdges = customizableEdges1;
            btnEnviarMensagem.DisabledState.BorderColor = Color.DarkGray;
            btnEnviarMensagem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEnviarMensagem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEnviarMensagem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEnviarMensagem.FillColor = Color.Green;
            btnEnviarMensagem.Font = new Font("Segoe UI", 9F);
            btnEnviarMensagem.ForeColor = Color.White;
            btnEnviarMensagem.Location = new Point(395, 476);
            btnEnviarMensagem.Name = "btnEnviarMensagem";
            btnEnviarMensagem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEnviarMensagem.Size = new Size(110, 34);
            btnEnviarMensagem.TabIndex = 10;
            btnEnviarMensagem.Text = "ENVIAR";
            // 
            // lblComentario
            // 
            lblComentario.ForeColor = Color.White;
            lblComentario.Location = new Point(35, 211);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(103, 25);
            lblComentario.TabIndex = 9;
            lblComentario.Text = "Comentário:";
            lblComentario.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtComentario
            // 
            txtComentario.BorderStyle = BorderStyle.None;
            txtComentario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComentario.Location = new Point(35, 239);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(470, 221);
            txtComentario.TabIndex = 8;
            // 
            // linkLabel3
            // 
            linkLabel3.LinkColor = Color.Yellow;
            linkLabel3.Location = new Point(35, 156);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(160, 20);
            linkLabel3.TabIndex = 7;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "mahulaTech@gmail.com";
            // 
            // linkLabel2
            // 
            linkLabel2.LinkColor = Color.Yellow;
            linkLabel2.Location = new Point(342, 156);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(163, 20);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "www.amiltonmahula.com";
            // 
            // linkLabel1
            // 
            linkLabel1.LinkColor = Color.Yellow;
            linkLabel1.Location = new Point(342, 76);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(134, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "www.Facebook.com";
            // 
            // lklWhatsapp
            // 
            lklWhatsapp.LinkColor = Color.Yellow;
            lklWhatsapp.Location = new Point(35, 76);
            lklWhatsapp.Name = "lklWhatsapp";
            lklWhatsapp.Size = new Size(134, 20);
            lklWhatsapp.TabIndex = 4;
            lklWhatsapp.TabStop = true;
            lklWhatsapp.Text = "www.Whatsapp.com";
            lklWhatsapp.LinkClicked += lklWhatsapp_LinkClicked;
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.ImageKey = "icons8-e-mail-50.png";
            label3.ImageList = imageList1;
            label3.Location = new Point(35, 136);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-e-mail-50.png");
            imageList1.Images.SetKeyName(1, "icons8-facebook-num-círculo-48.png");
            imageList1.Images.SetKeyName(2, "icons8-internet-48.png");
            imageList1.Images.SetKeyName(3, "icons8-nova-mensagem-50.png");
            imageList1.Images.SetKeyName(4, "icons8-whatsapp-48.png");
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.ImageKey = "icons8-facebook-num-círculo-48.png";
            label2.ImageList = imageList1;
            label2.Location = new Point(342, 51);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 2;
            label2.Text = "Facebook:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.ImageKey = "icons8-internet-48.png";
            label1.ImageList = imageList1;
            label1.Location = new Point(342, 137);
            label1.Name = "label1";
            label1.Size = new Size(103, 19);
            label1.TabIndex = 1;
            label1.Text = "Site:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWhatsapp
            // 
            lblWhatsapp.ForeColor = Color.White;
            lblWhatsapp.ImageAlign = ContentAlignment.MiddleLeft;
            lblWhatsapp.ImageKey = "icons8-whatsapp-48.png";
            lblWhatsapp.ImageList = imageList1;
            lblWhatsapp.Location = new Point(35, 51);
            lblWhatsapp.Name = "lblWhatsapp";
            lblWhatsapp.Size = new Size(103, 25);
            lblWhatsapp.TabIndex = 0;
            lblWhatsapp.Text = "Whatsapp:";
            lblWhatsapp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblApoio
            // 
            lblApoio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApoio.ForeColor = Color.White;
            lblApoio.ImageList = imageList1;
            lblApoio.Location = new Point(441, 35);
            lblApoio.Name = "lblApoio";
            lblApoio.Size = new Size(141, 26);
            lblApoio.TabIndex = 1;
            lblApoio.Text = "Apoio";
            lblApoio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Contactos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(1048, 700);
            Controls.Add(lblApoio);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Contactos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contactos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label lblWhatsapp;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private LinkLabel lklWhatsapp;
        private Label label3;
        private ImageList imageList1;
        private TextBox txtComentario;
        private Label lblApoio;
        private Label lblComentario;
        private Guna.UI2.WinForms.Guna2Button btnEnviarMensagem;
    }
}