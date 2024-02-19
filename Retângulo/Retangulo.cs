using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregavel_POO__pt1_
{
    class Retangulo
    {
        private double largura;
        private double altura;

        public Retangulo(double largura, double altura) 
        { 
            this.largura = largura;
            this.altura = altura;
        }
        public double Largura
        { 
            get { return largura; } 
            set { largura = value; }
        }
        public Double Altura
        {
            get { return altura; }
            set {  altura = value; }
        }

        public double CalcularArea()
        {
            return largura * altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (largura * altura);
        }


    }   
}
