using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregavel_POO__pt1_
{
    class ContaBancaria
    {
        private int númeroConta;
        private string nomeTitular;
        private double saldo;

        public ContaBancaria(int númeroConta, string nomeTitular, double saldoInicial)
        {
            this.númeroConta = númeroConta;
            this.nomeTitular = nomeTitular;
            this.saldo = saldoInicial;
        }

        public int NúmeroConta
        {
            get { return númeroConta; }
            set { númeroConta = value; }
        }

        public string NomeTitular
        {
            get { return nomeTitular; }
            set { nomeTitular = value; }
        }

        public double Saldo
        {
            get { return saldo; }
        }

        public void Depósito(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado com sucesso. Novo saldo: {saldo:C}");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser maior que zero.");
            }
        }

        public void Saque(double valor)
        {
            if (valor > 0)
            {
                if (valor <= saldo)
                {
                    saldo -= valor;
                    Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Novo saldo: {saldo:C}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para realizar o saque.");
                }
            }
            else
            {
                Console.WriteLine("O valor do saque deve ser maior que zero.");
            }
        }
    }

   
}
