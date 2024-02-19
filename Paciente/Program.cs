namespace Paciente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arquivoPaciente = "paciente1.txt";
            Paciente paciente;

            paciente = Paciente.CarregarPaciente(arquivoPaciente);

            if (paciente == null)
            {
                Console.WriteLine("Qual o nome do paciente?: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Qual a idade do paciente?: ");
                int idade = int.Parse(Console.ReadLine());

                paciente = new Paciente(nome, idade);
            }
            Console.WriteLine("Digite sua nova consulta: ");
            string novaConsulta = Console.ReadLine();
            paciente.AdicionarConsulta(novaConsulta);

            paciente.ExibirHistoricoConsultas();
            paciente.SalvarHistorico(arquivoPaciente);

            // Observação do aluno aqui :D: Pro codigo rodar da forma desejada. Preencha a primeira vez conforme pede. 
            // A partir dali ele vai salvar as consultas em um arquivo .TXT. Abração.

        }   
    }
}
