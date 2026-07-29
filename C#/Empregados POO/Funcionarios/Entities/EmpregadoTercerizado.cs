using System.Globalization;

namespace Funcionarios.Entities
{
    internal class EmpregadoTercerizado : Empregado //herança de empregado 
    {
        public double CustosAdicionais { get; set; }

        //construtores 
        public EmpregadoTercerizado()
        {

        }

        public EmpregadoTercerizado(string nome, int horas, double valorPorHora, double custosAdicionais) : base(nome, horas, valorPorHora)
        {
            CustosAdicionais = custosAdicionais;
        }

        //métodos
        public override double Pagamento()
        {
            return base.Pagamento() + (1.1 * CustosAdicionais); 
        }

        public override string ToString()
        {
            return $"{Nome} - ${Pagamento().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
