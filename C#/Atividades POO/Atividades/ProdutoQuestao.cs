using System;
using System.Globalization;

namespace Atividades
{
    public class ProdutoQuestao
    {
        static public void Executar()
        {
            Produto p;

            p = new Produto(); //para fazer referencia de variavel/metodos , precisa instanciar a classe 

            Console.Clear();
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.quantidadeEstoque = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Dados do produto: {p.nome}, $ {p.preco:F2}, {p.quantidadeEstoque} unidades, Total: $ {p.ValorTotalEmEstoque():F2}");
            //uma forma de imprimir as informações do objeto 
            Console.WriteLine(p); //A formatação ja foi feita pelo ToString na classe do objeto 


            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantidade);
            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantidade);

            //Console.WriteLine($"Dados do produto: {p.nome}, $ {p.preco}, {p.quantidadeEstoque} unidades, Total: $ {p.ValorTotalEmEstoque():F2}");
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
