using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace validador_RH
{
    internal class Candidato
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Categoria { get; set; }

        public Candidato() { }

        public Candidato(string nomeRecebido, int idadeRecebida, string categoriaQueTrabalha)
        {
            Nome = nomeRecebido;
            Idade = idadeRecebida;
            Categoria = categoriaQueTrabalha;
        }
    }

    public class Usuario
    {
        public string NomeUsuario { get; set; } 
        public string SenhaUsuario { get; set; }

        public Usuario() { }

        public Usuario(string nomeUsuario, string senhaUsuario)
        {
            NomeUsuario = nomeUsuario;
            SenhaUsuario = senhaUsuario;
        }

    }
}
