namespace RedeSocial
{
    class Program
    {
        static void Main(string[] args)
        {
            RedeSocial redeSocial = new RedeSocial();

            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Adicionar amigo");
                Console.WriteLine("2. Publicar mensagem");
                Console.WriteLine("3. Comentar em postagem");
                Console.WriteLine("4. Buscar usuário");
                Console.WriteLine("5. Mostrar timeline");
                Console.WriteLine("6. Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite o seu nome: ");
                        string usuario0 = Console.ReadLine();
                        Console.WriteLine("Digite o nome de quem deseja adicionar: ");
                        string amigo = Console.ReadLine();
                        redeSocial.AdicionarAmigo(usuario0, amigo);
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Digite o seu nome: ");
                        string autor = Console.ReadLine();
                        Console.Write("Digite a mensagem: ");
                        string mensagem = Console.ReadLine();
                        redeSocial.PublicarMensagem(autor, mensagem);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Digite o índice da postagem: ");
                        int indice = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o seu nome?: ");
                        string autorComentario = Console.ReadLine();
                        Console.WriteLine("E qual o seu comentário?: ");
                        string comentario = Console.ReadLine();
                        redeSocial.ComentarPost(indice, autorComentario, comentario);
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Digite o nome do usuário a ser buscado: ");
                        string usuarioBusca = Console.ReadLine();
                        redeSocial.BuscarUsuario(usuarioBusca);
                        break;
                    case 5:
                        Console.Clear();
                        redeSocial.MostrarTimeline();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                      

                }
            }
        }
    }
}
