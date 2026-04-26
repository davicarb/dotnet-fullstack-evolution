using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace validador_RH
{
    public partial class FormLogin : Form
    {
        public string NomeUsuarioLogado { get; private set; }
        List<Usuario> listaUsuarios = new List<Usuario>();

        string pastaDoApp;
        string jsonUsuariosPath;

        public FormLogin()
        {
            InitializeComponent();

            pastaDoApp = AppDomain.CurrentDomain.BaseDirectory;
            jsonUsuariosPath = Path.Combine(pastaDoApp, "usuarios.json");

            if (File.Exists(jsonUsuariosPath))
            {
                string jsonRead = File.ReadAllText(jsonUsuariosPath);
                listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(jsonRead);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonFazerLogin_Click(object sender, EventArgs e)
        {
            bool usuarioLogado = false;
            bool usuarioEncontrado = false;

            foreach (var usuario in listaUsuarios)
            {
                if (textBox1.Text == usuario.NomeUsuario)
                {
                    usuarioEncontrado = true;

                    if (textBox2.Text == usuario.SenhaUsuario)
                    {
                        MessageBox.Show($"logado com sucesso, {usuario.NomeUsuario}!");
                        usuarioLogado = true;
                        this.DialogResult = DialogResult.OK;

                        // no form de login, quando valida o usuario
                        // retornamos o valor de usuario.NomeUsuario para o Program.cs saber (é um public get, ele pode ler, mas nao escrever.)
                        NomeUsuarioLogado = usuario.NomeUsuario;
                        FormSistema tela = new FormSistema(usuario.NomeUsuario);
                        break;
                    }


                    else
                    {
                        MessageBox.Show("senha incorreta.");
                        break;
                    }
                }
            }

            if (!usuarioLogado && !usuarioEncontrado)
            {
                MessageBox.Show("usuário não cadastrado/inexistente.");
            }

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            formCadastro telaCadastro = new formCadastro();
            telaCadastro.ShowDialog();
        }
    }
}
