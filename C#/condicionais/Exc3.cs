// Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
// Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
// ordem crescente ou decrescente.

namespace Course
{
    public class Exc3
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' ');
            int a = int.Parse(v[0]);
            int b = int.Parse(v[1]);

            if ((a % b == 0) || (b%a==0))
            {
                System.Console.WriteLine("Sao Multiplos");
            }
            else
            {
                System.Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}