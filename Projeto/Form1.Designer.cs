namespace Projeto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            linkLabelCadastro = new LinkLabel();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(linkLabelCadastro);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 378);
            panel1.TabIndex = 0;
            // 
            // linkLabelCadastro
            // 
            linkLabelCadastro.AutoSize = true;
            linkLabelCadastro.Location = new Point(207, 316);
            linkLabelCadastro.Name = "linkLabelCadastro";
            linkLabelCadastro.Size = new Size(69, 15);
            linkLabelCadastro.TabIndex = 5;
            linkLabelCadastro.TabStop = true;
            linkLabelCadastro.Text = "Cadastre-se";
            linkLabelCadastro.LinkClicked += linkLabelCadastro_LinkClicked;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(207, 264);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(155, 209);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(211, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(155, 161);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 23);
            txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(66, 214);
            label2.Name = "label2";
            label2.Size = new Size(62, 18);
            label2.TabIndex = 1;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(66, 166);
            label1.Name = "label1";
            label1.Size = new Size(55, 18);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 378);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private Button btnEntrar;
        private LinkLabel linkLabelCadastro;
    }
}
