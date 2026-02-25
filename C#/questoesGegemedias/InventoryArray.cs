namespace Course
{
    public class InventoryArray
    {
        static void Main(string[] args)
        {
            string[] mochila = new string[3]; //assim q se faz o array 

            for(int i = 0; i < 3; i++)
            {
                System.Console.Write($"Digite o {i+1}° item que você quer guardar: ");
                mochila[i] = Console.ReadLine();
            }
            System.Console.WriteLine("-----INVENTÁRIO-----");
            for(int i = 0; i < 3; i++)
            {
                System.Console.WriteLine($"Slot {i+1} : {mochila[i]}");
            }
        }
    }
}