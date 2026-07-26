using System;
using System.Collections.Generic;
using System.Text;

namespace ContratoComposicao.Entities
{
    internal class Contrato
    {
        public DateTime Data { get; private set; }
        public double ValorPorHora { get; private set; }
        public int Horas { get; private set; }

        //construtor 
        public Contrato(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas; 
        }

        //métodos 
        public double ValorTotal()
        {
            return ValorPorHora * Horas;
        }

    }
}
