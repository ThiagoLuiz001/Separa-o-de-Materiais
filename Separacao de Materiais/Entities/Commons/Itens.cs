using Separacao_de_Materiais.Entities.Enums;
using Separacao_de_Materiais.Entities.Exceptions;
namespace Separacao_de_Materiais.Entities.Commons
{
    public class Itens
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Group { get; set; }
        public double Units { get; set; }
        public string Type { get; set; }

        public Itens()
        {
        }

        public Itens(int id, string description, int group, double units, string type)
        {
            Id = id;
            Description = description;
            Group = group;
            Units = units;
            Type = type;
        }

        public string CreationTree()
        {
            return $"{(EnumGroups)Group}";
        }

        public override string ToString()
        {
            return $"Cod: {Id} - {Description} - {Units} {Type}";
        }
    }
}
