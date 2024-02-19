using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{
    class Livro
    {
        private string titulo;
        private string autor;
        private int numeroPaginas;
        private bool disponivel;

        public Livro(string titulo, string autor, int numeroPaginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.numeroPaginas = numeroPaginas;
            this.disponivel = true; 
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int NumeroPaginas
        {
            get { return numeroPaginas; }
            set { numeroPaginas = value; }
        }

        public bool Disponivel
        {
            get { return disponivel; }
        }

        public void EmprestarLivro(string pessoa)
        {
            if (disponivel)
            {
                disponivel = false;
                Console.WriteLine($"O livro \"{titulo}\" foi emprestado para {pessoa}.");
            }
            else
            {
                Console.WriteLine($"Desculpe, o livro \"{titulo}\" não está disponível para empréstimo.");
            }
        }

        public void DevolverLivro(string pessoa)
        {
            if (!disponivel)
            {
                disponivel = true;
                Console.WriteLine($"O livro \"{titulo}\" foi devolvido por {pessoa}.");
            }
            else
            {
                Console.WriteLine($"O livro \"{titulo}\" já está disponível.");
            }
        }
    }
}
