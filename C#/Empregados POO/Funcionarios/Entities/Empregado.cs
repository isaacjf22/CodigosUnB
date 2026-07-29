using System.Globalization;

namespace Funcionarios.Entities
{
    internal class Empregado
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        //construtores
        public Empregado()
        {

        }

        public Empregado(string nome, int horas, double valorPorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }


        //métodos 
        public virtual double Pagamento()
        {
            return Horas * ValorPorHora;
        }

        //override 
        public override string ToString()
        {
            return $"{Nome} - ${Pagamento().ToString("F2", CultureInfo.InvariantCulture)}";
        }



    }
}
