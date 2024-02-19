using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregavel_POO__pt1_
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Bem-vindo ao sistema bancário!");

            Console.Write("Digite o número da conta: ");
            int númeroConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Digite o saldo inicial da conta: ");
            double saldoInicial = double.Parse(Console.ReadLine());

            ContaBancaria MyACC = new ContaBancaria(númeroConta, nomeTitular, saldoInicial);

            Console.WriteLine();
            Console.WriteLine($"Conta criada com sucesso: Número {MyACC.NúmeroConta}, Titular: {MyACC.NomeTitular}, Saldo: {MyACC.Saldo:C}");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1. Depósito");
                Console.WriteLine("2. Saque");
                Console.WriteLine("3. Finalizar");

                int opção = int.Parse(Console.ReadLine());

                if (opção == 1)
                {
                    Console.Write("Digite o valor a ser depositado: ");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    MyACC.Depósito(valorDeposito);
                }
                else if (opção == 2)
                {
                    Console.Write("Digite o valor a ser sacado: ");
                    double valorSaque = double.Parse(Console.ReadLine());
                    MyACC.Saque(valorSaque);
                }
                else if (opção == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                }
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços bancários!");
        }

    }
}
