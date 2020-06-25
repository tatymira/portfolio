using _3_Domain.Class;
using FluentNHibernate.Mapping;

namespace _4_Infra.Mappings
{
    public class PublicacaoMap : ClassMap<Publicacao>
    {
        public PublicacaoMap()
        {
            Id(l => l.Id);
            Map(l => l.DataAtualizacao);
            Map(l => l.Titulo);
            Map(l => l.Introducao);
            Map(l => l.Conteudo);
            References(l => l.Categoria);
            Table("Publicacao");
        }
    }
}
