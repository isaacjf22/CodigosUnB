using Impostos.Entities;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> lista = new List<Pessoa>();
        Console.Write("Digite o número de pagantes de impostos: ");
        int n = int.Parse(Console.ReadLine()); 
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"Dados do {i+1}° pagador: ");
            Console.Write("Pessoa física ou jurídica (f/j)? ");
            char esc = char.Parse(Console.ReadLine().ToLower());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Renda Anual: ");
            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (esc == 'f')
            {
                Console.Write("Conta de saúde: ");
                double saude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Pessoa pessoa = new PessoaFisica(nome, renda, saude);
                lista.Add(pessoa);
            } else if (esc == 'j')
            {
                Console.Write("Quantidade de funcionários: ");
                int quantidade = int.Parse(Console.ReadLine());
                Pessoa pessoa = new PessoaJuridica(nome, renda, quantidade);
                lista.Add(pessoa);
            }
            else
            {
                Console.WriteLine("Inválido.");
                continue;
            }
        }
        Console.WriteLine();
        Console.WriteLine("IMPOSTO PAGO");
        double total = 0;
        foreach(Pessoa pessoa in lista)
        {
            Console.WriteLine(pessoa);
            total += pessoa.Imposto();
        }
        Console.WriteLine();
        Console.WriteLine($"Total de imposto: ${total.ToString("F2", CultureInfo.InvariantCulture)}");


    }
}