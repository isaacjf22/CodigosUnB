using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using ContratoComposicao.Entities.Enums;

namespace ContratoComposicao.Entities
{
    internal class Trabalhador
    {
        public string Nome { get; private set; }
        NivelTrabalho Nivel { get; set; }
        public double SalarioBase { get; private set; }

        List<Contrato> Contratos = new List<Contrato>(); //composição 
        public Departamento departamento { get; private set; }

        //construtor 
        public Trabalhador(string nome, string level, double salarioBase, string departamento)
        {
            Nome = nome;
            Nivel = Enum.Parse<NivelTrabalho>(level);
            SalarioBase = salarioBase;
            this.departamento = new Departamento(departamento);
        }

        //métodos 
        public void AdicionarContrato(Contrato contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(Contrato contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Total(int ano, int mes) 
        {
            double totalContrato = 0;
            foreach (Contrato contrato in Contratos)
            {                
                if(contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    totalContrato += contrato.ValorTotal();
                }
            }
            return SalarioBase + totalContrato;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nDepartamento: {departamento.Nome}";
        }

    }
}
