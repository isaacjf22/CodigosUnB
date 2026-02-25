// Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

namespace Course
{
    public class Exc1
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            if (valor < 0)
            {
                System.Console.WriteLine("NEGATIVO");
            }
            else
            {
                System.Console.WriteLine("NAO NEGATIVO");
            }


        }
    }
}