using Separacao_de_Materiais.Entities.Exceptions;

namespace Separacao_de_Materiais.Models.Validations
{
    public class RequestValidation
    {
        public int InformationIntegrity(string order)
        {
            int ord =0;
            if(order !="" || order != null )
            {
                if (order != "0") 
                {
                    ord = int.Parse(order);
                }
            }
            else
            {
                throw new ExceptionsInformation($"Valor passado não condiz a formatação de um pedido `({order}). Por favor digite um pedido existente!");
            }

            return ord;
        }
    }
}
