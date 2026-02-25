

namespace Course
{
    public class Exg5
    {
        static void Main(string[] args)
        {
            Random random = new Random(); //criando o random 
            int numeroSecreto = random.Next(1,101);
            System.Console.WriteLine("JOGO DE ADIVINHAÇÃO");
            System.Console.WriteLine("Tente descobrir um valor entre 1 a 100: ");
            int entrada = int.Parse(Console.ReadLine());
            int tentativa = 1;
            while (entrada != numeroSecreto)
            {
                System.Console.WriteLine("Número incorreto, tente novamente!");
                if (entrada > numeroSecreto)
                {
                    System.Console.WriteLine("O número é menor!");
                }else if (entrada < numeroSecreto)
                {
                    System.Console.WriteLine("O número é maior");
                }
                tentativa++;
                entrada = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Parabéns, você acertou! Em " + tentativa + " tentativa(s)");
        }
    }
}