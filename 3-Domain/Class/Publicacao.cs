using System;

namespace _3_Domain.Class
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
