namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do lado 1: ");
            double lado0 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o tamanho do lado 2: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o tamanho do lado 3: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Triangulo triangulo = new Triangulo(lado0, lado1, lado2);

            
            if (triangulo.TrianguloValido())
            {
                // Calculando e exibindo a área do triângulo
                double area = triangulo.CalculoArea();
                Console.WriteLine($"\nÁrea do triângulo: {area}");
            }
            else
            {
                Console.WriteLine("\nOs lados informados não formam um triângulo válido.");
            }
        }
    }
}
