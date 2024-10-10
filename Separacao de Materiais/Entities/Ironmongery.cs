using Separacao_de_Materiais.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Separacao_de_Materiais.Entities
{
    public sealed class Ironmongery : Itens
    {
        public Ironmongery(Itens item)
        {
            Id = item.Id;
            Description = item.Description;
            Group = item.Group;
            Units = item.Units;
            Type = item.Type;
        }
    }
}
