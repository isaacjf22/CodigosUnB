using ContratoComposicao.Entities;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nome do departamento: ");
        string departamento = Console.ReadLine();
        Console.WriteLine("Entre com os dados do trabalhador: ");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Nível (Junior/Pleno/Senior): ");
        string nivel;
        do //validação da escolha de nivel 
        {
            nivel = Console.ReadLine();
            if(nivel != "Junior" && nivel != "Pleno" && nivel != "Senior")
            {
                Console.WriteLine("Escolha inválida! Tente novamente");
                Console.Write("Nível (Junior/Pleno/Senior): ");
            }
        } while (nivel != "Junior" && nivel != "Pleno" && nivel != "Senior");
        Console.Write("Salário Base: ");
        double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Trabalhador trabalhador = new Trabalhador(nome, nivel, salarioBase, departamento);
        Console.Write("Quantos contratos serão registrados desse trabalhador? ");
        int quantidade = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Entre os dados do {i+1}° contrato:");
            Console.Write("Data (DD/MM/YYYY): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor por hora: ");
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Duração(horas): ");
            int horas = int.Parse(Console.ReadLine());
            Contrato contrato = new Contrato(data, valorPorHora, horas);
            trabalhador.AdicionarContrato(contrato); //adicionando o contrato na lista 
        }
        Console.WriteLine();
        Console.Write("Entre o ano e mês para calcular a renda total do período (MM/YYYY): ");
        string[] vetor = Console.ReadLine().Split("/"); //vai dividir os dados quando aparecer a / 
        int mes = int.Parse(vetor[0]);
        int ano = int.Parse(vetor[1]);
        Console.WriteLine(trabalhador);
        Console.WriteLine($"Renda total de {vetor[0]}/{vetor[1]}: {trabalhador.Total(ano,mes).ToString("F2")}");


    }
}