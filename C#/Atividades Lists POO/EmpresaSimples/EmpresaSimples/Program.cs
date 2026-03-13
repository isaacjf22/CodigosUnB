using EmpresaSimples;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        List<Funcionario> f = new List<Funcionario>(); //criando a lista

        Console.WriteLine("Quantos funcionários irão ser registrados?");
        int quantidadeFuncionario = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //entrada de funcionarios 
        for(int i = 0; i < quantidadeFuncionario; i++)
        {
            Console.WriteLine($"Digite os dados do {i+1}° funcionário: ");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            if(f.Any(u => u.Id == id)) //u representa os elementos dentro da lista 
            {
                Console.WriteLine("ID já registrado, tente novamente!");
                i--; //volta para repetir a vez 
                continue;
            }
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.Add(new Funcionario(id, nome, salario)); //adicionando na lista e instanciado o objeto de uma vez
            Console.WriteLine();
        }

        Console.Write("Entre o ID do funcionário que vai ter o salário aumentado: ");
        int idEscolhido = int.Parse(Console.ReadLine());

        Funcionario funcionarioEscolhido = f.Find(u => u.Id == idEscolhido); //guardando o funcionario escolhido para analise 

        if (funcionarioEscolhido==null) //se NÃO tiver o id 
        {
            Console.WriteLine("Esse ID não existe!");
        }
        else
        {
            Console.Write("Digite a porcentagem de aumento: ");
            double porcentagem = double.Parse(Console.ReadLine());
            funcionarioEscolhido.AumentarSalario(porcentagem);
        }

        Console.WriteLine();

        Console.WriteLine("Lista atualizada de funcionários: ");
        foreach(Funcionario pessoa in f)
        {
            Console.WriteLine(pessoa);
        }

    }
}