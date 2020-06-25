using FluentNHibernate.Mapping;
using PortfolioRest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioRest.Mappings
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
