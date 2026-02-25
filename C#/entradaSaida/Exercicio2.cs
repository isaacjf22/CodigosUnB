using System.Globalization;

namespace Course
{
    public class Exercicio2
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entre com seu nome completo: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //o culture é para considerar o . tbm quando for colocar numero decimal
            System.Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha)"); //para fazer a quebra de dados , precisa usar o split 
            string[] v = Console.ReadLine().Split(' '); //a entrada de dados precisa obedecer uma ordem, se nao da erro 
            string ultimoNome = v[0];
            int idade = int.Parse(v[1]); 
            float altura = float.Parse(v[2], CultureInfo.InvariantCulture);  //considerar o . 
            System.Console.WriteLine("");
            System.Console.WriteLine(name);
            System.Console.WriteLine(quartos);
            System.Console.WriteLine(preco.ToString("F2"));
            System.Console.WriteLine(v[0]);
            System.Console.WriteLine(v[1]);
            System.Console.WriteLine(v[2], CultureInfo.InvariantCulture); 
        }
    }
}