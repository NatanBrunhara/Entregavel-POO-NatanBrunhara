using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocial
{
    class Postagem
    {
        public string Autor { get; set; }
        public string Conteudo { get; set; }
        public List<string> Comentarios { get; set; }

        public Postagem(string autor, string conteudo)
        {
            Autor = autor;
            Conteudo = conteudo;
            Comentarios = new List<string>();
        }
    }
    class RedeSocial
    {
        private Dictionary<string, List<string>> amigos;
        private List<Postagem> postagens;

        public RedeSocial()
        {
            amigos = new Dictionary<string, List<string>>();
            postagens = new List<Postagem>();
        }

        public void AdicionarAmigo(string usuario, string amigo)
        {
            if (!amigos.ContainsKey(usuario))
            {
                amigos[usuario] = new List<string>();
            }
            amigos[usuario].Add(amigo);
        }

        public void PublicarMensagem(string autor, string mensagem)
        {
            postagens.Add(new Postagem(autor, mensagem));
        }

        public void ComentarPost(int indicePost, string autor, string comentario)
        {
            if (indicePost >= 0 && indicePost < postagens.Count) 
            {
                postagens[indicePost].Comentarios.Add($"{autor}: {comentario}");
            }
            else
            {
                Console.WriteLine("Índice de postagem inválido.");
            }
        }

        public void BuscarUsuario (string usuario)
        {
            if (amigos.ContainsKey(usuario))
            {
                Console.WriteLine($"Amigos de {usuario}");
                foreach (var amigo in amigos[usuario])
                {
                    Console.WriteLine(amigo);
                }
            }
            else
            {
                Console.WriteLine($"Usuário '{usuario}' não encontrado.");
            }
        }

        public void MostrarTimeline()
        {
            Console.WriteLine("Timeline:");
            foreach (var postagem in postagens)
            {
                Console.WriteLine($"Autor: {postagem.Autor}");
                Console.WriteLine($"Post: {postagem.Conteudo}");
                Console.WriteLine("Comentários:");
                foreach (var comentario in postagem.Comentarios)
                {
                    Console.WriteLine(comentario);
                }
                Console.WriteLine();
            }
        }
    }
}
