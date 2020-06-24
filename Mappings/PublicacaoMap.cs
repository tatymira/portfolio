using FluentNHibernate.Mapping;
using PortfolioRest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioRest.Mappings
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
            Table("Publicacao");
        }
    }
}
