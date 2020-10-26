using _1_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_MVC.Controllers
{
    public class PublicacaoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Publicar(FormPublicacaoViewModel viewModel)
        {

            return View("Index");
        }

    }
}