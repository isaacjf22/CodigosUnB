// Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
// de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
// ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
// Se o ponto estiver na origem, escreva a mensagem “Origem”.
// Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
// situação.

using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Course
{
    public class Exc7
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' '); 
            double x = double.Parse(v[0]);
            double y = double.Parse(v[1]);

            if(x==0 && y == 0)
            {
                System.Console.WriteLine("Origem");
            }else if (x == 0)
            {
                System.Console.WriteLine("Eixo Y");
            }else if (y == 0)
            {
                System.Console.WriteLine("Eixo X");
            }else if(x>0 && y > 0)
            {
                System.Console.WriteLine("Q1");
            }else if(x<0 && y > 0)
            {
                System.Console.WriteLine("Q2");
            }else if(x<0 && y < 0)
            {
                System.Console.WriteLine("Q3");
            }
            else
            {
                System.Console.WriteLine("Q4");
            }

        }
    }
}