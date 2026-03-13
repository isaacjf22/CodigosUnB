using System;
using System.Collections.Generic;
using System.Text;

namespace PoupandoAlvo
{
    internal class Alvo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NivelPerigo { get; set; }
        public string Status { get; private set; }

        //construtores 
        public Alvo(int id, string nome, int nivelPerigo)
        {
            Id = id;
            Nome = nome;
            NivelPerigo = nivelPerigo;
            Status = "Ativo";
        }

        //metodos
        public void ConcederRendicao()
        {
            Status = "Redimido";
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, Nivel de Perigo: {NivelPerigo}, Status: {Status}";
        }

    }
}
