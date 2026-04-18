using System;
using System.Runtime.CompilerServices;
using System.Text.Json; //para criar arquivos longos , criando o texto do objeto 
using System.IO;
using System.Diagnostics.CodeAnalysis; //mexer com arquivos 

namespace PetMobile
{
    class Program
    {
        static void Main()
        {
            Pet pet = CarregarPet();

            Console.Clear(); 

            if(pet==null)
            {
                Console.WriteLine("Bem vindo ao pet mobile! Qual será o nome do seu pet?");
                string nome = Console.ReadLine();
                pet = new Pet(nome);                
                
            }

            Console.Clear();
            int esc = 99; //responsavel pela escolha 

            while (esc!=6 && pet.CondicaoPet()==false)
            {
                Console.WriteLine($"O que fazer com o {pet.Nome}?");
                Console.WriteLine("1- Brincar");
                Console.WriteLine("2- Alimentar");
                Console.WriteLine("3- Dormir");
                Console.WriteLine("4- Verificar Status");
                Console.WriteLine("5- Passar tempo");
                Console.WriteLine("6- Sair do Pet Simulator");
                esc = int.Parse(Console.ReadLine());

                switch (esc)
                {
                    case 1: pet.Brincar();
                        break;
                    case 2: pet.Alimentar();
                        break;
                    case 4: pet.Status();
                        break;
                    case 3: pet.Dormir();
                        break;
                    case 5: pet.PassarTempo();
                        break;
                    case 6: Console.WriteLine($"Saindo, o {pet.Nome} vai ficar com saudades...");
                        string jsonSave = JsonSerializer.Serialize(pet); //aqui esta criando json do objeto pet atual //serializando 
                        string arquivoSalvo = pet.Nome + "_save.json"; //criando o nome do arquivo de acordo com o nome do pet 
                        File.WriteAllText(arquivoSalvo, jsonSave); //escrevendo o json criado no arquivo com o nome do pet 
                        break;
                    default: Console.WriteLine("A escolha de opção foi invalida!");
                        break;
                }
            }
            if (pet.CondicaoPet() == true) //apagando o arquivo do pet q morreu 
            {
                string arquivoMorreu = pet.Nome + "_save.json"; //criando o nome do arquivo a ser deletado 
                if (File.Exists(arquivoMorreu)) File.Delete(arquivoMorreu); 
            }
            
        }

        static Pet CarregarPet()
        {
            string[] arquivos = Directory.GetFiles(Directory.GetCurrentDirectory(), "*_save.json"); //esse vetor vai pegar todos os JSON da pasta mãe do projeto 
            // e armazenar no vetor em cada index 

            if(arquivos.Length == 0)
            {
                Console.WriteLine("Nenhum pet encontrado!");
                Console.ReadKey();
                return null;
            }

            Console.WriteLine("Selecione seu pet: ");
            for(int i=0; i <arquivos.Length; i++) //laço para fazer a escrita dos arquivos disponiveis 
            {
                Console.WriteLine($"{i+1} - {Path.GetFileNameWithoutExtension(arquivos[i])}");

            }
            Console.WriteLine();
            Console.WriteLine("Escolha o número ou digite 2000 para criar um novo:  ");
            int esc=999;
            do
            {
                esc = int.Parse(Console.ReadLine());
                if (esc == 2000)
                {
                    break; 
                }
            } while (esc < 0 || esc > arquivos.Length );

            if (esc == 2000)
            {
                return null;
            }

            string arquivoEscolhido = arquivos[esc - 1]; //pegando o arquivo no vetor de json 
            string jsonLido = File.ReadAllText(arquivoEscolhido); //salvando o texto do arquivo escolhido 

            Pet petCarregado = JsonSerializer.Deserialize<Pet>(jsonLido); //transformou o texto no objeto 

            Console.WriteLine($"{petCarregado.Nome} foi carregado com sucesso!");
            Console.ReadKey();
            return petCarregado;
        }

        

    }
}