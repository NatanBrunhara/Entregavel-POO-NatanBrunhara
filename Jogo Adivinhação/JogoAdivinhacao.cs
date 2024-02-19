using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Adivinhação
{
    class JogoAdivinhacao
    {
        private int numeroSecreto;
        private bool acertou;

        public JogoAdivinhacao()
        {
            Random random = new Random();
            numeroSecreto = random.Next(1, 11);
            acertou = false;
        }

        public void Jogar()
        {
            Console.WriteLine("Ola! Vamos adivinhar um numero?");
            Console.WriteLine("\n Tente adivinhar um número secreto entre 1 e 10.");

            while (!acertou)
            {
                Console.Write("Digite seu palpite: ");
                int palpite = int.Parse(Console.ReadLine());

                if (palpite == numeroSecreto)
                {
                    Console.WriteLine("Parabéns! :D Você acertou o número secreto!");
                    acertou = true;
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("Foi quase hein. O número secreto é maior que o palpite :(.");
                }
                else
                {
                    Console.WriteLine("Foi quase hein. O número secreto é menor que o palpite :(.");
                }
            }
        }
    }
}
