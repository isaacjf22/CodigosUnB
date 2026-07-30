using Figuras.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras.Entities
{
    abstract class Figura
    {
        public Cores Cor { get; set; }

        //construtor 
        public Figura(Cores cor)
        {
            Cor = cor; 
        }

        //método 
        public abstract double Area(); //todas as classes que herdarem serão obrigadas a implementar 

    }
}
