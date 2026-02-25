// Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
// um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
// 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
// que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
// mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
// exemplo

namespace Course
{
    public class Exr3
    {
        static void Main(string[] args)
        {
            int gasolina=0,alcool=0,diesel=0;
            int escolha=10; //melhor declarar fora

            while (escolha !=4) //loop principal
            {
                do{
                    escolha = int.Parse(Console.ReadLine());
                }while(escolha!=1 && escolha!=2 && escolha!=3 && escolha!=4); //loop de validação , só 1input no escopo

                switch (escolha)
                {
                    case 1: alcool++;
                    break;
                    case 2: gasolina++;
                    break;
                    case 3: diesel++;
                    break;
                }
                
            }
            System.Console.WriteLine("MUITO OBRIGADO");
            System.Console.WriteLine($"Alcool: {alcool}");
            System.Console.WriteLine($"Gasolina: {gasolina}");
            System.Console.WriteLine($"Diesel: {diesel}");
        }
    }
}