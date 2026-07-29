using Funcionarios.Entities;
using System.Collections.Generic;
using System.Globalization;

class Programn
{
    static void Main(string[] args)
    {
        List<Empregado> empregados = new List<Empregado>();
        Console.Write("Entre com a quantidade de empregados que serão registrados: ");
        int quantidade = int.Parse(Console.ReadLine()); 

        for(int i=1; i <= quantidade; i++)
        {
            Console.WriteLine($"{i}° Empregado informações:");
            Console.Write("Tercerizado (s/n)? ");
            char esc = char.Parse(Console.ReadLine().ToLower());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Horas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Valor por hora: ");
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (esc == 's')
            {
                Console.Write("Custos adicionais: ");
                double custos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Empregado empregado = new EmpregadoTercerizado(nome, horas, valorPorHora, custos); //polimorfismo 
                empregados.Add(empregado); 
            }
            else
            {
                Empregado empregado = new Empregado(nome, horas, valorPorHora);
                empregados.Add(empregado);
            }
        }
        Console.WriteLine();
        Console.WriteLine("PAGAMENTOS:");
        foreach(Empregado emp in empregados)
        {
            Console.WriteLine(emp);
        }

    }
}