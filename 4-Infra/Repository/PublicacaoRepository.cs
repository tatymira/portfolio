using _3_Domain.Class;
using _3_Domain.Interface;
using NHibernate;
using System.Collections.Generic;
using System.Linq;

namespace _4_Infra.Repository
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
