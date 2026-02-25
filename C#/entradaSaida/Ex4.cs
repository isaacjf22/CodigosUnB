using System.Globalization;

namespace Course
{
    public class Ex4
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' '); 
            int numeroFuncionario = int.Parse(v[0]);
            int horasTrabalhadas = int.Parse(v[1]); 
            double valorHora = double.Parse(v[2],CultureInfo.InvariantCulture); 

            double salario = horasTrabalhadas*valorHora; 

            System.Console.WriteLine($"NUMBER = {numeroFuncionario}");
            System.Console.WriteLine($"SALARY = U$ {salario:F2}",CultureInfo.InvariantCulture);
        }
    }
}