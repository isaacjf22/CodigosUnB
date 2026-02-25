// Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
// X, se for o caso.

namespace Course
{
    public class Exf1
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()); 
            int i;
            for (i = 1; i <= x; i++)
            {
                if (i % 2 != 0) //analise se é impar  
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}