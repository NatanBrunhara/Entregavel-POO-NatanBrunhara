namespace Calendário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calendario calendario = new Calendario();

            Console.Write("Digite o ano desejado: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Digite o número do mês desejado: ");
            int mes = int.Parse(Console.ReadLine());

            calendario.ExibirCalendario(ano, mes);

            Console.WriteLine("Digite uma data para verificar se é feriado (formato: dd/MM/yyyy):");
            string entrada = Console.ReadLine();
            DateTime dataVerificar = DateTime.ParseExact(entrada, "dd/MM/yyyy", null);
            bool feriado = calendario.VerificarFeriado(dataVerificar);
            Console.WriteLine($"A data {entrada} é feriado? {feriado}");

            Console.WriteLine("Digite duas datas para calcular a diferença entre elas (formato: dd/MM/yyyy):");
            Console.Write("Data 1: ");
            string data1Str = Console.ReadLine();
            Console.Write("Data 2: ");
            string data2Str = Console.ReadLine();

            DateTime data1 = DateTime.ParseExact(data1Str, "dd/MM/yyyy", null);
            DateTime data2 = DateTime.ParseExact(data2Str, "dd/MM/yyyy", null);

            int diferencaDias = calendario.CalcularDiferencaDias(data1, data2);
            Console.WriteLine($"Diferença de dias entre {data1.ToShortDateString()} e {data2.ToShortDateString()}: {diferencaDias} dias");
        }
    }
}
