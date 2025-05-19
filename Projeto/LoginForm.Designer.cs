namespace Projeto
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnCadastro = new Button();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(128, 273);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(94, 30);
            btnCadastro.TabIndex = 9;
            btnCadastro.Text = "Cadastrar-se";
            btnCadastro.UseVisualStyleBackColor = true;
           
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(116, 214);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(170, 23);
            txtSenha.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(116, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(170, 23);
            txtEmail.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(33, 219);
            label2.Name = "label2";
            label2.Size = new Size(62, 18);
            label2.TabIndex = 6;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(33, 175);
            label1.Name = "label1";
            label1.Size = new Size(55, 18);
            label1.TabIndex = 5;
            label1.Text = "Email:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 355);
            Controls.Add(btnCadastro);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastro;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
    }
}