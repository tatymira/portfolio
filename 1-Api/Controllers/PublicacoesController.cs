using Microsoft.AspNetCore.Mvc;
using PortfolioRest.Domain;
using PortfolioRest.Interface;
using System.Collections.Generic;

namespace PortfolioRest.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicacoesController : ControllerBase
    {

        private readonly IPublicacaoService _publicacaoService;
        public PublicacoesController(IPublicacaoService publicacaoService)
        {
            _publicacaoService = publicacaoService;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Publicacao> GetAll()
        {
            return null;
        }

        [HttpGet]
        [Route("Get")]
        public Publicacao Get(int Id)
        {
            return null;
        }

        [HttpPost]
        [Route("Post")]
        public bool Post(string conteudo)
        {
            return true;
        }

        [HttpPut]
        [Route("Put")]
        public bool Put(string conteudo)
        {
            return true;
        }

        [HttpDelete]
        [Route("Delete")]
        public Publicacao Delete(int Id)
        {
            return null;
        }
    }
}