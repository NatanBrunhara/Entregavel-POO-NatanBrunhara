using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual
{
    class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }


    class LojaVirtual
    {
        private List<Produto> catalogo = new List<Produto>();

        public void CadastrarProduto(string nome, decimal preco)
        {
            catalogo.Add(new Produto(nome, preco));
            Console.WriteLine($"Produto \"{nome}\" cadastrado com sucesso.");
        }

        public void ExibirCatalogo()
        {
            Console.WriteLine("Catalogo de Produtos:");
            foreach (var produto in catalogo)
            {
                Console.WriteLine($"- {produto.Nome} - R$ {produto.Preco}");
            }
        }

        public List<Produto> CriarCarrinho()
        {
            List<Produto> carrinho = new List<Produto>();
            bool continuar = true;

            while (continuar)
            {
                ExibirCatalogo();
                Console.Write("Digite o nome do produto que deseja adicionar ao carrinho (ou digite 'fim' para finalizar): ");
                string nomeProduto = Console.ReadLine();

                if (nomeProduto.ToLower() == "fim")
                {
                    continuar = false;
                }
                else
                {
                    Produto produtoEncontrado = catalogo.Find(produto => produto.Nome.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase));
                    if (produtoEncontrado != null)
                    {
                        carrinho.Add(produtoEncontrado);
                        Console.WriteLine($"Produto \"{produtoEncontrado.Nome}\" adicionado ao carrinho.");
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado no catálogo.");
                    }
                }
            }

            return carrinho;
        }

        public decimal CalcularTotalCompra(List<Produto> carrinho)
        {
            decimal total = 0;
            foreach (var produto in carrinho)
            {
                total += produto.Preco;
            }
            return total;
        }
    }
}
