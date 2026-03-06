using System.Globalization;

namespace Atividades
{
    public class TrianguloQuestao
    {
        public static void Executar() //para fazer referencia sem instanciar objeto , so colocar o static 
        {
            Console.Clear();
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();
            
            Console.WriteLine("Quais são os valores dos lados do triângulo X ?");
            x.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areaX = x.Area();

            Console.WriteLine("Quais são os valores dos lados do triângulo Y ?");
            y.a = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            y.b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            y.c = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double areaY = y.Area();
             
            Console.WriteLine("Área de X = " + areaX.ToString("F4"));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4"));
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
            Console.ReadKey();

        }
    }
}