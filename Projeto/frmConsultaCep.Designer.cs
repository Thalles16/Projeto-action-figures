namespace Projeto
{
    partial class frmConsultaCep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCep));
            lblTitulo = new Label();
            txtCEP = new TextBox();
            btnBuscar = new Button();
            lblResultado = new Label();
            btnFechar = new Button();
            lblCEP = new Label();
            lblEntregar = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(151, 106);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(301, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consultar Endereço por CEP";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(166, 183);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(271, 26);
            txtCEP.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(457, 184);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(119, 289);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 18);
            lblResultado.TabIndex = 3;
            lblResultado.Click += lblResultado_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(267, 395);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Location = new Point(99, 186);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(47, 18);
            lblCEP.TabIndex = 5;
            lblCEP.Text = "CEP:";
            // 
            // lblEntregar
            // 
            lblEntregar.AutoSize = true;
            lblEntregar.Location = new Point(99, 237);
            lblEntregar.Name = "lblEntregar";
            lblEntregar.Size = new Size(220, 18);
            lblEntregar.TabIndex = 6;
            lblEntregar.Text = "Entregaremos no Endereço:";
            // 
            // frmConsultaCep
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 459);
            Controls.Add(lblEntregar);
            Controls.Add(lblCEP);
            Controls.Add(btnFechar);
            Controls.Add(lblResultado);
            Controls.Add(btnBuscar);
            Controls.Add(txtCEP);
            Controls.Add(lblTitulo);
            Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmConsultaCep";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmConsultaCep";
            Load += frmConsultaCep_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtCEP;
        private Button btnBuscar;
        private Label lblResultado;
        private Button btnFechar;
        private Label lblCEP;
        private Label lblEntregar;
    }
}