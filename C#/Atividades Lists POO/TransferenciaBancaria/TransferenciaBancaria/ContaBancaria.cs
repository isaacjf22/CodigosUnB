using System;
using System.Collections.Generic;
using System.Text;

namespace TransferenciaBancaria
{
    internal class ContaBancaria
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
            Saldo = 100;
        }

        


        public bool SacarValidacao() //poderia melhorar aq reduzindo o sacarvalidao e sacar em um 
        {
            if (Saldo > 0)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            Saldo += valor; 
        }


        public override string ToString()
        {
            return $"Número: {Numero} / Nome: {Nome} / Saldo: R${Saldo:F2}";
        }



    }
}
