using System;
using System.Collections.Generic;
namespace EstoqueComposição.Entities
{
    internal class ItemPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; private set; }

        public Produto Product { get; set; }

        //construtor 
        public ItemPedido(int quantidade, Produto product)
        {
            Quantidade = quantidade;
            Product = product;
            Preco = product.Preco;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }
    }
}
