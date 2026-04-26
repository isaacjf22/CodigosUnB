using System;
using System.Text.Json; //poder criar json de objetos 
using System.IO;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Xml; //poder mexer nos arquivos 

namespace ArenaRPG
{
    class Program
    {
        private static Personagem personagemAtual;
        static void Main(string[] args)
        {
            bool stop = false;
            do
            {
                ConsoleKeyInfo tecla;
                
                Console.Clear();
                Console.WriteLine("+=====================+");
                Console.WriteLine("       Arena RPG       ");
                Console.WriteLine("+=====================+");
                Console.WriteLine();
                Console.WriteLine("1- Ir para a Arena");
                Console.WriteLine("2- Criar um personagem");
                Console.WriteLine("3- Gerenciar personagens");
                Console.WriteLine("4- Regras");
                Console.WriteLine("5- Sair");

                do //validação de entrada
                {
                    tecla = Console.ReadKey(); //variavel para realizar leitura de tecla 
                }while(tecla.KeyChar!='1'&& tecla.KeyChar!='2'&& tecla.KeyChar!='3' && tecla.KeyChar!='4'&& tecla.KeyChar!='5') ;



                switch (tecla.KeyChar)
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        Console.WriteLine("Até a próxima batalha!");
                        stop = true;
                        break;
                }
                
                
                
                
                
                
            } while (stop == false);


        }

        static void CricaoPersonagem()
        {   
            Console.Clear();
            Console.WriteLine("+=========================+");
            Console.WriteLine("   Criação de Personagem   ");
            Console.WriteLine("+=========================+");
            Console.WriteLine("Então bravo gafanhoto... Qual classe deseja escolher?");
            Console.WriteLine("Um temível guerreiro que possui uma grande coragem e força para utilizar contra");
            Console.WriteLine("seus inimigos ou um extraordinário mago que realiza fantásticas magias para");
            Console.WriteLine("dizimar os traiçoeiros?");
            Console.WriteLine("1- GUERREIRO 2- MAGO");
            Console.WriteLine();

            ConsoleKeyInfo tecla; //variavel de info de tecla e a obtenção desse dado 
            
            do
            {   
                tecla =  Console.ReadKey();
            }while(tecla.KeyChar!='1' && tecla.KeyChar!='2');

            Console.WriteLine("Qual é o nome do seu lutador?");
            string nome = Console.ReadLine();

            Personagem personagemCriado; //pode declarar o pai e instanciar pelo filho 
            
            if (tecla.KeyChar == 1)
            {      
                personagemCriado = new Guerreiro(nome);
            }
            else
            {
                personagemCriado = new Mago(nome);
            }

            personagemAtual = personagemCriado;
            
            Console.WriteLine("Lutador criado com sucesso!");
            Console.WriteLine("Deseja salvá-lo?");
            Console.WriteLine("S-Sim ou N-Não");

            char escolha;
            
            do
            {
                escolha = Console.ReadKey().KeyChar;
            }while(char.ToLower(escolha) != 's' && char.ToLower(escolha) != 'n');

            if (escolha == 's') //realizando o salvamento 
            {
                string nomeArquivo = nome + "_save.json"; //criado o nome do arquivo
                string jsonObjeto = JsonSerializer.Serialize(personagemCriado); //convertido o objeto em texto
                File.WriteAllText(nomeArquivo, jsonObjeto); //criando o arquivo , 1 nome , 2 conteudo 
            }
        }



        static Personagem CarregarPersonagem()
        {
            string[] arquivos = Directory.GetFiles(Directory.GetCurrentDirectory(), "*_save.json"); //pegando todos os arquivos presentes na pasta 
            Console.WriteLine();
            
            for (int i=0 ; i <= arquivos.Length; i++)
            {
                Console.WriteLine($"{i+1} - {Path.GetFileNameWithoutExtension(arquivos[i])} "); //pegar o nome do arquivo sem o .json 
            }

            Console.WriteLine("Qual lutador deseja invocar?");
            int escolha;
            do
            { 
                escolha = int.Parse(Console.ReadLine());
            }while(escolha<0 || escolha>arquivos.Length);
            
            string arquivoEscolhido = arquivos[escolha-1]; //pegando o nome do arquivo escolhido 
            string jsonLido = File.ReadAllText(arquivoEscolhido); //salvando o json do arquivo escolhido para desconverter 
            
            Personagem personagemCarregado = JsonSerializer.Deserialize<Personagem>(jsonLido); //desconvertendo o json em objeto

            Console.WriteLine($"O lutador {personagemCarregado.Nome} foi invocado com sucesso!");
            
            return personagemCarregado;
        }

        static void GerenciamentoPersonagem()
        {
            Console.Clear();
            string[] arquivos = Directory.GetFiles(Directory.GetCurrentDirectory(), "*_save.json"); //pegando todos os arquivos
            for (int i = 0; i < arquivos.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {Path.GetFileNameWithoutExtension(arquivos[i])} ");
            }

            Console.WriteLine("O que pretende fazer?");
            Console.WriteLine("1-ALTERAR NOME 2-APAGAR PERSONAGEM 3-SAIR");

            char tecla; //poderia usar var , variavel geral q se adapta ao q receber 

            do
            {
               tecla = Console.ReadKey().KeyChar;
            } while (tecla != '1' && tecla != '2' && tecla != '3');

            switch (tecla)
            {
                case '1':
                    Console.WriteLine("Qual lutador deseja mudar o nome?");
                    int escolha = int.Parse(Console.ReadLine());
                    string arquivoEscolhido = arquivos[escolha-1];
                    string jsonLido = File.ReadAllText(arquivoEscolhido);
                    Personagem personagemEscolhido = JsonSerializer.Deserialize<Personagem>(jsonLido);
                    
                    Console.WriteLine("Qual é o novo nome?");
                    string novoNome  = Console.ReadLine();
                    personagemEscolhido.Nome = novoNome;
                    string nomeArquivo = novoNome + "_save.json";
                    string jsonObjeto = JsonSerializer.Serialize(personagemEscolhido); //convertendo o objeto 
                    File.WriteAllText(nomeArquivo, jsonObjeto); 
                    File.Delete(arquivoEscolhido);
                    break;
                
                case '2':
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    break;
                
                case '3':
                    break;
            }






        }
        
        
        

        static void Pausar()
        {
            Console.WriteLine();
            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.ReadKey(true); //true deixa invisivel a tecla
        }


    }
}


