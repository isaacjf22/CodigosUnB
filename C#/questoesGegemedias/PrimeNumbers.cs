using System.Globalization;

namespace Course
{
    public class PrimeNumbers
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Quais são os valores de início e fim da análise de números primos?");
            string[] v = Console.ReadLine().Split(' ');
            int inicio = int.Parse(v[0]);
            int fim = int.Parse(v[1]);
            
            System.Console.WriteLine($"Os números que são primos entre {inicio} e {fim}:");
            for(int i = inicio; i <= fim; i++)//principal vai servir para pegar os numeros q serao analisados 
            {
                if(i<2) continue; //nao considerar negativos, 0 e 1 , continue serve para pular a etapa
                bool primo = true; //consideramos numeros como primos, ai procuramos saber se é verdade ou não
                for(int j = 2; j < i; j++) //esse vai servir analisar se o numero é primo ou nao 
                {
                    if(i % j == 0) //se algum momento dividir, n é primo 
                    {
                        primo=false;
                        break; //n precisar testar o restante , interrompe o for do j
                    }
                }
                if (primo == true)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}