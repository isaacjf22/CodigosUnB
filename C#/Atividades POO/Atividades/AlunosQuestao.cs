using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Globalization;

namespace Atividades
{
    internal class AlunosQuestao
    {
        static public void Executar()
        {
            Aluno a = new Aluno(); //instanciado a classe 
            Console.Clear();
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL = "+a.NotaFinal().ToString("F2"));
            a.Resultado();
            Console.ReadKey();
        }
    }
}
