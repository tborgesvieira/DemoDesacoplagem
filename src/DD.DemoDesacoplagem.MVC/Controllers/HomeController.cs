using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DD.DemoDesacoplagem.Application.Interfaces;
using DD.DemoDesacoplagem.Application.ViewModels;

namespace DD.DemoDesacoplagem.MVC.Controllers
{    
    public class HomeController : Controller
    {
        private readonly IPessoaFisiacaAppService _pessoaFisiacaAppService;

        public HomeController(IPessoaFisiacaAppService pessoaFisiacaAppService)
        {
            _pessoaFisiacaAppService = pessoaFisiacaAppService;
        }

        public ActionResult Index()
        {
            var pf = new PessoaPessoaFisicaViewModel();

            pf.CPF = "00673908119";

            pf.Nome = "Thiago";

            _pessoaFisiacaAppService.Add(pf);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}