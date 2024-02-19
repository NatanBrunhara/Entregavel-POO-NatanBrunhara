using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendário
{
    class Calendario
    {
        public void ExibirCalendario(int ano, int mes)
        {
            DateTime dataInicial = new DateTime(ano, mes, 1);
            DateTime dataFinal = dataInicial.AddMonths(1).AddDays(-1);

            Console.WriteLine($"Calendário do mês {mes} de {ano}:");
            Console.WriteLine();

            Console.WriteLine("  Dom Seg Ter Qua Qui Sex Sáb");

            for (int i = 1; i <= dataFinal.Day; i++)
            {
                DateTime dataAtual = new DateTime(ano, mes, i);
                if (i == 1)
                {
                    int diaSemana = (int)dataAtual.DayOfWeek;
                    Console.Write(new string(' ', 4 * diaSemana));
                }

                Console.Write($"{i,3} ");

                if (dataAtual.DayOfWeek == DayOfWeek.Saturday)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }

        public bool VerificarFeriado(DateTime data)
        {
            // Aqui você pode implementar a lógica para verificar se a data é um feriado
            // Por enquanto, vamos apenas retornar false
            return false;
        }

        public int CalcularDiferencaDias(DateTime data1, DateTime data2)
        {
            TimeSpan diferenca = data2.Date - data1.Date;
            return Math.Abs(diferenca.Days);
        }
    }
}
