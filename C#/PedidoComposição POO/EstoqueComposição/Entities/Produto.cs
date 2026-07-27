using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueComposição.Entities
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        //construtores
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

    }
}
