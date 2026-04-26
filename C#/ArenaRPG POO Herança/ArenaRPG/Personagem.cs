using System;
using System.Text.Json.Serialization;

namespace ArenaRPG
{
    
    //criação de "etiquetas" para apontar para as classes filhas 
    //atributos - forma de lidar com herança 
    //jsonderivedtype - indicando pro json que essa classe tem filha 
    //typeof indicando qual classe quero identificar 
    //typediscriminator - a etiqueta q fica no json 
    [JsonDerivedType(typeof(Guerreiro), typeDiscriminator: "guerreiro")]
    [JsonDerivedType(typeof(Mago),   typeDiscriminator: "mago") ]
    
    
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
