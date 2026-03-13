using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TransferenciaBancaria;

class Program
{
    static List<ContaBancaria> contas = new List<ContaBancaria>();

    static void Main()
    {
        bool teste = true;


        while (teste)
        {
            int escolha = 99;
            Console.Clear();
            Console.WriteLine("Banco Nordeste-BSB");
            Console.WriteLine(" 1- Criar conta");
            Console.WriteLine(" 2- Transferência entre contas");
            Console.WriteLine(" 3- Apagar conta");
            Console.WriteLine(" 4- Listar contas");
            Console.WriteLine(" 5- Sair");
            Console.Write("--> ");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1: CriarConta();
                    break;
                case 2: TransferênciaContas();
                    break;
                case 3: ApagarConta();
                    break;
                case 4: ListarContas();
                    break;
                case 5: teste = false;
                    break;
            }
        }
    }


    static void CriarConta() //função para criar uma conta 
    {
        Console.Clear();
        Console.WriteLine("Criação de Conta");
        Console.Write("Número da conta: ");
        int numeroConta = int.Parse(Console.ReadLine());
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Saldo de R$100,00 foi definido");
        contas.Add(new ContaBancaria(numeroConta, nome));
        Console.ReadKey();
    }


    static void TransferênciaContas() //função para a transferência 
    {
        Console.Clear();
        if (contas.Count < 2)
        {
            Console.WriteLine("Não há contas suficientes para realizar transação!");
            Console.ReadKey();
            return;
        }
        ContaBancaria transferir;
        ContaBancaria receber;
        Console.WriteLine("Conta que irá transferir: ");
        do
        {
            Console.Write("--> ");
            int contaTrasferir = int.Parse(Console.ReadLine());
            transferir = contas.Find(u => u.Numero == contaTrasferir);
            if (transferir == null) //primeiro null
            {
                Console.WriteLine("Conta não existe! Tente novamente");
            }
            if (transferir.SacarValidacao() == false)
            {
                Console.WriteLine("Essa conta não está valida para realizar transferência.");
                Console.ReadKey();
                return;
            }
        } while (transferir == null);
        Console.Clear();
        Console.WriteLine("Conta que irá receber");
        do
        {
            Console.Write("--> ");
            int contaReceber = int.Parse(Console.ReadLine());
            receber = contas.Find(u => u.Numero == contaReceber);
            if (receber == null)
            {
                Console.WriteLine("Conta não existe! Tente novamente");
            }
        } while (receber == null);
        Console.Clear();
        Console.WriteLine($"Quanto o {transferir.Nome} irá transferir para o {receber.Nome}? ");
        double valor = double.Parse(Console.ReadLine());
        while (valor > transferir.Saldo)
        {
            Console.WriteLine("O valor é a ser transferido é maior que o saldo atual, tente novamente");
            valor = double.Parse(Console.ReadLine());
        }
        transferir.Sacar(valor);
        receber.Depositar(valor);
        Console.WriteLine("Transferência realizado com sucesso!");
        Console.ReadKey();
    } 

    static void ApagarConta()
    {
        ContaBancaria remover;
        Console.Clear();
        Console.WriteLine("Qual é o número da conta que você quer apagar?");
        do
        {
            Console.Write("--> ");
            int numeroRemover = int.Parse(Console.ReadLine());
            remover = contas.Find(u => u.Numero == numeroRemover); //achar quem é pra remover 
            if (remover == null)
            {
                Console.WriteLine("A conta escolhida não existe!");
            }
        } while (remover == null);

        contas.Remove(remover); //a variavel ja guarda a conta a ser removida 

        Console.WriteLine("Conta apagada com sucesso!");
        Console.ReadKey();
    }

    static void ListarContas()
    {
        Console.Clear();
        if (contas.Count == 0)
        {
            Console.WriteLine("Nenhuma conta foi registrada!");
        }
        else
        {
            foreach (ContaBancaria conta in contas)
            {
                Console.WriteLine(conta);
            }
        }
        Console.ReadKey();
    }

}