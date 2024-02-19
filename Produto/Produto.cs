using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    class Produto
    {
        private string nome;
        private decimal preco;
        private int estoque;

        public Produto(string nome, decimal preco, int estoque) 
        {
            this.nome = nome;
            this.preco = preco;
            this.estoque = estoque;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public int Estoque
        {
            get { return estoque; }
        }

        public decimal CalculoValorTotalEstoque()
        {
            return preco * estoque;
        }

        public bool Disponibilidade()
        {
            return estoque > 0;
        }
    }
}
