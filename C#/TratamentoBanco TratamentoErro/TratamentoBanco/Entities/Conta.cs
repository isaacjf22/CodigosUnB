using TratamentoBanco.Exceptions;
using System.Globalization;

namespace TratamentoBanco.Entities
{
    internal class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        public double LimiteSaldo { get; set; }

        //construtor 
        public Conta()
        {

        }

        public Conta(int numero, string nome, double saldo, double limite)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
            LimiteSaldo = limite;
        }

        //metodo 
        public void Depositar(double quantidadde)
        {
            if (quantidadde <= 0)
            {
                throw new DomainException("Não é possível depositar esse valor.");
            }
            Saldo += quantidadde;
        }

        public void Saque(double quantidade)
        {
            if (quantidade > Saldo)
            {
                throw new DomainException("O valor excede o saldo.");
            }else if (quantidade > LimiteSaldo)
            {
                throw new DomainException("O valor excede o limite de saldo.");
            }

            Saldo -= quantidade;
        }

        public override string ToString()
        {
            return $"Conta\nNumero: {Numero}, Nome: {Nome}, Saldo: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }


    }
}
