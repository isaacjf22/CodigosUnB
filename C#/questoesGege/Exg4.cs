
namespace Course
{
    public class Exg4
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Qual número você quer ver a sua tabuada de 1 a 10?");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                int resultado = num*i;
                System.Console.WriteLine($" {i} X {num} = {resultado}");
            }
        }
    }
}