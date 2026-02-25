

using System.Text;

namespace Course
{
    public class Exf4
    {
        static void Main(string[] args)
        {
            int i;
            int n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                double n1 = double.Parse(v[0]);
                int n2 = int.Parse(v[1]);
                if (n2 == 0)
                {
                    System.Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double resultado = n1/n2;
                    System.Console.WriteLine(resultado.ToString("F1"));
                }
            }

        }
    }
}