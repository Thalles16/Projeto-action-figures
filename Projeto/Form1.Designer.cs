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
            panel1 = new Panel();
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
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(427, 137);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(200, 191);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(200, 95);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 191);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 95);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
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
    }
}
