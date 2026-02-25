

namespace Course
{
    public class Ex3
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' '); //pode escrever tudo numa linha q o split vai dividir
            int a = int.Parse(v[0]);
            int b = int.Parse(v[1]);
            int c = int.Parse(v[2]); 
            int d = int.Parse(v[3]); 

            int diferenca = ((a*b)-(c*d)); 

            System.Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}