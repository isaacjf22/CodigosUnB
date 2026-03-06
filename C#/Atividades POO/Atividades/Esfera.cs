using System;
using System.Collections.Generic;
using System.Text;

namespace Atividades
{
    internal class Esfera
    {
        public double Raio;
        public double Pi = 3.14; //como esse valor n muda, é constante , pode deixar como static 

        public double Circunferencia()
        {
            return 2 * Pi * Raio;
        }

        public double Volume()
        {
            return (4.0 / 3.0) * (Pi) * Math.Pow(Raio, 3); //atenção, para ter divisao flutuante precisa forçar
        }
    }
}
