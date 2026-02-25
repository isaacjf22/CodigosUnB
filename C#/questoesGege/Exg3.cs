

namespace Course
{
    public class Exg3
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite uma frase para análise: ");
            string frase = Console.ReadLine().ToLower();
            Console.Clear();
            System.Console.WriteLine("Qual letra você quer verificar quantas tem na frase digitada?");
            char letra = char.Parse(Console.ReadLine().ToLower());
            int contador=0;

            foreach(char letras in frase)
            {
                if(letras == letra)
                {
                    contador++;
                }
            }

            System.Console.WriteLine($"A letra {letra} aparece {contador} vez(es) na frase.");
        }
    }
}