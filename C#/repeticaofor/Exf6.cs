// Ler um número inteiro N e calcular todos os seus divisores

namespace Course
{
    public class Exf6
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}