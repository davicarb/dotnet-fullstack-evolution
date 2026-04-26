using static System.Windows.Forms.DataFormats;

namespace validador_RH
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // configurações padrão do Windows Forms
            ApplicationConfiguration.Initialize();

            // 1. criamos a instância do formulário de Login
            // usando o bloco 'using' para garantir que a memória seja limpa depois
            using (FormLogin telaLogin = new FormLogin())
            {
                // 2. o ShowDialog trava o código aqui até o login fechar
                // ele só vai entrar no IF se o seu código do botão deu: this.DialogResult = DialogResult.OK;
                if (telaLogin.ShowDialog() == DialogResult.OK)
                {
                    // 3. se o login foi um sucesso, ele abre o sistema de RH
                    string nomeUsuarioLogado = telaLogin.NomeUsuarioLogado;
                    Application.Run(new FormSistema(nomeUsuarioLogado));
                }
                else
                {
                    // 4. se o usuário clicou no "X" ou o login falhou, o app encerra
                    Application.Exit();
                }
            }
        }
    }
}