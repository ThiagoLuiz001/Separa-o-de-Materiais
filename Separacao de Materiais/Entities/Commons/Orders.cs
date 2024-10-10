namespace Separacao_de_Materiais.Entities.Commons
{
    public class Orders
    {
        public int Order { get; set; }

        public int OP { get; set; }

        public string Client { get; set; }


        public Orders()
        {
        }

        public Orders(int order, int op, string client)
        {
            Order = order;
            OP = op;
            Client = client;
        }
    }
}
