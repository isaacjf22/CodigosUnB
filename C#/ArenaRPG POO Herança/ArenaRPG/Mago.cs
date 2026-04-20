using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaRPG
{
    internal class Mago : Personagem
    {
        private int _mana;
        public int PocoesMana { get; private set; }

        public int Mana
        {
            get { return _mana; }
            set
            {
                _mana = Math.Clamp(value, 0, 15); //limitador 
            }

        }

        public Mago(string nome) : base(nome) //pegando a base da orientação do pai e o restante ja foi denifinido do pai 
        {
            Mana = 15;
            PocoesMana = 3; 
        }

        public override void Atacar(Personagem alvo)
        {
            Console.WriteLine("1-BATER COM CAJADO (2st) | 2-BOLA DE FOGO (4mn) | 3-RELÂMPAGO (7mn) | 4-KAMEHAMEHA (10mn) ");
            char escolha = '0';
            int custo = 0;
            const int danoCajado = 2;
            const int danoBolaDeFogo = 5;
            const int danoRelampago = 7;
            const int danoKamehameha = 10;

            do
            {

                escolha = Console.ReadKey(true).KeyChar;  //sem impressao e traduzir os char 

                switch (escolha) //switch do custo de uso de algum tipo de ataque 
                {
                    case '1': custo = 2;break;
                    case '2': custo = 4;break;
                    case '3': custo = 7;break;
                    case '4': custo = 10;break;
                }

                switch (escolha) //switch de ataque 
                {
                    case '1':
                        if (this.Stamina >= custo) //atenção no valor e as desigualdades 
                        {
                            Console.WriteLine($"O mago {Nome} deu uma cajadada no {alvo.Nome}!");
                            Console.WriteLine($"{alvo.Nome} recebeu {danoCajado} de dano.");
                            alvo.ReceberDano(danoCajado,this); //quem deu o dano foi esse objeto 
                            this.Stamina -= custo;
                        }
                        else
                        {
                            Console.WriteLine("Não tem energia suficiente para esse ataque!");
                            Console.WriteLine("Você PERDEU seu turno!");
                        }
                        break;
                    case '2':
                        if (this.Mana >= custo)
                        {
                            Console.WriteLine($"O mago {Nome} lançou uma bola de fogo no {alvo.Nome}!");
                            Console.WriteLine($"{alvo.Nome} recebeu {danoBolaDeFogo} de dano.");
                            alvo.ReceberDano(danoBolaDeFogo,this);
                            this.Mana -= custo;
                        }
                        else
                        {
                            Console.WriteLine("Não tem mana suficiente para esse ataque!");
                            Console.WriteLine("Você PERDEU seu turno!");
                        }
                        break;
                    case '3':
                        if (this.Mana >= custo)
                        {
                            Console.WriteLine($"O mago {Nome} lançou um relâmpago no {alvo.Nome}!");
                            Console.WriteLine($"{alvo.Nome} recebeu {danoRelampago} de dano.");
                            alvo.ReceberDano(danoRelampago,this);
                            this.Mana -= custo;
                        }
                        else
                        {
                            Console.WriteLine("Não tem mana suficiente para esse ataque!");
                            Console.WriteLine("Você PERDEU seu turno!");
                        }
                        break;
                    case '4':
                        if (this.Mana >= custo)
                        {
                            Console.WriteLine($"O mago {Nome} lançou um KAMEHAMEHAAAAA no {alvo.Nome}!");
                            Console.WriteLine($"{alvo.Nome} recebeu {danoKamehameha} de dano.");
                            alvo.ReceberDano(danoKamehameha,this);
                            this.Mana -= custo;
                        }
                        else
                        {
                            Console.WriteLine("Não tem mana suficiente para esse ataque!");
                            Console.WriteLine("Você PERDEU seu turno!");
                        }
                        break;
                    default:
                        Console.WriteLine("Ataque desconhecido!");
                        break;
                }
            } while (escolha != '1' && escolha != '2' && escolha != '3' && escolha != '4');


        }

        public override void Defender(int dano) //bola protetora
        {
            if (this.Mana >= 5)
            {
                Console.WriteLine($"O mago {Nome} tankou o dano com sua bola protetora!");
                this.Mana -= 5; //vida se mantem e mana reduziu
            }
            else
            {
                Console.WriteLine(("Não tem mana suficiente para essa defesa!"));
                Console.WriteLine($"O mago {Nome} recebeu {dano} de dano.");
                this.Vida -= dano;
            }
        }

        public void TomarMana()
        {
            if (PocoesMana > 0)
            {
                Console.WriteLine($"O mago {Nome} tomou uma poção de mana!");
                Console.WriteLine($"Foi recuperado 8 de mana.");
                this.Mana += 8;
                PocoesMana--;
            }
            else
            {
                Console.WriteLine("Você não tem poções de mana!");
            }
            
        }

    }
}
