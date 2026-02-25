namespace Course
{
    public class Exr4
    {
        static void Main(string[] args)
        {
            int hpBoneco=100;
            int tentativas=0;
            int danoGolpe;
            while (hpBoneco > 0)
            {
                System.Console.WriteLine("Insira o dano do golpe");
                danoGolpe = int.Parse(Console.ReadLine());
                if (danoGolpe > 0) //conseguiu dar dano 
                {
                    hpBoneco-=danoGolpe;
                    System.Console.WriteLine($"HP do boneco restante {hpBoneco}");
                    tentativas++;
                }
                else
                {
                    System.Console.WriteLine("Golpe inválido, tente novamente");
                }
            }
            System.Console.WriteLine($"Boneco destruído! Treinamento concluído em {tentativas} tentativas.");
        }
    }
}