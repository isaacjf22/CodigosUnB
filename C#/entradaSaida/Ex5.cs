

using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Globalization; 

namespace Course
{
    public class Ex5
    {
        static void Main(string[] args)
        {
            string[] v1 = Console.ReadLine().Split(' '); 
            int codigo1 = int.Parse(v1[0]);
            int quantidade1 = int.Parse(v1[1]); 
            float valorUnitario1 = float.Parse(v1[2],CultureInfo.InvariantCulture);

            float totalPagar = 0; 
            totalPagar += quantidade1*valorUnitario1; 

            string[] v2 = Console.ReadLine().Split(' '); 
            int codigo2 = int.Parse(v2[0]);
            int quantidade2 = int.Parse(v2[1]); 
            float valorUnitario2 = float.Parse(v2[2],CultureInfo.InvariantCulture);

            totalPagar += quantidade2*valorUnitario2; 

            System.Console.WriteLine($"TOTAL A PAGAR: R$ {totalPagar:F2}");
        }
    }
}