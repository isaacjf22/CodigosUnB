using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Produtos.Entities
{
    internal class ProdutoUsado : Produto
    {
        public DateTime DataFabricado { get; set; }

        //construtores 
        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime data) : base(nome, preco)
        {
            DataFabricado = data;
        }

        //métodos 
        public override string PrecoTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Nome} (usado) $ {Preco.ToString("F2")} (data de fabricação: {DataFabricado.ToString("dd/MM/yyyy")})");
            return sb.ToString();
        }
    }
}
