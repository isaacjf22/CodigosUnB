using System;
using System.Collections.Generic;
using System.Text;


namespace Impostos.Entities
{
    internal class PessoaJuridica : Pessoa
    {
        public int QuantidadeFuncionarios { get; set; }

        //construtor 
        public PessoaJuridica(string nome, double renda, int quantidadeFuncionario) : base(nome, renda)
        {
            QuantidadeFuncionarios = quantidadeFuncionario;
        }

        //metodo
        public override double Imposto()
        {
            double imposto;
            if (QuantidadeFuncionarios <= 10)
            {
                imposto = RendaAnual * 0.16;
            }
            else
            {
                imposto = RendaAnual * 0.14;
            }
            return imposto;
        }

    }
}
