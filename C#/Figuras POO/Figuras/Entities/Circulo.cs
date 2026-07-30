using Figuras.Entities.Enum;
using System.Globalization;

namespace Figuras.Entities
{
    internal class Circulo : Figura
    {
        public double Raio { get; set; }

        //construtor
        public Circulo(Cores cor, double raio) : base(cor)
        {
            Raio = raio; 
        }

        //metodo 
        public override double Area()
        {
            return double.Pi * Math.Pow(Raio, 2);
        }

        public override string ToString()
        {
            return Area().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
