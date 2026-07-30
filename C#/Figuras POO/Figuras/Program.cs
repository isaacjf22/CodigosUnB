using Figuras.Entities;
using Figuras.Entities.Enum;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Figura> lista = new List<Figura>();
        Console.Write("Entre o número de figuras: ");
        int quantidade = int.Parse(Console.ReadLine());
        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"{i+1}° Figura:");
            Console.Write("Retângulo ou Círculo (r/c)?");
            char esc = char.Parse(Console.ReadLine());
            Console.Write("Cor (Preto/Azul/Vermelho): ");
            Cores cor = Enum.Parse<Cores>(Console.ReadLine().ToUpper());
            if (esc == 'r')
            {
                Console.Write("Comprimento: ");
                double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Altura: ");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Figura figura = new Retangulo(cor, altura, comprimento);
                lista.Add(figura);
            } else if (esc == 'c')
            {
                Console.Write("Raio: ");
                double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Figura figura = new Circulo(cor, raio);
                lista.Add(figura);
            }
            else
            {
                Console.WriteLine("Formato inválido!");
                continue; //pula a figura inválida 
            }
        }
        Console.WriteLine();
        Console.WriteLine("ÁREA DAS FIGURAS");
        foreach(Figura figura in lista)
        {
            Console.WriteLine(figura);
        }
    }
}