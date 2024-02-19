using System.Globalization;

namespace Funcionário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o nome do funcionário?: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Em qual cargo?: ");
            string cargo = Console.ReadLine();

            Console.WriteLine("Quanto recebe?: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            Funcionario funcionario = new Funcionario(nome, salario, cargo);

            decimal salarioLiquido = funcionario.CalculoSalario();

            Console.Clear();

            Console.WriteLine("\nInformaçoes do funcionário");
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"Cargo: {funcionario.Cargo}");
            Console.WriteLine($"Salário Bruto: {funcionario.Salario:C}");
            Console.WriteLine($"Beneficios: {funcionario.Beneficio:C}");
            Console.WriteLine($"Impostos: {funcionario.descontoImposto:P}");
            Console.WriteLine($"Salario líquido total (Salário + beneficios): {salarioLiquido:C}");
        }
    }
}
