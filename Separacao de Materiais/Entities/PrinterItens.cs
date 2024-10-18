using Separacao_de_Materiais.Entities.Commons;

namespace Separacao_de_Materiais.Entities
{
    sealed class PrinterItens : Orders
    {
        public string Description { get; private set; }
        public string Group { get; private set; }

        public PrinterItens() { }
        public PrinterItens(int order, int op, string client, List<Itens> item) : base(order, op, client)
        {
            ItensDescription(item);
            GroupDescription(item[0].CreationTree());
        }

        private void ItensDescription(List<Itens> itens)
        {
            
            foreach(Itens i in itens)
            {
                Description += $"\n{i.ToString()}";
            }
            
        }
        private void GroupDescription(string value)
        {
            char[] letters = value.ToCharArray();
            foreach(char c in letters)
            {
                Group += $"\n{c.ToString().ToUpper()}";
            }
        }

    }
}
