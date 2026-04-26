namespace validador_RH
{
    partial class FormLogin
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
            labelUsuario = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelSenha = new Label();
            buttonFazerLogin = new Button();
            buttonCadastrar = new Button();
            SuspendLayout();
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(295, 151);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(151, 15);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Insira seu nome de usuário:";
            labelUsuario.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(295, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 23);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(295, 196);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(93, 15);
            labelSenha.TabIndex = 2;
            labelSenha.Text = "Insira sua senha:";
            labelSenha.Click += label2_Click;
            // 
            // buttonFazerLogin
            // 
            buttonFazerLogin.Location = new Point(362, 261);
            buttonFazerLogin.Name = "buttonFazerLogin";
            buttonFazerLogin.Size = new Size(75, 23);
            buttonFazerLogin.TabIndex = 4;
            buttonFazerLogin.Text = "Fazer Login";
            buttonFazerLogin.UseVisualStyleBackColor = true;
            buttonFazerLogin.Click += buttonFazerLogin_Click;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(346, 290);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(110, 23);
            buttonCadastrar.TabIndex = 5;
            buttonCadastrar.Text = "Fazer cadastro";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCadastrar);
            Controls.Add(buttonFazerLogin);
            Controls.Add(textBox2);
            Controls.Add(labelSenha);
            Controls.Add(textBox1);
            Controls.Add(labelUsuario);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsuario;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelSenha;
        private Button buttonFazerLogin;
        private Button buttonCadastrar;
    }
}