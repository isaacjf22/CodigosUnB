

using System.Numerics;

namespace Course
{
    public class Exc5
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' '); 
            int codigo = int.Parse(v[0]); 
            int quantidade = int.Parse(v[1]);
            double total = 0; 

            switch (codigo)
            {
                case 1: total = quantidade*4.0;
                break;
                case 2: total = quantidade*4.5; 
                break;
                case 3: total = quantidade*5.0; 
                break;
                case 4: total = quantidade*2.0; 
                break;
                case 5: total = quantidade*1.5; 
                break;
            }
            System.Console.WriteLine($"Total: R$ {total:F2}");
        }
    }
}