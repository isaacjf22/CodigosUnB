// Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar

namespace Course
{
    public class Exc2
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            if ((valor % 2) == 0)
            {
                System.Console.WriteLine("PAR");
            }
            else
            {
                System.Console.WriteLine("IMPAR");
            }
        }
    }
}