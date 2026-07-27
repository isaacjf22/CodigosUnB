using EstoqueComposição.Entities;
using EstoqueComposição.Entities.Enums;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com os dados do cliente: ");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Data de Nascimento (DD/MM/YYYY): ");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Entre com os dados do pedido: ");
        Console.Write("Status: ");
        string status;
        PedidoStatus stats = default; //precisa iniciar 
        do
        {
            status = Console.ReadLine().ToUpper();
            if (status != "PENDENTE" && status != "PROCESSANDO" && status != "DESPACHADO" && status != "ENTREGUE")
            {
                Console.WriteLine("Escolha incorreta! Tente novamente.");
                Console.Write("Status: ");
            }
            else
            {
                stats = Enum.Parse<PedidoStatus>(status); 
            }
        } while (status != "PENDENTE" && status != "PROCESSANDO" && status != "DESPACHADO" && status != "ENTREGUE");

        //instanciação de objeto 
        Cliente client = new Cliente(nome, email, dataNascimento);
        Pedido pedido = new Pedido(stats, client);

        Console.Write("Quantos itens serão nesse pedido? ");
        int quantidade = int.Parse(Console.ReadLine());

        //itens do pedido
        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Entre com as informações do {i+1}° item: ");
            Console.Write("Nome do produto: ");
            string nomeProduto = Console.ReadLine();
            Console.Write("Preço do produto: ");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidadeProduto = int.Parse(Console.ReadLine());
            Produto produto = new Produto(nomeProduto, precoProduto); //instanciado objeto
            ItemPedido item = new ItemPedido(quantidadeProduto, produto);

            pedido.AdicionarItem(item); //adicionando item ao pedido
        }
        Console.WriteLine();
        Console.WriteLine(pedido);

    }
}