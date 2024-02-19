using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paciente
{
    class Paciente
    {
        private string nome;
        private int idade;
        private List<string> historicoConsultas;

        public Paciente(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            this.historicoConsultas = new List<string>();
        }

        // Adicionando construtor que aceita somente o nome
        public Paciente(string nome)
        {
            this.nome = nome;
            this.idade = 0;
            this.historicoConsultas = new List<string>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public List<string> HistoricoConsultas
        {
            get { return historicoConsultas; }
        }

        public void AdicionarConsulta(string consulta)
        {
            historicoConsultas.Add(consulta);
        }

        public void ExibirHistoricoConsultas()
        {
            Console.WriteLine($"Histórico de consultas do paciente {nome} ({idade} anos):");
            foreach (string consulta in historicoConsultas)
            {
                Console.WriteLine(consulta);
            }
        }

        public void SalvarHistorico(string nomeArquivo)
        {
            using (StreamWriter writer = new StreamWriter(nomeArquivo))
            {
                writer.WriteLine($"{nome},{idade}");
                foreach (string consulta in historicoConsultas)
                {
                    writer.WriteLine(consulta);
                }
            }
        }

        public static Paciente CarregarPaciente(string nomeArquivo)
        {
            try
            {
                using (StreamReader reader = new StreamReader(nomeArquivo))
                {
                    string[] dadosPaciente = reader.ReadLine().Split(',');
                    string nome = dadosPaciente[0];
                    int idade = int.Parse(dadosPaciente[1]);
                    Paciente paciente = new Paciente(nome, idade);
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        paciente.AdicionarConsulta(linha);
                    }
                    return paciente;
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo não encontrado. Criando novo paciente...");
                return null;
            }
        }

    }
}

