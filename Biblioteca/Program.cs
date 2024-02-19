namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
                Biblioteca biblioteca = new Biblioteca();

                biblioteca.CadastrarLivro("Dom Casmurro", "Machado de Assis");
                biblioteca.CadastrarLivro("O Hobbit", "J.R.R. Tolkien");

                Console.WriteLine("Livros cadastrados na biblioteca:");
                foreach (Livro livro in biblioteca.Livros)
                {
                    Console.WriteLine($"{livro.Titulo} - {livro.Autor}");
                }

                Console.WriteLine();

                biblioteca.FazerEmprestimo("Dom Casmurro");
                biblioteca.DevolverLivro("O Hobbit");

                Console.WriteLine();

                Console.WriteLine("Disponibilidade dos livros:");
                Console.WriteLine($"Dom Casmurro: {biblioteca.VerificarDisponibilidade("Dom Casmurro")}");
                Console.WriteLine($"O Hobbit: {biblioteca.VerificarDisponibilidade("O Hobbit")}");
            
        }
    }
}
