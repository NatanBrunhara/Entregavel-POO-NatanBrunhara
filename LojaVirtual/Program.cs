namespace LojaVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            LojaVirtual loja = new LojaVirtual();
            loja.CadastrarProduto("Camiseta", 29.99m);
            loja.CadastrarProduto("Calça Jeans", 59.99m);
            loja.CadastrarProduto("Tênis", 99.99m);

            List<Produto> carrinho = loja.CriarCarrinho();

            Console.WriteLine("\nProdutos no Carrinho:");
            foreach (var produto in carrinho)
            {
                Console.WriteLine($"- {produto.Nome} - R$ {produto.Preco}");
            }

            decimal totalCompra = loja.CalcularTotalCompra(carrinho);
            Console.WriteLine($"\nTotal da Compra: R$ {totalCompra}");
        }
    }
}
