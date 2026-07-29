using System.Globalization;
using System.Collections.Generic;
using Produtos.Entities;

class Program
{
    static void Main(string[] args)
    {
        List<Produto> lista = new List<Produto>();
        Console.Write("Entre o número de produtos: ");
        int quantidade = int.Parse(Console.ReadLine());

        for(int i = 1; i <= quantidade; i++)
        {
            Produto produto; 
            Console.WriteLine($"Informação do {i}° produto: ");
            Console.Write("Comum, usado ou importado (c/u/i)? ");
            char esc = char.Parse(Console.ReadLine().ToLower());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (esc == 'u')
            {
                Console.Write("Data de Fabricação (DD/MM/YYYY) : ");
                DateTime data = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);
                produto = new ProdutoUsado(nome, preco, data);
                lista.Add(produto);
            }
            else if (esc == 'i')
            {
                Console.Write("Taxa de importação: ");
                double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produto = new ProdutoImportado(nome, preco, taxa);
                lista.Add(produto);
            }
            else
            {
                produto = new Produto(nome, preco);
                lista.Add(produto);
            }
        }
        Console.WriteLine();
        Console.WriteLine("TAGS DE PREÇO:");
        foreach(Produto produto in lista)
        {
            Console.WriteLine(produto.PrecoTag());
        }


    }
}