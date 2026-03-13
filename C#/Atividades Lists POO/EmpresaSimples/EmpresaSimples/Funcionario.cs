using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaSimples
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }


        //construtores 
        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }


        //metodos 
        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario * (1 + (porcentagem / 100));
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, {Salario:F2}"; 
        }



    }
}
