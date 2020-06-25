using PortfolioRest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioRest.Interface
{
    public interface IPublicacaoRepository
    {
        IEnumerable<Publicacao> GetAll();
    }
}
