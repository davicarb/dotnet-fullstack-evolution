using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace validador_RH
{
    public partial class FormSistema : Form
    {
        string pastaDoApp;
        string jsonPath;

        // carrega a lista de candidatos
        List<Candidato> listaCandidatos = new List<Candidato>();

        public FormSistema(string nomeUsuarioLogado)
        {
            InitializeComponent();
            this.AcceptButton = BotaoValidar;
            labelUsuarioLogado.Text = ($"Usuário logado: {nomeUsuarioLogado}");

            pastaDoApp = AppDomain.CurrentDomain.BaseDirectory;
            jsonPath = Path.Combine(pastaDoApp, "candidatos.json");

            if (File.Exists(jsonPath))
            {
                string jsonRead = File.ReadAllText(jsonPath);
                listaCandidatos = JsonSerializer.Deserialize<List<Candidato>>(jsonRead);
            }

            AtualizarTabela();
        }

        private void BotaoValidar_Click(object sender, EventArgs e)
        {
            string nomeRecebido = CaixaTextoInsereNome.Text;

            if (nomeRecebido.Length < 3)
            {
                MessageBox.Show("Nome deve conter no mínimo 3 caracteres.");
                return;
            }

            bool validIdade = int.TryParse(CaixaTextoRecebeIdade.Text, out int idadeRecebida);

            if (!validIdade)
            {
                MessageBox.Show("Valor inserido na idade não é um número ou é um número inválido.");
                MessageBox.Show("Insira novamente.");
                validIdade = int.TryParse(CaixaTextoRecebeIdade.Text, out idadeRecebida);
                return;
            }

            if (idadeRecebida < 14)
            {
                MessageBox.Show("Cadastro negado: menor que a idade mínima permitida.");
                return;
            }

            else if (idadeRecebida >= 14 && idadeRecebida < 18)
            {
                string categoriaQueTrabalha = "Jovem aprendiz";
                MessageBox.Show($"Cadastro permitido para jovem aprendiz. Tipo de categoria: {categoriaQueTrabalha}");

                Candidato canditatoJA = new Candidato(nomeRecebido, idadeRecebida, categoriaQueTrabalha);
                listaCandidatos.Add(canditatoJA);
                var opcoes = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(listaCandidatos, opcoes);
                File.WriteAllText(jsonPath, jsonString);

                AtualizarTabela();

                return;
            }

            else if (idadeRecebida <= 95)
            {
                string categoriaQueTrabalha = "Contratação CLT";
                MessageBox.Show($"Cadastro liberado para contratação. Tipo de categoria: {categoriaQueTrabalha}");
                Candidato canditatoCLT = new Candidato(nomeRecebido, idadeRecebida, categoriaQueTrabalha);

                listaCandidatos.Add(canditatoCLT);
                var opcoes = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(listaCandidatos, opcoes);
                File.WriteAllText(jsonPath, jsonString);

                AtualizarTabela();

                return;
            }
            else
            {
                MessageBox.Show("valor inserido é maior do que 95. impossível adicionar na lista.");
                return;
            }


        }
        private void AtualizarTabela()
        {
            // resetar para null força o Windows Forms a redesenhar a tabela
            jsonCandidatosDataGrid.DataSource = null;
            jsonCandidatosDataGrid.DataSource = listaCandidatos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LabelInserirNome_Click(object sender, EventArgs e)
        {

        }

        private void CaixaTextoInsereNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void CaixaTextoRecebeIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void jsonCandidatosDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NomeUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
