using System.Text;
using EstoqueComposição.Entities.Enums;
using System.Globalization;
using System.Collections.Generic;

namespace EstoqueComposição.Entities
{
    internal class Pedido
    {
        public DateTime Momento { get; private set; }
        public PedidoStatus Status { get; private set; }
        public Cliente Client { get; set; }
        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>(); //cuidado para n esquecer de instanciar a lista 

        //construtor 
        public Pedido(PedidoStatus status, Cliente client)
        {
            Momento = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AdicionarItem(ItemPedido item)
        {
            Itens.Add(item);
        }

        public void RemoverItem(ItemPedido item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach(ItemPedido item in Itens)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"RESUMO DO PEDIDO:\n");
            sb.Append($"Momento do pedido: {Momento}\n");
            sb.Append($"Status do pedido: {Status}\n");
            sb.Append($"Cliente: {Client.Nome} ({Client.DataAniversario.ToString("dd/MM/yyyy")}) - {Client.Email}\n");
            sb.Append($"Itens do pedido: \n");
            foreach(ItemPedido item in Itens)
            {
                sb.Append($"{item.Product.Nome}, ${item.Preco.ToString("F2", CultureInfo.InvariantCulture)}, Quantidade: {item.Quantidade}, Subtotal: ${item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}\n");

            }
            sb.Append($"Total do pedido ${Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString(); //saindo de stringbuilder para string
        }


    }
}
