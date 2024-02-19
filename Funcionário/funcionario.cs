using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionário
{
    class Funcionario
    {
        private string nome;
        private decimal salario;
        private string cargo;
        private const decimal beneficio = 500;
        public decimal descontoImposto = 0.20m; 

        public Funcionario(string nome, decimal salario, string cargo)
        {
            this.nome = nome;
            this.salario = salario;
            this.cargo = cargo;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public decimal Beneficio
        {
            get { return beneficio; }
        }

        public decimal CalculoSalario()
        {
            decimal salarioLiquido = salario - (salario * descontoImposto) + beneficio;
            return salarioLiquido;
        }

    }
}
