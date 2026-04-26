namespace validador_RH
{
    partial class FormSistema
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
            BotaoValidar = new Button();
            LabelInserirNome = new Label();
            CaixaTextoInsereNome = new TextBox();
            LabelInserirIdade = new Label();
            CaixaTextoRecebeIdade = new TextBox();
            label1 = new Label();
            jsonCandidatosDataGrid = new DataGridView();
            usuarioLogado = new Label();
            labelUsuarioLogado = new Label();
            ((System.ComponentModel.ISupportInitialize)jsonCandidatosDataGrid).BeginInit();
            SuspendLayout();
            // 
            // BotaoValidar
            // 
            BotaoValidar.Location = new Point(30, 266);
            BotaoValidar.Name = "BotaoValidar";
            BotaoValidar.Size = new Size(75, 23);
            BotaoValidar.TabIndex = 0;
            BotaoValidar.Text = "Cadastrar";
            BotaoValidar.UseVisualStyleBackColor = true;
            BotaoValidar.Click += BotaoValidar_Click;
            // 
            // LabelInserirNome
            // 
            LabelInserirNome.AutoSize = true;
            LabelInserirNome.Location = new Point(30, 151);
            LabelInserirNome.Name = "LabelInserirNome";
            LabelInserirNome.Size = new Size(156, 15);
            LabelInserirNome.TabIndex = 1;
            LabelInserirNome.Text = "Insira nome do colaborador:";
            LabelInserirNome.Click += LabelInserirNome_Click;
            // 
            // CaixaTextoInsereNome
            // 
            CaixaTextoInsereNome.Location = new Point(30, 169);
            CaixaTextoInsereNome.Name = "CaixaTextoInsereNome";
            CaixaTextoInsereNome.Size = new Size(401, 23);
            CaixaTextoInsereNome.TabIndex = 2;
            CaixaTextoInsereNome.TextChanged += CaixaTextoInsereNome_TextChanged;
            // 
            // LabelInserirIdade
            // 
            LabelInserirIdade.AutoSize = true;
            LabelInserirIdade.Location = new Point(30, 206);
            LabelInserirIdade.Name = "LabelInserirIdade";
            LabelInserirIdade.Size = new Size(154, 15);
            LabelInserirIdade.TabIndex = 3;
            LabelInserirIdade.Text = "Insira idade do colaborador:";
            // 
            // CaixaTextoRecebeIdade
            // 
            CaixaTextoRecebeIdade.Location = new Point(30, 224);
            CaixaTextoRecebeIdade.Name = "CaixaTextoRecebeIdade";
            CaixaTextoRecebeIdade.Size = new Size(401, 23);
            CaixaTextoRecebeIdade.TabIndex = 4;
            CaixaTextoRecebeIdade.TextChanged += CaixaTextoRecebeIdade_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 118);
            label1.Name = "label1";
            label1.Size = new Size(214, 15);
            label1.TabIndex = 5;
            label1.Text = "Sistema de cadastro de RH usando json\r\n";
            // 
            // jsonCandidatosDataGrid
            // 
            jsonCandidatosDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            jsonCandidatosDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jsonCandidatosDataGrid.Location = new Point(30, 328);
            jsonCandidatosDataGrid.Name = "jsonCandidatosDataGrid";
            jsonCandidatosDataGrid.Size = new Size(383, 173);
            jsonCandidatosDataGrid.TabIndex = 6;
            jsonCandidatosDataGrid.CellContentClick += jsonCandidatosDataGrid_CellContentClick;
            // 
            // usuarioLogado
            // 
            usuarioLogado.AutoSize = true;
            usuarioLogado.Location = new Point(30, 26);
            usuarioLogado.Name = "usuarioLogado";
            usuarioLogado.Size = new Size(90, 15);
            usuarioLogado.TabIndex = 7;
            usuarioLogado.Text = "Usuário logado:";
            // 
            // labelUsuarioLogado
            // 
            labelUsuarioLogado.AutoSize = true;
            labelUsuarioLogado.Location = new Point(126, 26);
            labelUsuarioLogado.Name = "labelUsuarioLogado";
            labelUsuarioLogado.Size = new Size(38, 15);
            labelUsuarioLogado.TabIndex = 8;
            labelUsuarioLogado.Text = "label2";
            labelUsuarioLogado.Click += NomeUsuario_Click;
            // 
            // FormSistema
            // 
            AcceptButton = BotaoValidar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(785, 544);
            Controls.Add(labelUsuarioLogado);
            Controls.Add(usuarioLogado);
            Controls.Add(jsonCandidatosDataGrid);
            Controls.Add(label1);
            Controls.Add(CaixaTextoRecebeIdade);
            Controls.Add(LabelInserirIdade);
            Controls.Add(CaixaTextoInsereNome);
            Controls.Add(LabelInserirNome);
            Controls.Add(BotaoValidar);
            Name = "FormSistema";
            Text = "FormSistema";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)jsonCandidatosDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotaoValidar;
        private Label LabelInserirNome;
        private TextBox CaixaTextoInsereNome;
        private Label LabelInserirIdade;
        private TextBox CaixaTextoRecebeIdade;
        private Label label1;
        private DataGridView jsonCandidatosDataGrid;
        private Label usuarioLogado;
        private Label labelUsuarioLogado;
    }
}
