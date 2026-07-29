using System;
using System.Collections.Generic;
using System.Text;

namespace Produtos.Entities
{
    internal class ProdutoImportado : Produto
    {
        public double TaxaImportacao { get; set; }

        //construtores 
        public ProdutoImportado()
        {

        }

        public ProdutoImportado(string nome, double preco, double taxa) : base(nome, preco)
        {
            TaxaImportacao = taxa;
        }

        //métodos 
        public double PrecoTotal()
        {
            return Preco + TaxaImportacao;
        }

        public override string PrecoTag()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append($"{Nome} $ {PrecoTotal().ToString("F2")} (Taxa de importação: $ {TaxaImportacao.ToString("F2")})");
            return sb.ToString();
        }



    }
}
