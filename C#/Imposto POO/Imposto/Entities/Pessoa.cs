using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization; 

namespace Impostos.Entities
{
    internal abstract class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        //construtor 
        public Pessoa(string nome, double renda)
        {
            Nome = nome;
            RendaAnual = renda;
        }

        public abstract double Imposto();

        public override string ToString()
        {
            return $"{Nome}: $ {Imposto().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
