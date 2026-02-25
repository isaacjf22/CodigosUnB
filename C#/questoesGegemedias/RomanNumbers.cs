namespace Course
{
    public class RomamNumbers
    {
        static void Main(string[] args)
        {
            //fazendo uma relação dos valores com os simbolos 
            int[] valores = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1}; 
            string[] simbolos = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};

            System.Console.WriteLine("Qual número você deseja converter para número romano? 1 a 4999");
            int numero = int.Parse(Console.ReadLine());
            int numeroUsado = numero;
            string resultado = ""; //para formar o número romano

            for(int i = 0; i < valores.Length; i++)  
            {
                while (numeroUsado >= valores[i])
                {
                    resultado+=simbolos[i]; //formando o numero romano 
                    numeroUsado-=valores[i]; //vai tirando parte do valor para considerar outras partes, 
                }
            }

            System.Console.WriteLine($"O valor {numero} em número romano é : {resultado}");
        }
    }
}