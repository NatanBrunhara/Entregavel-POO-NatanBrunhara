using Entregavel_POO__pt1_;

namespace Retângulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a largura do seu retângulo em centímetors? : ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a altura do seu retângulo em centímetros?: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Retangulo retangulo = new Retangulo(largura, altura);

            Console.WriteLine($"A Largura do seu retângulo é: {retangulo.Largura}cm");
            Console.WriteLine($"A Altura do seu retângulo é: {retangulo.Altura}cm");
            Console.WriteLine($"A Area do seu retângulo é: {retangulo.CalcularArea()}");
            Console.WriteLine($"O perímetro do seu retângulo é: {retangulo.CalcularPerimetro()}");
        }
    }
}
