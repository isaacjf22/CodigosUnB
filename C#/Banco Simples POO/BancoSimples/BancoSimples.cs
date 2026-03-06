using BancoSimples;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Banco
{
    class BancoSimples
    {
        static public void Main()
        {
            Conta c; //posso declarar a variavel aq fora e instanciar dentro 
                
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char esc = char.Parse(Console.ReadLine());
            if (esc == 's' || esc == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numeroConta, nome, saldoInicial); //instanciado caso tenha deposito 
            }
            else
            {
                c = new Conta(numeroConta, nome); //instanciando sem deposito 
            }
            Console.WriteLine();

            //deposito
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);
            Console.WriteLine();

            //saque
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);
        }
    }
}