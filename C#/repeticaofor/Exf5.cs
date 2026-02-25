// Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
// Lembrando que, por definição, fatorial de 0 é 1

namespace Course
{
    public class Exf5
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long fat = 1; 
            if (n == 0)
            {
                System.Console.WriteLine(fat);
            }
            else
            {
                for(int i=n; i>=1; i--)
                {
                    fat*=i;
                }
                System.Console.WriteLine(fat);
            }
        }
    }
}