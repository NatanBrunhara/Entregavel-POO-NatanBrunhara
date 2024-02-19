using Entregavel_POO__pt1_;

namespace Alunos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a matrícula do aluno: ");
            int matricula = Convert.ToInt32(Console.ReadLine());

            Aluno aluno = new Aluno(nome, matricula);

            Console.Write("Digite a quantidade de notas do aluno: ");
            int quantidadeNotas = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantidadeNotas; i++)
            {
                Console.Write($"Digite a nota {i + 1}: ");
                double nota;
                if (!double.TryParse(Console.ReadLine(), out nota))
                {
                    Console.WriteLine("Nota inválida. Por favor, digite novamente.");
                    i--;
                    continue;
                }
                aluno.AdicionarNota(nota);
            }

            Console.WriteLine($"Nome do aluno: {aluno.Nome}");
            Console.WriteLine($"Matrícula do aluno: {aluno.Matricula}");
            Console.WriteLine($"Notas do aluno: {string.Join(", ", aluno.Notas)}");
            Console.WriteLine($"Média do aluno: {aluno.CalcularMedia()}");
            Console.WriteLine($"Situação do aluno: {aluno.VerificarSituacao()}");
        }
    }
}
