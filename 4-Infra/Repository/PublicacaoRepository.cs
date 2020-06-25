using NHibernate;
using PortfolioRest.Domain;
using PortfolioRest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioRest.Repository
{
    public class PublicacaoRepository : IPublicacaoRepository
    {
        private readonly ISession _session;
        public PublicacaoRepository(ISession session)
        {
            _session = session;
        }

        public IEnumerable<Publicacao> GetAll()
        {
            return _session.Query<Publicacao>().ToList();
        }
    }

}
