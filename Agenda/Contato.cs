using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public override string ToString() // Esse tive que pedir ajuda pro chatGPT a melhor forma de implementar,
                                          // não tinha ideia de como fazer da forma que eu queria hahaha.
        {
            return $"Nome: {Nome}, Telefone: {Telefone}";
        }
    }

    class Agenda
    {
        private List<Contato> contatos = new List<Contato>();

        public void AdicionarContato(string nome, string telefone)
        {
            contatos.Add(new Contato(nome, telefone));
            Console.WriteLine($"Contato \"{nome}\" adicionado com sucesso.");
        }

        public void RemoverContato(string nome)
        {
            Contato contato = BuscarContatoPorNome(nome);
            if (contato != null)
            {
                contatos.Remove(contato);
                Console.WriteLine($"Contato \"{nome}\" removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }

        public Contato BuscarContatoPorNome(string nome)
        {
            return contatos.Find(contato => contato.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }

        public Contato BuscarContatoPorTelefone(string telefone)
        {
            return contatos.Find(contato => contato.Telefone.Equals(telefone));
        }

        public void ExibirTodosContatos()
        {
            Console.WriteLine("Lista de Contatos:");
            foreach (var contato in contatos)
            {
                Console.WriteLine(contato);
            }
        }
    }
}
