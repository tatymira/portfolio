using _3_Domain.Class;
using FluentNHibernate.Mapping;

namespace _4_Infra.Mappings
{
    public class CategoriaMap : ClassMap<Categoria>
    {
        public CategoriaMap()
        {
            Id(l => l.Id);
            Map(l => l.Nome);
            Table("Categoria");
        }
    }
}
