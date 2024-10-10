using Separacao_de_Materiais.DAO;
using Separacao_de_Materiais.Entities;
using Separacao_de_Materiais.Entities.Commons;


namespace Separacao_de_Materiais.Models
{
    public static class Filter
    {
        public static List<Data> datas = new List<Data>();


        public static void AddList(int order)
        {
           
            List<Orders> orders = OrdersDAO.OpsRead(order);
            foreach(Orders ord in orders)
            {
                List<Itens> itens = ItensDAO.ItensRead(ord);
                foreach(Itens I in itens)
                {
                    bool repeat = false;
                    for(int i = 0; i <datas.Count; i++)
                    {
                        if (datas[i].OP == ord.OP)
                        {
                            repeat = true;
                            break;
                        }
                    }
                    if(repeat == false)
                    {
                        datas.Add(new Data(ord.Order, ord.OP, ord.Client, I));
                    }
                    else
                    {
                        datas[datas.Count - 1].RepeatOP(I);
                    }
                    
                }
            }
            
        }

    }
}
