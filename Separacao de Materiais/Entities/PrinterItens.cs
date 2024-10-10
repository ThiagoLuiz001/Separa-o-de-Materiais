using Separacao_de_Materiais.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Separacao_de_Materiais.Entities
{
    class PrinterItens : Orders
    {
        public List<Itens>  _Itens { get; private set; } = new List<Itens>();

        private char[] Description;


        public PrinterItens() { }
        public PrinterItens(int order, int op, string client, Itens iten) : base(order, op, client)
        {
            _Itens.Add(iten);
        }
        public void AddList(Itens iten)
        {
            _Itens.Add(iten);
        }

        public void AddDescription(string description)
        {
            Description = description.ToCharArray();
        }
        public string GroupDescription()
        {
            string group = "";
            foreach (char c in Description)
            {
                group += $"\n{c}";
            }
            return group.ToUpper();
        }

    }
}
