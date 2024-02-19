using System.Xml;

namespace Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola! Qual o nome do produto?: ");
            string nome = Console.ReadLine();

            Console.WriteLine("E qual o valor?: ");
            decimal preco = Convert.ToDecimal(Console.ReadLine());

            int estoque = 10;

            Produto produto = new Produto(nome, preco, estoque);

            Console.Clear();

            Console.WriteLine($"\nProduto registrado com sucesso!");
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Valor: {produto.Preco}");
            Console.WriteLine($"Quantidade em estoque: {produto.Estoque}");
            Console.WriteLine($"Valor total em estoque: R${produto.CalculoValorTotalEstoque()}");
            Console.WriteLine($"Disponivel: {produto.Disponibilidade()}");
        }
    }
}
