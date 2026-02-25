using System.Globalization;

namespace Course
{
    public class Exc8
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double taxaTotal = 0;

            if (salario > 2000 && salario <= 3000)
            {
                taxaTotal= (salario-2000)*0.08;
                System.Console.WriteLine("R$ " + taxaTotal.ToString("F2"));
            }else if(salario>3000 && salario<=4500)
            {
                taxaTotal= 80+(salario-3000)*0.18;
                System.Console.WriteLine("R$ " + taxaTotal.ToString("F2"));
            }else if (salario > 4500)
            {
                taxaTotal = 350+(salario-4500)*0.28;
                System.Console.WriteLine("R$ " + taxaTotal.ToString("F2"));
            }
            else
            {
                System.Console.WriteLine("Isento");
            }
            
        }
    }
}