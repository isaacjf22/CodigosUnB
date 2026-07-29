using System;
using System.Collections.Generic;
using System.Text;

namespace Produtos.Entities
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        //construtores 
        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco; 
        }

        //métodos 
        public virtual string PrecoTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Nome} $ {Preco.ToString("F2")}");
            return sb.ToString();
        }
    }
}
