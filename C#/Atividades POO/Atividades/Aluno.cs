using System;
using System.Collections.Generic;
using System.Text;

namespace Atividades
{
    internal class Aluno
    {
        public string Nome;
        public double nota1, nota2, nota3;

        public double NotaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        public void Resultado()
        {
            if (NotaFinal() >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {60-NotaFinal():F2} PONTOS");
            }
        }
    }
}
