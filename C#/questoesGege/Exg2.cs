

namespace Course
{
    public class Exg2
    {
        static void Main(string[] args)
        {
            char escolha =' '; 
            while(escolha!='n' && escolha != 'N')
            {
                System.Console.WriteLine("Digites a nota das três provas: ");
                string[] v = Console.ReadLine().Split(' ');
                double n1 = double.Parse(v[0]);
                double n2 = double.Parse(v[1]);
                double n3 = double.Parse(v[2]);

                double media = (n1+n2+n3)/3;

                System.Console.WriteLine($"A sua média simples foi: {media:F2}");
                System.Console.WriteLine("Deseja calcular outra média? S-SIM ou N-NÃO");
                
                do{
                    escolha = char.Parse(Console.ReadLine());
                }while(escolha!='N' && escolha!='n' && escolha!='S' && escolha!='s');
            }
        }
    }
}