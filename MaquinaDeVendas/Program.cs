namespace MaquinaDeVendas
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                MaquinaDeVendas máquina = new MaquinaDeVendas();
                máquina.CadastrarProduto("Refrigerante", 5.0m, 10);
                máquina.CadastrarProduto("Chocolate", 3.0m, 8);
                máquina.CadastrarProduto("Salgadinho", 2.5m, 15);

                máquina.ExibirEstoque();

                máquina.InserirDinheiro(10.0m);
                máquina.SelecionarProduto("Refrigerante");
                máquina.RealizarCompra("Refrigerante");

                máquina.ExibirEstoque();
            }
        }
    }
}
