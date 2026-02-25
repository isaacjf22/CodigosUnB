using System.Globalization; 

namespace Course
{
    public class Ex6
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' ');
            double a = double.Parse(v[0],CultureInfo.InvariantCulture); //base , retangulo 
            double b = double.Parse(v[1],CultureInfo.InvariantCulture); //lado quadrado 
            double c = double.Parse(v[2],CultureInfo.InvariantCulture); //altura, raio 

            double triangulo = (a*c)/2;
            System.Console.WriteLine($"TRIANGULO= {triangulo:F3}");
            double circulo = 3.14159*Math.Pow(c,2); 
            System.Console.WriteLine($"CIRCULO= {circulo:F3}");
            double trapezio = ((a+b)*c)/2;
            System.Console.WriteLine($"TRAPEZIO= {trapezio:F3}");
            double quadrado = Math.Pow(b,2); 
            System.Console.WriteLine($"QUADRADO= {quadrado:F3}");
            double retangulo = a*b; 
            System.Console.WriteLine($"RETANGULO= {retangulo:F3}");
            
        }
    }
}