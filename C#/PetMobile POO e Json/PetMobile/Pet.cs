namespace PetMobile
{
    internal class Pet
    {
        public string Nome { get; set; }
        private int _fome; //modificação é acessado somente pelos metodos , onde o valor realmente reside 
        private int _energia; 

        public int Fome
        {
            get { return _fome; } //se pedir o dado fome , vai retornar o dado privado que está com o valor definido 
            set
            {
                _fome = Math.Clamp(value, 0, 20);
            }
        }

        public int Energia
        {
            get { return _energia; }
            set
            {
                _energia = Math.Clamp(value, 0, 20);
            }
        }

        public Pet() { } //um constructor precisa estar vazio para o save 

        public Pet(string nome) //constructor 
        {
            Nome = nome;
            Fome = 5;
            Energia = 15;
        }


        
        public void PassarTempo()
        {
            Fome += 2;
            Energia -= 2;
            Console.WriteLine("O tempo passou...");
            Console.ReadKey();
            Console.Clear();

        } 
        
        
        public void Status()
        {
            Console.WriteLine($"Status do {Nome}");
            Console.WriteLine($"Fome: {Fome}");
            Console.WriteLine($"Energia: {Energia}");
            Console.ReadKey();
            Console.Clear();
        }

        public void Dormir()
        {
            Energia += 20;
            Fome += 5;
            Console.WriteLine("ZZZZZzzzzz");
            Console.WriteLine($"O {Nome} dormiu!");
            Console.ReadKey();
            Console.Clear();
        }

        public void Brincar()
        {
            Energia -= 8;
            Fome += 5;
            Console.WriteLine("Seu pet se divertiu!");
            Console.ReadKey();
            Console.Clear();
        }

        public void Alimentar()
        {
            Fome -= 10;
            Console.WriteLine($"O {Nome} foi alimentado!");
            Console.ReadKey();
            Console.Clear();
        }

        public bool CondicaoPet()
        {
            if (Energia == 0) 
            {
                Console.WriteLine($"{Nome} morreu de sono :(");
                Console.ReadKey();
                Console.Clear();
                return true;
            }
            if(Fome == 20)
            {
                Console.WriteLine($"{Nome} morreu de fome :(");
                Console.ReadKey();
                Console.Clear();
                return true;
                
            }
            return false; //se n atender nenhuma condição , retorna falso e ele esta vivo
        }


    }
}
