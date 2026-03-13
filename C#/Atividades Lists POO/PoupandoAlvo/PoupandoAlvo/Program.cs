using PoupandoAlvo;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Alvo> listaAlvos = new List<Alvo>(); //criando a lista

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Alvo #{i+1}");
            Console.WriteLine("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Nivel de Perigo: ");
            int nivelPerigo = int.Parse(Console.ReadLine());
            listaAlvos.Add(new Alvo(id, nome, nivelPerigo));//add na lista e instanciando o objeto do alvo 
        }
        Console.Clear();
        Console.WriteLine("Quem você deseja poupar? Digite o seu nome");
        string nomeEscolhido = Console.ReadLine();

        Alvo alvoEscolhido = listaAlvos.Find(u => u.Nome == nomeEscolhido); //armazenando o resultado 

        if (alvoEscolhido != null)//se tiver encontrado , logo n vai retornar vazio
        {
            alvoEscolhido.ConcederRendicao();
        }
        else
        {
            Console.WriteLine("Não existe esse alvo!");
        }

        foreach(Alvo alvos in listaAlvos)
        {
            Console.WriteLine(alvos);
        }

    }
}