using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Xml;

namespace Atividades
{
    internal class FuncionarioQuestao
    {
        static public void Executar()
        {
            Console.Clear();
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: "+f);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AplicarPorcentagem(porcentagem);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: "+f);
            Console.ReadKey();
        }
    }
}
