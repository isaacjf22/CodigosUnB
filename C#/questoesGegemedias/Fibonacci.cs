using System.Data;

namespace Course
{
    public class Fibonacci
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Quantos termos você quer ver da sequência de Fibonacci?");
            int max = int.Parse(Console.ReadLine());
            int a=0; //mostrando a atual
            int b=1; //guardando o proximo
            
            for(int i = 0; i <= max; i++)
            {
                System.Console.WriteLine(a);

                int proximo = a+b; //preparando o 'proximo'
                a=b; //pegando o proximo para mostrar 
                b=proximo; //pegando o proximo para depois mostrar 
                // 1° a , 2° b , 3° proximo=a+b
            }
        }
    }
}