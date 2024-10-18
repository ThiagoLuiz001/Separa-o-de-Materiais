using Separacao_de_Materiais.Entities.Commons;
using Separacao_de_Materiais.Entities.Enums;

namespace Separacao_de_Materiais.Entities
{
    public class Data : Orders
    {
        public List<Itens> Aviation { get; set; } = new List<Itens>();
        public List<Itens> Accessories { get; set; } = new List<Itens>();
        public List<Itens> Mirrors { get; set; } = new List<Itens>();
        public List<Itens> Ironmongery { get; set; } = new List<Itens>();

        public Data (int order, int op, string client, Itens item) : base(order, op, client)
        {
            if( item.Group == 107)
            {
                AccessoriesCharge(item);
            }
            else if( item.Group == 110)
            {
                AviationCharge(item);
            }
            else if(item.Group == 113)
            {
                MirrorsCharge(item);
            }
            else if(item.Group == 115)
            {
                IronmongeryCharge(item);
            }
        }
        






        public void RepeatOP(Itens item)
        {
            if (item.Group == 107)
            {
                AccessoriesCharge(item);
            }
            else if (item.Group == 110)
            {
                AviationCharge(item);
            }
            else if (item.Group == 113)
            {
                MirrorsCharge(item);
            }
            else if (item.Group == 115)
            {
                IronmongeryCharge(item);
            }
        }

        public void AviationCharge(Itens item)
        {
            Aviation.Add(item);

        }

        public void AccessoriesCharge(Itens item)
        {
            Accessories.Add(item);
        }

        public void MirrorsCharge(Itens item)
        {
            Mirrors.Add(item);
        }

        public void IronmongeryCharge(Itens item)
        {
            Ironmongery.Add(item);
        }

        public void ClearList(string group)
        {
            if (Enum.Parse(typeof(EnumGroups), group).Equals((object)EnumGroups.Acessórios))
            {
                Accessories.Clear();
            }
            else if (Enum.Parse(typeof(EnumGroups), group).Equals((object)EnumGroups.Aviamento)) 
            {
                Aviation.Clear();
            }
            else if(Enum.Parse(typeof(EnumGroups), group).Equals((object) EnumGroups.Espelhos))
            {
                Mirrors.Clear();
            }
            else if(Enum.Parse(typeof(EnumGroups), group).Equals((object) EnumGroups.Ferragem))
            {
                Ironmongery.Clear();
            }
        }



        public void DeleteItem(string value)
        {
            if(Aviation.Count!=0)
            {
                for(int i=0; i< Aviation.Count; i++)
                {
                    if (Aviation[i].Description== value)
                    {
                        Aviation.RemoveAt(i);
                    }
                }
            }
            if (Ironmongery.Count != 0)
            {

                for (int i = 0; i < Ironmongery.Count; i++)
                {
                    if (Ironmongery[i].Description == value)
                    {
                        Ironmongery.RemoveAt(i);
                    }
                }
            }
            if (Mirrors.Count != 0)
            {
                for (int i = 0; i < Mirrors.Count; i++)
                {
                    if (Mirrors[i].Description == value)
                    {
                        Mirrors.RemoveAt(i);
                    }
                }
            }
            if (Accessories.Count != 0)
            {
                for (int i = 0; i < Accessories.Count; i++)
                {
                    if (Accessories[i].Description == value)
                    {
                        Accessories.RemoveAt(i);
                    }
                }
            }
        }
    }

}
