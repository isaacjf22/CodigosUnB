using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSimples
{
    internal class Conta
    {
        //encapsulando os dados 
        public int NumeroConta { get; private set; } //o numero da conta não pode ser mudado, melhor aplicar pelo constructor 
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        //construtores 
        public Conta(int conta, string nome, double saldoInicial)
        {
            NumeroConta = conta; //construtor tem permissao para acessar o private set 
            Nome = nome;
            Deposito(saldoInicial); //metodo que faz entrada de saldo na conta 
        }

        public Conta(int conta, string nome): this(conta,nome,0.0) //sobrecarga
        {
            //saldo fica zerado nessa situação
        }


        //metodos
        public void Deposito(double entrada)
        {
            Saldo += entrada;
        }

        public void Saque(double saida)
        {
            Saldo -= saida;
            Saldo -= 5; //taxa de saque
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Nome}, Saldo: $ {Saldo:F2}";
        }
        





    }
}
