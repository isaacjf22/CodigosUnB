using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSimples
{
    internal class Aluguel
    {
        public string Nome { get; set; } //encapsulamento automatico, ñ há restrição a ser aplicado 
        public string Email { get; set; }

        //constructor 
        public Aluguel(string nome, string email)
        { 
            Nome = nome;
            Email = email;
        }
    }
}
