using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Separacao_de_Materiais.Entities.Exceptions
{
    public class ExceptionsInformation : ApplicationException
    {
        public ExceptionsInformation(string message) : base(message) { }

        //public ExceptionsInformation(string message, )
    }
}
