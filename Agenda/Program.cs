namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            while (true)
            {
                Console.WriteLine("\nOpções:");
                Console.WriteLine("1. Adicionar Contato");
                Console.WriteLine("2. Remover Contato");
                Console.WriteLine("3. Exibir Todos os Contatos");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Digite o nome do contato: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite o telefone do contato: ");
                        string telefone = Console.ReadLine();
                        agenda.AdicionarContato(nome, telefone);
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("Digite o nome do contato que deseja remover: ");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemoverContato(nomeRemover);
                        break;
                    case "3":
                        Console.Clear();
                        agenda.ExibirTodosContatos();
                        break;
                    case "4":
                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
