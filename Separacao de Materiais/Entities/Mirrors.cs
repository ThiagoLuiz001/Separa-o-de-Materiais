using Separacao_de_Materiais.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Separacao_de_Materiais.Entities
{
    public sealed class Mirrors : Itens
    {
        public Mirrors(Itens item)
        {
            Id = item.Id;
            Description = item.Description;
            Group = item.Group;
            Units = item.Units;
            Type = item.Type;
        }
    }
}
