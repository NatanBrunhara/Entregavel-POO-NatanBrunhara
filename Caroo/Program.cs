namespace Carro;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ola! Deseja fazer um test drive?.\n");

        Console.Write("Qual a marca do carro?: ");
        string marca = Console.ReadLine();

        Console.Write("E qual o modelo do carro?: ");
        string modelo = Console.ReadLine();

        Carro carro = new Carro(marca, modelo);

        Console.WriteLine($"\nCarro {carro.Marca} {carro.Modelo} criado.");

        carro.Ligar("chave");

        Console.Write("Digite a velocídade atual em km/h: ");
        double aceleracao = Convert.ToDouble(Console.ReadLine());
        carro.Acelerar(aceleracao);


        carro.Frear();
        
    }
}
       
