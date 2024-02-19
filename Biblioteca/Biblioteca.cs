using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Disponivel { get; set; }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            Disponivel = true;
        }
    }

    class Biblioteca
    {
        private List<Livro> livros;

        public List<Livro> Livros
        {
            get { return livros; }
        }

        public Biblioteca()
        {
            livros = new List<Livro>();
        }

        public void CadastrarLivro(string titulo, string autor)
        {
            livros.Add(new Livro(titulo, autor));
        }

        public void FazerEmprestimo(string titulo)
        {
            Livro livro = EncontrarLivro(titulo);
            if (livro != null)
            {
                if (livro.Disponivel)
                {
                    livro.Disponivel = false;
                    Console.WriteLine($"O livro '{titulo}' foi emprestado com sucesso.");
                }
                else
                {
                    Console.WriteLine($"O livro '{titulo}' não está disponível para empréstimo.");
                }
            }
            else
            {
                Console.WriteLine($"O livro '{titulo}' não foi encontrado na biblioteca.");
            }
        }

        public void DevolverLivro(string titulo)
        {
            Livro livro = EncontrarLivro(titulo);
            if (livro != null)
            {
                livro.Disponivel = true;
                Console.WriteLine($"O livro '{titulo}' foi devolvido com sucesso.");
            }
            else
            {
                Console.WriteLine($"O livro '{titulo}' não foi encontrado na biblioteca.");
            }
        }

        public bool VerificarDisponibilidade(string titulo)
        {
            Livro livro = EncontrarLivro(titulo);
            return livro != null && livro.Disponivel;
        }

        public Livro EncontrarLivro(string titulo)
        {
            foreach (Livro livro in livros)
            {
                if (livro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return livro;
                }
            }
            return null;
        }
    }
}
