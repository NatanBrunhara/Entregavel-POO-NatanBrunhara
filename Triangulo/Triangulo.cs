using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Triangulo
    {
        private double lado0;
        private double lado1;
        private double lado2;

        public Triangulo(double lado0, double lado1, double lado2) 
        { 
            this.lado0 = lado0;
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        public double Lado0
        {
            get { return lado0; }
            set { lado0 = value; }
        }

        public double Lado1
        { 
            get { return lado1; } 
            set {  lado1 = value; } 
        }

        public double Lado2
        {
            get { return lado2; } 
            set {  lado2 = value; } 
        }
        public bool TrianguloValido()
        {
            return (lado0 + lado1 > lado2) && (lado0 + lado2 > lado1) && (lado1 + lado2 > lado0);
        }

        public double CalculoArea()
        {
            double perimetro = (lado0 + lado1 + lado2) / 2;
            double area = Math.Sqrt(perimetro * (perimetro - lado0) * (perimetro - lado1) * (perimetro - lado2));
            return area;
        }
    }
}
