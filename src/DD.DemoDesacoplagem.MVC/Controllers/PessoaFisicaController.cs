using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DD.DemoDesacoplagem.Application;
using DD.DemoDesacoplagem.Application.Interfaces;
using DD.DemoDesacoplagem.Application.ViewModels;
using DD.DemoDesacoplagem.Infra.CrossCutting.Identity.Context;

namespace DD.DemoDesacoplagem.MVC.Controllers
{
    public class PessoaFisicaController : Controller
    {
        private readonly IPessoaFisicaAppService _pessoaFisicaAppService;

        public PessoaFisicaController(IPessoaFisicaAppService pessoaFisicaAppService)
        {
            _pessoaFisicaAppService = pessoaFisicaAppService;
        }

        // GET: PessoaFisica
        public ActionResult Index()
        {
            var pfs = _pessoaFisicaAppService.GetAll();

            return View(pfs);
        }

        // GET: PessoaFisica/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PessoaPessoaFisicaViewModel pessoaPessoaFisicaViewModel = _pessoaFisicaAppService.ObjectForId(id.Value);
            if (pessoaPessoaFisicaViewModel == null)
            {
                return HttpNotFound();
            }
            return View(pessoaPessoaFisicaViewModel);
        }

        // GET: PessoaFisica/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PessoaFisica/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,CPF,PessoaId,Email")] PessoaPessoaFisicaViewModel pessoaPessoaFisicaViewModel)
        {
            if (ModelState.IsValid)
            {
                _pessoaFisicaAppService.Add(pessoaPessoaFisicaViewModel);
                
                return RedirectToAction("Index");
            }

            return View(pessoaPessoaFisicaViewModel);
        }

        // GET: PessoaFisica/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PessoaPessoaFisicaViewModel pessoaPessoaFisicaViewModel = _pessoaFisicaAppService.ObjectForId(id);
            if (pessoaPessoaFisicaViewModel == null)
            {
                return HttpNotFound();
            }
            return View(pessoaPessoaFisicaViewModel);
        }

        // POST: PessoaFisica/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,CPF,PessoaId,Email")] PessoaPessoaFisicaViewModel pessoaPessoaFisicaViewModel)
        {
            if (ModelState.IsValid)
            {
                _pessoaFisicaAppService.Update(pessoaPessoaFisicaViewModel);
                return RedirectToAction("Index");
            }
            return View(pessoaPessoaFisicaViewModel);
        }               
    }
}
