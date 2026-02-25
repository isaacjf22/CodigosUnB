
// Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
// mensagem explicativa, conforme exemplos


namespace Course
{
    public class Ex1
    {
        static void Main(string[] args)
        {
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine()); 

            int soma = valor1+valor2; 

            System.Console.WriteLine("SOMA = " + soma);
        }
    }
}