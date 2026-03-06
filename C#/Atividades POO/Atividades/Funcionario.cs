using System;
using System.Collections.Generic;
using System.Text;

namespace Atividades
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() //aplicado porcentagem ou nao, vai ser descontado o imposto do total 
        {
            return SalarioBruto - Imposto;
        }

        public void AplicarPorcentagem(double Porcentagem)
        {
            double aumento = SalarioBruto * (Porcentagem / 100);
            //aplicando so salario bruto
            SalarioBruto += aumento;

        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2");
        }

    }
}
