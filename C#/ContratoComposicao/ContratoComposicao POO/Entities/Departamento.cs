using System;
using System.Collections.Generic;
using System.Text;

namespace ContratoComposicao.Entities
{
    internal class Departamento
    {
        public string Nome { get; private set; }

        //construtor
        public Departamento(string nome)
        {
            Nome = nome; 
        }

        //overrides 
        public override string ToString()
        {
            return $"{Nome}";
        }

    }
}
