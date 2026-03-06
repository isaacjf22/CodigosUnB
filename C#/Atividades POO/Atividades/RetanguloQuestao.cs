using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Atividades
{
    internal class RetanguloQuestao
    {
        static public void Executar()
        {
            Console.Clear();
            Retangulo x = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("AREA = " + x.Area().ToString("F2"));
            Console.WriteLine("PERÍMETRO = " + x.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL = " + x.Diagonal().ToString("F2"));
            Console.ReadKey();
        }
    }
}
