using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeVendas
{
    class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

        public Produto(string nome, decimal preco, int quantidadeEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }
    }

    class MaquinaDeVendas
    {
        private List<Produto> estoque = new List<Produto>();
        private decimal saldoCliente = 0;

        public void CadastrarProduto(string nome, decimal preco, int quantidadeEstoque)
        {
            estoque.Add(new Produto(nome, preco, quantidadeEstoque));
            Console.WriteLine($"Produto \"{nome}\" cadastrado com sucesso.");
        }

        public void ExibirEstoque()
        {
            Console.WriteLine("Estoque Disponível:");
            foreach (var produto in estoque)
            {
                Console.WriteLine($"- {produto.Nome} - R$ {produto.Preco} - Quantidade: {produto.QuantidadeEstoque}");
            }
        }

        public void SelecionarProduto(string nomeProduto)
        {
            Produto produtoSelecionado = estoque.Find(produto => produto.Nome.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase));
            if (produtoSelecionado != null)
            {
                if (produtoSelecionado.QuantidadeEstoque > 0)
                {
                    Console.WriteLine($"Produto \"{produtoSelecionado.Nome}\" selecionado.");
                    Console.WriteLine($"Preço: R$ {produtoSelecionado.Preco}");
                }
                else
                {
                    Console.WriteLine("Produto esgotado.");
                }
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        public void InserirDinheiro(decimal valor)
        {
            saldoCliente += valor;
            Console.WriteLine($"Saldo atual: R$ {saldoCliente}");
        }

        public void RealizarCompra(string nomeProduto)
        {
            Produto produtoSelecionado = estoque.Find(produto => produto.Nome.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase));
            if (produtoSelecionado != null)
            {
                if (produtoSelecionado.QuantidadeEstoque > 0)
                {
                    if (saldoCliente >= produtoSelecionado.Preco)
                    {
                        saldoCliente -= produtoSelecionado.Preco;
                        produtoSelecionado.QuantidadeEstoque--;
                        Console.WriteLine($"Compra realizada com sucesso! Troco: R$ {saldoCliente}");
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente para comprar o produto.");
                    }
                }
                else
                {
                    Console.WriteLine("Produto esgotado.");
                }
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
    }
}
