// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
// casas decimais conforme exemplos.
// Fórmula da área: area = π . raio2
// Considere o valor de π = 3.14159

using System.Reflection;
using System.Globalization;

namespace Course
{
    public class Ex2
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = (3.14159)*Math.Pow(raio,2); 

            System.Console.WriteLine($"A={area:F4}",CultureInfo.InvariantCulture);

        }
    }
}