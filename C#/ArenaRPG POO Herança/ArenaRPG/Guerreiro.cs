using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaRPG
{
    internal class Guerreiro : Personagem
    {
        public int Escudo { get; private set; }


        public Guerreiro(string nome) : base(nome) //construtor 
        {
            Escudo = 5;
        }

        public override void Atacar(Personagem alvo)
        {
            Console.WriteLine("1- MACHADADA | 2-ARREMEÇAR (2 st) | 3-ESMAGAR (4 st) | 4-ESTRAÇALHAR (8 st) ");
            char escolha = '0';
            const int danoMachado = 2;
            const int danoArremecar = 3;
            const int danoEsmagar = 4;
            const int danoEstracalhar = 7;    

            do
            {
                escolha = Console.ReadKey(true).KeyChar; //true faz q o read executa na hora , e q n apareça nada no console
                int custo = 0; //stamina 
                switch (escolha)//switch do custo de stamina 
                {
                    case '1': custo = 0;break;
                    case '2': custo = 2;break;
                    case '3': custo = 4;break;
                    case '4': custo = 8;break;
                }

                switch (escolha) //switch do ataque 
                {
                    case '1':
                        Console.WriteLine($"O guerreiro {Nome} deu uma machadada no {alvo.Nome}!");
                        Console.WriteLine($"{alvo.Nome} recebeu {danoMachado} de dano.");
                        alvo.ReceberDano(danoMachado,this);
                        break;
                    case '2':
                        if (this.Stamina < custo)
                        {
                            Console.WriteLine("Não tem energia suficiente para esse ataque!");
                            Console.WriteLine("Você PERDEU seu turno!");
                        }
                        else
                        {
                            Console.WriteLine($"O guerreiro {Nome} arremessou o {alvo.Nome}!");
                            Console.WriteLine($"{alvo.Nome} recebeu {danoArremecar} de dano.");
                            alvo.ReceberDano(danoArremecar,this);
                            this.Stamina -= custo;
                        }                        
                        break;
                    case '3':
                        if (this.Stamina < custo)
                        {
                            Console.WriteLine("Não tem energia suficiente para esse ataque!");
                            Console.WriteLine("Você PERDEU seu turno!");
                        }
                        else
                        {
                            Console.WriteLine($"O guerreiro {Nome} esmagou o {alvo.Nome}!");
                            Console.WriteLine($"{alvo.Nome} recebeu {danoEsmagar} de dano.");
                            alvo.ReceberDano(danoEsmagar,this);
                            this.Stamina -= custo;
                        }   
                        break;
                    case '4':
                        if (this.Stamina < custo)
                        {
                            Console.WriteLine("Não tem energia suficiente para esse ataque!");
                            Console.WriteLine("Você PERDEU seu turno!");
                        }
                        else
                        {
                            Console.WriteLine($"O guerreiro {Nome} estraçalhou {alvo.Nome}!");
                            Console.WriteLine($"{alvo.Nome} recebeu {danoEstracalhar} de dano.");
                            alvo.ReceberDano(danoEstracalhar,this);
                            this.Stamina -= custo;
                        }
                        break;
                    default: Console.WriteLine("Ataque desconhecido!"); break;
                }

            } while (escolha != '1' && escolha != '2' && escolha != '3' && escolha != '4');

        }

        public override void Defender(int dano)
        {
            if (Escudo > dano)
            {
                Console.WriteLine($"O guerreiro {Nome} se defendeu de todo o dano!");
            }
            else
            {
                Console.WriteLine($"O guerreiro {Nome} não conseguiu tankar o dano todo!");
                Console.WriteLine($"Recebeu {dano-Escudo} de dano!");
                this.Vida -= (dano - Escudo); 
            }
        }


    }
}
