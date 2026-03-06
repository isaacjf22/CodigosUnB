using System;
using System.Collections.Generic;
using System.Text;

namespace Atividades
{
    internal class Dolar
    {
        public static double iof = 1.06;

        public static double Conversao(double quantidade, double cotacao){ //com static so n precisa instanciar! mas coloca no nomeDaClasse.função....
            return (cotacao * iof) * quantidade;
        }
    }
}
