using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    class Pessoa
    {
        private string nome;
        private int idade;
        private string profissao;

        public Pessoa(string nome, int idade, string profissao) 
        {
            this.nome = nome;
            this.idade = idade;
            this.profissao = profissao;
        }
        public int IdadeBissexto(int anoAtual)
        {
            int anosBissexto = anoAtual / 4 - anoAtual / 100 + anoAtual / 400;

            return idade + anosBissexto;
        }
        public void Informações()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Profissão: {profissao}");
        }

    }
}
