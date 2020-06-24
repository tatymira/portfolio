using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioRest.Domain
{
    public class Publicacao
    {
        public int Id { get; private set; }
        public DateTime DataAtualizacao { get; private set; }
        public string Titulo { get; private set; }
        public string Introducao { get; private set; }
        public string Conteudo { get; private set; }
    }
}
