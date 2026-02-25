// Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
// incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
// impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002

namespace Course
{
    public class Exr1
    {
        static void Main(string[] args)
        {
            int senhaCorreta = 2002;
            int senhaTentativa; //tem q declarar antes inves de declarar de outra estrutura j
            do
            {
                senhaTentativa = int.Parse(Console.ReadLine());
                if (senhaTentativa != senhaCorreta)
                {
                    System.Console.WriteLine("Senha Invalida.");
                }
            }while(senhaTentativa!=senhaCorreta);
            System.Console.WriteLine("Acesso Permitido.");
        }
    }
}