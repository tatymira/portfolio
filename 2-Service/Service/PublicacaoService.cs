using _3_Domain.Class;
using _3_Domain.Interface;
using System.Collections.Generic;

namespace _2_Service.Service
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
