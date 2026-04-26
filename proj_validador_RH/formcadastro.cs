using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace validador_RH
{
    public partial class formCadastro : Form
    {
        List<Usuario> listaUsuariosParaCadastro = new List<Usuario>();

        string pastaDoApp;
        string jsonUsuariosPath;

        public formCadastro()
        {
            InitializeComponent();

            pastaDoApp = AppDomain.CurrentDomain.BaseDirectory;
            jsonUsuariosPath = Path.Combine(pastaDoApp, "usuarios.json");

            if (File.Exists(jsonUsuariosPath))
            {
                string jsonRead = File.ReadAllText(jsonUsuariosPath);
                listaUsuariosParaCadastro = JsonSerializer.Deserialize<List<Usuario>>(jsonRead);
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 3)
            {
                MessageBox.Show("Nome deve conter no mínimo 3 caracteres.");
                return; // para a execução aqui (valor nome invalido).
            }

            if (textBox2.Text.Length < 7)
            {
                MessageBox.Show("Crie uma senha mais forte com no mínimo 7 caracteres.");
                return; // para a execução aqui (valor senha invalida).
            }

            string nomeUsuarioRecebido = textBox1.Text;
            string senhaUsuarioRecebida = textBox2.Text;

            // foreach só verifica duplicata, nada mais
            foreach (var usuario in listaUsuariosParaCadastro)
            {
                if (nomeUsuarioRecebido == usuario.NomeUsuario)
                {
                    MessageBox.Show("Erro: nome já cadastrado.");
                    return; // para a execução aqui
                }
            }

            // só chega aqui se não encontrou duplicata no foreach acima
            Usuario novoUsuario = new Usuario(nomeUsuarioRecebido, senhaUsuarioRecebida);
            listaUsuariosParaCadastro.Add(novoUsuario);

            string jsonString = JsonSerializer.Serialize(listaUsuariosParaCadastro);
            File.WriteAllText(jsonUsuariosPath, jsonString);

            MessageBox.Show("Conta criada com sucesso!");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
