using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Xml;

namespace Atividades
{
    internal class Escolha
    {
        static void Main(string[] args)
        {
            int esc = 999;
            while (esc != 0)
            {
                Console.Clear();
                Console.WriteLine("Qual exercício você quer executar?");
                Console.WriteLine("1- Área de triângulo");
                Console.WriteLine("2- Entrada de produto");
                Console.WriteLine("3- Retângulo");
                Console.WriteLine("4- Salário Funcionário");
                Console.WriteLine("5- Aluno Notas");
                Console.WriteLine("6- Esfera");
                Console.WriteLine("7- Dólar");
                Console.WriteLine("0 - Encerrar o programa");

                esc = int.Parse(Console.ReadLine());

                switch (esc)
                {
                    case 1:   TrianguloQuestao.Executar();
                        break;
                    case 2: ProdutoQuestao.Executar();
                        break;
                    case 3: RetanguloQuestao.Executar();
                        break;
                    case 4: FuncionarioQuestao.Executar();
                        break;
                    case 5: AlunosQuestao.Executar();
                        break;
                    case 6: EsferaQuestao.Executar();
                        break;
                    case 7: DolarQuestao.Executar();
                        break;                    
                    case 0:    Console.WriteLine("Saindo do programa....");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        break;
                }


            }
        }

    }
}
