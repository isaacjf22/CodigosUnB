using System;
using System.Collections.Generic;
using System.Text;

namespace TratamentoBanco.Exceptions
{
    internal class DomainException : Exception
    {
        public DomainException()
        {

        }

        public DomainException(string mensagem) : base(mensagem)
        {
            //quando for instanciado , ele recebe a mensagem de erro e armazena
            //ate ser exibido pelo catch na Main 
        }
    }
}
