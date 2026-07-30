using Figuras.Entities.Enum;
using System.Globalization;

namespace Figuras.Entities
{
    internal class Retangulo : Figura
    {
        public double Altura { get; set; }
        public double Comprimento { get; set; }

        //construtor 
        public Retangulo(Cores cor, double altura, double comprimento) : base(cor)
        {
            Altura = altura;
            Comprimento = comprimento; 
        }

        //método 
        public override double Area()
        {
            return Altura * Comprimento;
        }

        public override string ToString()
        {
            return Area().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
