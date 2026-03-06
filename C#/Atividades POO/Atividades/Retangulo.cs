using System;
using System.Collections.Generic;
using System.Text;

namespace Atividades
{
    internal class Retangulo
    {
        //atributos
        public double Largura;
        public double Altura;

        //metodos 
        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (2 * Largura) + (2 * Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura,2)+Math.Pow(Largura,2));
        }
    }
}
