namespace LojaMotas.Funcionario
{
    partial class Caixa
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
            label1 = new Label();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(445, 40);
            label1.Name = "label1";
            label1.Size = new Size(172, 24);
            label1.TabIndex = 0;
            label1.Text = "Venda De Hoje:";
            // 
            // listView1
            // 
            listView1.BackColor = Color.DimGray;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(236, 117);
            listView1.Name = "listView1";
            listView1.Size = new Size(591, 292);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Caixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1048, 700);
            Controls.Add(listView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Caixa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caixa";
            Load += Caixa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
    }
}