// Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
// de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
// conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
// peso 5.

using System.Globalization;

namespace Course
{
    public class Exf3
    {
        static void Main(string[] args)
        {
            int i;
            int n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                double mediaP; 
                double v1,v2,v3;
                string[] v = Console.ReadLine().Split(' ');
                v1 = double.Parse(v[0],CultureInfo.InvariantCulture);
                v2 = double.Parse(v[1],CultureInfo.InvariantCulture);
                v3 = double.Parse(v[2],CultureInfo.InvariantCulture);

                mediaP = ((v1*2)+(v2*3)+(v3*5))/10;
                System.Console.WriteLine(mediaP.ToString("F1"));
            }
        }
    }
}