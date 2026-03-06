using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Atividades
{
    internal class DolarQuestao
    {
        public static void Executar()
        {
            Console.Clear();
            double cotacao;
            double quantidadeDolar;

            Console.Write("Qual é a cotação do dólar? ");
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            quantidadeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total = Dolar.Conversao(quantidadeDolar, cotacao);
            Console.WriteLine("Valor a ser pago em reais = "+total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
