using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1_MVC.Models
{
    public class FormPublicacaoViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Resumo { get; set; }
        public string Texto { get; set; }
        public DateTime? DataPublicacao { get; set; }
    }
}