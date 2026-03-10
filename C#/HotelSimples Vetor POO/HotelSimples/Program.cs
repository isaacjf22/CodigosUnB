
using HotelSimples;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos quartos serão alugados? ");
        int alugados = int.Parse(Console.ReadLine());

        Aluguel[] a = new Aluguel[10]; //criando o vetor da classe aluguel , so 10 quartos logo 10 o tamanho 

        int quarto; //definindo o quarto escolhido 

        Console.WriteLine();
        for(int i = 0; i < alugados; i++)
        {

            Console.WriteLine("Aluguel " + (i + 1) + "#:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Quarto: ");
            quarto = int.Parse(Console.ReadLine());
            a[quarto] = new Aluguel(nome, email); //instanciado o objeto aluguel 
            Console.WriteLine();
        }

        Console.WriteLine("Quartos ocupados: ");
        for(int i=0;i<a.Length;i++) //aqui vai ser realizado a impressao analisando o vetor do Aluguel 
        {
            if (a[i] == null) //se n tiver nada no elemento, pula e continua 
            {
                continue;
            }
            else // se nao faz a impressao doq tem la 
            {
                Console.WriteLine($"{i}: {a[i].Nome}, {a[i].Email}");
            }
        }
    }
}