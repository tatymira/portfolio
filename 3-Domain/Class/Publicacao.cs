using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioRest.Domain
{
    public class Publicacao
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataAtualizacao { get; set; }
        public virtual string Titulo { get; set; }
        public virtual string Introducao { get; set; }
        public virtual string Conteudo { get; set; }
        public virtual Categoria Categoria { get; set; }
        
    }
}
