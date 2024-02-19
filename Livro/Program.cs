namespace Livro
{
    class Program
    {
        static Random random = new Random();
        static string[] autores = { "Platão", "Aristóteles", "Sócrates", "René Descartes", "Immanuel Kant", "Friedrich Nietzsche", "Jean-Paul Sartre", "Santo Agostinho", "David Hume", "John Locke" };
        static HashSet<string> pessoasQueRetiraramLivros = new HashSet<string>();
        static Dictionary<string, List<Livro>> livrosEmprestados = new Dictionary<string, List<Livro>>();

        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um dos seguintes livros:");

            Livro[] livrosFilosofia = {
            new Livro("A República", "Platão", GerarNumeroPaginas()),
            new Livro("Ética a Nicômaco", "Aristóteles", GerarNumeroPaginas()),
            new Livro("Apologia de Sócrates", "Sócrates", GerarNumeroPaginas()),
            new Livro("Discurso do Método", "René Descartes", GerarNumeroPaginas()),
            new Livro("Crítica da Razão Pura", "Immanuel Kant", GerarNumeroPaginas()),
            new Livro("Assim Falou Zaratustra", "Friedrich Nietzsche", GerarNumeroPaginas()),
            new Livro("O Existencialismo é um Humanismo", "Jean-Paul Sartre", GerarNumeroPaginas()),
            new Livro("Confissões", "Santo Agostinho", GerarNumeroPaginas()),
            new Livro("Tratado da Natureza Humana", "David Hume", GerarNumeroPaginas()),
            new Livro("Ensaio sobre o Entendimento Humano", "John Locke", GerarNumeroPaginas())
        };

            for (int i = 0; i < livrosFilosofia.Length; i++)
            {
                Console.WriteLine($"{i + 1}. \"{livrosFilosofia[i].Titulo}\" - {livrosFilosofia[i].Autor}");
            }

            Console.Write("Escolha o número do livro que deseja retirar: ");
            int escolhaLivro = int.Parse(Console.ReadLine()) - 1;

            if (escolhaLivro >= 0 && escolhaLivro < livrosFilosofia.Length)
            {
                Livro livroEscolhido = livrosFilosofia[escolhaLivro];

                if (livroEscolhido.Disponivel)
                {
                    Console.Write("Digite o nome da pessoa que está pegando emprestado: ");
                    string nomePessoa = Console.ReadLine();

                    livroEscolhido.EmprestarLivro(nomePessoa);
                    pessoasQueRetiraramLivros.Add(nomePessoa);

                    if (!livrosEmprestados.ContainsKey(nomePessoa))
                    {
                        livrosEmprestados[nomePessoa] = new List<Livro>();
                    }
                    livrosEmprestados[nomePessoa].Add(livroEscolhido);
                }
                else
                {
                    Console.WriteLine($"O livro \"{livroEscolhido.Titulo}\" já foi retirado por outra pessoa.");
                }
            }
            else
            {
                Console.WriteLine("Escolha inválida. O programa será encerrado.");
            }

            Console.WriteLine("\nLivros emprestados:");
            foreach (var pessoa in livrosEmprestados.Keys)
            {
                Console.WriteLine($"Pessoa: {pessoa}");
                foreach (var livro in livrosEmprestados[pessoa])
                {
                    Console.WriteLine($"Livro: {livro.Titulo} - Autor: {livro.Autor}");
                }
            }

            foreach (var pessoa in pessoasQueRetiraramLivros)
            {
                Console.Write($"\n{pessoa} deseja devolver algum livro? (S/N): ");
                string resposta = Console.ReadLine().ToUpper();
                if (resposta == "S")
                {
                    Console.WriteLine("Livros que você tem:");
                    foreach (var livro in livrosEmprestados[pessoa])
                    {
                        Console.WriteLine($"- \"{livro.Titulo}\"");
                    }
                    Console.Write("Digite o número do livro que deseja devolver: ");
                    int livroDevolvido = int.Parse(Console.ReadLine()) - 1;
                    if (livroDevolvido >= 0 && livroDevolvido < livrosEmprestados[pessoa].Count)
                    {
                        Livro livro = livrosEmprestados[pessoa][livroDevolvido];
                        livro.DevolverLivro(pessoa);
                        livrosEmprestados[pessoa].RemoveAt(livroDevolvido);
                        pessoasQueRetiraramLivros.Remove(pessoa);
                    }
                    else
                    {
                        Console.WriteLine("Escolha inválida.");
                    }
                }
            }
        }

        static int GerarNumeroPaginas()
        {
            return random.Next(200, 501);
        }
    }
}
    
    

