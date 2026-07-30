using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Impostos.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public double Saude { get; set; }

        //construtor 
        public PessoaFisica(string nome, double renda, double saude) : base(nome, renda)
        {
            Saude = saude; 
        }

        //metodo 
        public override double Imposto()
        {
            double imposto=0;
            if (RendaAnual < 20000)
            {
                imposto += (RendaAnual * 0.15);
            }
            else
            {
                imposto += (RendaAnual * 0.25);
            }
            if (Saude != 0)
            {
                imposto -= (Saude / 2);
            }
            return imposto;
        }
    }
}
