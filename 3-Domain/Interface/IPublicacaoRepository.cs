using _3_Domain.Class;
using System.Collections.Generic;

namespace _3_Domain.Interface
{
    public interface IPublicacaoRepository
    {
        IEnumerable<Publicacao> GetAll();
    }
}
