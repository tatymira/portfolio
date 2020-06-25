using PortfolioRest.Domain;
using PortfolioRest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioRest.Service
{
    public class PublicacaoService : IPublicacaoService
    {

        private readonly IPublicacaoRepository _publicacaoRepository;
        public PublicacaoService(IPublicacaoRepository publicacaoRepository)
        {
            _publicacaoRepository = publicacaoRepository;
        }

        public IEnumerable<Publicacao> GetAll()
        {
            return _publicacaoRepository.GetAll();
        }
    }
}
