using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregavel_POO__pt1_
{
    class Aluno
    {
        private string nome;
        private int matricula;
        private List<double> notas;

        public Aluno(string nome, int matricula, List<double> notas)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.notas = notas;
        }

        public Aluno(string nome, int matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.notas = new List<double>();
        }

        public void AdicionarNota(double nota)
        {
            notas.Add(nota);
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public List<double> Notas
        {
            get { return notas; }
        }

        public double CalcularMedia()
        {
            if (notas.Count == 0)
                return 0;

            double soma = 0;
            foreach (double nota in notas)
            {
                soma += nota;
            }

            return soma / notas.Count;
        }

        public string VerificarSituacao()
        {
            double media = CalcularMedia();

            if (media >= 6.0)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";

            }

        }

    }
}
    
