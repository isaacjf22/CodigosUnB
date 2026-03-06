using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Atividades
{
    internal class EsferaQuestao
    {
        static public void Executar()
        {
            Console.Clear();
            Esfera e = new Esfera();

            Console.Write("Entre o valor do raio: ");
            e.Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Circunferência: "+ e.Circunferencia().ToString("F2"));
            Console.WriteLine("Volume: "+ e.Volume().ToString("F2"));
            Console.WriteLine("Valor de PI: " + e.Pi.ToString("F2"));
            Console.ReadKey();
        }
    }
}
