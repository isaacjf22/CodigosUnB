// Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
// cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
// menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma)

namespace Course
{
    public class Exr2
    {
        static void Main(string[] args)
        {
            int x=1,y=1; //nunca vai entrar no while se n tiver um valor inicializado
            string[] v; 
            while(x!=0 && y != 0)
            {
                v = Console.ReadLine().Split(' '); 
                x = int.Parse(v[0]);
                y = int.Parse(v[1]); 

                if(x>0 && y > 0)
                {
                    System.Console.WriteLine("Primeiro.");
                }
                else if(x<0 && y > 0)
                {
                    System.Console.WriteLine("Segundo.");
                }
                else if(x<0 && y < 0)
                {
                    System.Console.WriteLine("Terceiro");
                }
                else if(x>0 && y < 0)
                {
                    System.Console.WriteLine("Quarto");
                }
            }
        }
    }
}