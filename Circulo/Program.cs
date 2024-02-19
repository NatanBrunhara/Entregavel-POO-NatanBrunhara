namespace Círculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o raio do círculo: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Circulo circulo = new Circulo(raio);

            Console.WriteLine($"Raio do circulo: {circulo.Raio}");
            Console.WriteLine($"Área do circulo: {circulo.CalcularArea()}");
            Console.WriteLine($"Perímetro do circulo: {circulo.CalcularPerimetro()}");

        }
    }
}
