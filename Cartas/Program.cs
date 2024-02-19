namespace Cartas
{
    class Program
    {
        static void Main(string[] args)
        {
            JogoCartas jogo = new JogoCartas(4);
            jogo.ExibirMãoJogador(1);
            jogo.ExibirCartaEmbaixoBaralho();
            Console.WriteLine("Escolha uma carta para jogar:");
            int indiceCarta = int.Parse(Console.ReadLine()) - 1;
            jogo.JogarCarta(1, indiceCarta, 1); 
            jogo.ExibirMãoJogador(1);
        }
    }
}   

