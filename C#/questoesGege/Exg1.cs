// Crie um programa que peça números ao usuário e vá somando tudo.

namespace Course
{
    public class Exg1
    {
        static void Main(string[] args)
        {
            int total=0;
            int x=1;
            while (x != 0)
            {
                x = int.Parse(Console.ReadLine());
                total+=x;
            }
            System.Console.WriteLine(total);
        }
    }
}