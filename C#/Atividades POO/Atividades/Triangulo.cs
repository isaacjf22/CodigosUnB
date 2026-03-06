using System;

namespace Atividades
{
    class Triangulo
    {
        public double a;
        public double b;
        public double c;


        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        }
    }
}
