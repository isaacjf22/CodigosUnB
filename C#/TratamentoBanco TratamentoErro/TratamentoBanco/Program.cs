using System.Globalization;
using TratamentoBanco.Entities;
using TratamentoBanco.Exceptions;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Entre os dados da conta: ");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Inicial deposito: ");
            double inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Limite de saque: ");
            double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta conta = new Conta(numero, nome, inicial, limite);
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Valor de saque a ser realizado: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine(conta);
        }
        catch(DomainException erro)
        {
            Console.WriteLine("Error: " + erro.Message); //tem q colocar a message 
        }
        catch(FormatException erro)
        {
            Console.WriteLine("Error: Dado de entrada inválido");
        }
    }
}