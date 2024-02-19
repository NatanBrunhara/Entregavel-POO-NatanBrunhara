using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas
{
    class Carta
    {
        public string Nome { get; set; }
        public int Numero { get; set; }

        public Carta(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;
        }
    }

    class JogoCartas
    {
        private List<Carta> baralho = new List<Carta>();
        private List<List<Carta>> maosJogadores = new List<List<Carta>>();

        public JogoCartas(int numJogadores)
        {
            InicializarBaralho();
            EmbaralharBaralho();
            DistribuirCartas(numJogadores);
        }

        private void InicializarBaralho()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    baralho.Add(new Carta($"Carta {i + 1}", i + 1));
                }
            }
        }

        private void EmbaralharBaralho()
        {
            Random rnd = new Random();
            int n = baralho.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Carta carta = baralho[k];
                baralho[k] = baralho[n];
                baralho[n] = carta;
            }
        }

        private void DistribuirCartas(int numJogadores)
        {
            int cartasPorJogador = 7;
            for (int i = 0; i < numJogadores; i++)
            {
                List<Carta> maoJogador = new List<Carta>();
                for (int j = 0; j < cartasPorJogador; j++)
                {
                    Carta carta = baralho[0];
                    baralho.RemoveAt(0);
                    maoJogador.Add(carta);
                }
                maosJogadores.Add(maoJogador);
            }
        }

        public void ExibirMãoJogador(int jogador)
        {
            Console.WriteLine($"Mão do jogador {jogador}:");
            for (int i = 0; i < maosJogadores[jogador - 1].Count; i++)
            {
                Console.WriteLine($"{i + 1}. {maosJogadores[jogador - 1][i].Nome} ({maosJogadores[jogador - 1][i].Numero})");
            }
            Console.WriteLine();
        }

        public void ExibirCartaEmbaixoBaralho()
        {
            if (baralho.Count > 0)
            {
                Carta cartaEmbaixo = baralho[baralho.Count - 1];
                Console.WriteLine($"Carta embaixo do baralho: {cartaEmbaixo.Nome} ({cartaEmbaixo.Numero})");
            }
            else
            {
                Console.WriteLine("O baralho está vazio.");
            }
            Console.WriteLine();
        }

        public void JogarCarta(int jogador, int indiceCarta, int numeroAtual)
        {
            if (jogador > 0 && jogador <= maosJogadores.Count && indiceCarta >= 0 && indiceCarta < maosJogadores[jogador - 1].Count)
            {
                Carta cartaJogada = maosJogadores[jogador - 1][indiceCarta];
                if (cartaJogada.Numero == numeroAtual)
                {
                    Console.WriteLine($"O jogador {jogador} jogou a carta: {cartaJogada.Nome}");
                    maosJogadores[jogador - 1].RemoveAt(indiceCarta);
                    return;
                }
                else
                {
                    Console.WriteLine("Você não pode jogar essa carta. Compre uma nova carta.");
                }
            }
            else
            {
                Console.WriteLine("Jogada inválida.");
            }
            ComprarCarta(jogador);
        }

        private void ComprarCarta(int jogador)
        {
            if (baralho.Count > 0)
            {
                Carta cartaComprada = baralho[0];
                baralho.RemoveAt(0);
                maosJogadores[jogador - 1].Add(cartaComprada);
                Console.WriteLine($"O jogador {jogador} comprou a carta: {cartaComprada.Nome} ({cartaComprada.Numero})");
            }
            else
            {
                Console.WriteLine("O baralho está vazio. Não é possível comprar mais cartas.");
            }
        }
    }

}
