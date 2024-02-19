namespace Pessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o nome do usuario?:");
            string nome = Console.ReadLine();

            Console.WriteLine("E qual a idade do mesmo?: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua profissão?: "); 
            string profissao = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome, idade, profissao);

            Console.WriteLine("\n INFORMAÇÕES DA PESSOA SOLICITADA");
            pessoa.Informações();

            int anoAtual = DateTime.Now.Year;
            int idadeBissexto = pessoa.IdadeBissexto(anoAtual);
            Console.WriteLine($"\n Idade em anos bissextos: {idadeBissexto}");
        }
    }
}
