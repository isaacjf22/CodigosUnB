using System;
using System.Collections.Generic;
using System.Text;

namespace Atividades
{
    internal class Produto
    {
        public string nome;
        public double preco;
        public int quantidadeEstoque; 

        public double ValorTotalEmEstoque()
        {
            return preco * quantidadeEstoque;
        }

        public void AdicionarProdutos(int q)
        {
            quantidadeEstoque += q; 
        }

        public void RemoverProdutos(int q)
        {
            quantidadeEstoque -= q;
        }

        public override string ToString() //é a representação em string desse objeto, quando imprimir , vai vir essa representação 
        {
            return $"Dados do produto: {nome}, $ {preco:F2}, {quantidadeEstoque} unidades, Total: $ {ValorTotalEmEstoque():F2}";
        }
    }
}
