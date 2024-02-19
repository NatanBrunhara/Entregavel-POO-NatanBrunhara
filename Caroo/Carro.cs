using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    class Carro
    {
        private string marca;
        private string modelo;
        private double velocidadeAtual;

        public Carro(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.velocidadeAtual = 0;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public double VelocidadeAtual
        {
            get { return velocidadeAtual; }
        }

        public void Ligar(string metodo)
        {
            Console.WriteLine($"Ligando o carro usando {metodo}.");
        }

        public void Acelerar(double quantidade)
        {
            double incremento = 10;
            while (velocidadeAtual < quantidade) 
            {
                velocidadeAtual += incremento;
                if (velocidadeAtual > quantidade)
                    velocidadeAtual = quantidade;
                Console.WriteLine($"Acelerando. Velocidade atual: {velocidadeAtual} km/h");
                Thread.Sleep(500);
            }
        }

        public void Frear()
        {
            Console.WriteLine("\nDeseja frear o carro? (s/n)");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
            {
                while (velocidadeAtual > 0)
                {
                    double quantidadeFreio = Math.Min(10, velocidadeAtual);
                    velocidadeAtual -= quantidadeFreio; // Freia de 10 em 10
                    Console.WriteLine($"Freando. Velocidade atual: {velocidadeAtual} km/h");
                    Thread.Sleep(500); // Oi Gustavo e Oz. Usei aqui para o carro frear a cada 500Ms reduzido sempre 10km/h
                                       // (pra não ficar tãao repetitivo e frear de forma brusca haha.) :D
                }
                Console.Clear();
                Console.WriteLine("Parabéns. Você conseguiu parar o carro por completo!");
            }

           
        }


    }
}
