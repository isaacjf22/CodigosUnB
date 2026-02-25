// Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
// Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
// essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo)

using System.Net;

namespace Course
{
    public class Exf2
    {
        static void Main(string[] args)
        {
            int dentro=0,fora=0;
            int i;
            int fila = int.Parse(Console.ReadLine());

            for (i = 0; i < fila; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if(n>=10 && n <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            System.Console.WriteLine(dentro + " in");
            System.Console.WriteLine(fora + " out");
        }
    }
}