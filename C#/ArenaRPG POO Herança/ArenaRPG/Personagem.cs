using System;

namespace ArenaRPG
{
    public abstract class Personagem //abstract obriga q na herança seja escrito algo 
    {
        public string Nome { get; set; }
        private int _vida;
        private int _stamina;
        public int PocaoCura { get; protected set; }

        public int Vida{
            get { return _vida; }
            set
            {
                _vida = Math.Clamp(value, 0, 20);
            }
        }

        public int Stamina
        {
            get { return _stamina; }
            set
            {
                _stamina = Math.Clamp(value, 0, 15);
            }
        }

        public Personagem(string nome) //construtor 
        {
            Nome = nome;
            Vida = 20;
            Stamina = 15;
            PocaoCura = 3; 
        }

        public abstract void Atacar(Personagem alvo); //cada classe tem seu tipo de ataque 

        public abstract void Defender(int dano);

        public void TomarPocao()
        {
            if (PocaoCura > 0)
            {
                Console.WriteLine($"{Nome} tomou uma poção de cura!");
                Console.WriteLine("Foi recuperado 10 de vida.");
                Vida += 10;
                PocaoCura--;
            }
            else
            {
                Console.WriteLine("Você não tem poções de cura!");
            }
        }

        public void ReceberDano(int dano, Personagem alvo) //unica forma de mexer com propriedades protegidas são com metodos e construtores 
        {
            Console.WriteLine($"{this.Nome} recebeu {dano} de dano do {alvo.Nome}");
            Vida -= dano;
        }
    }
}
