using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View___Web.Controllers
{
    public class ContaPagarController : Controller
    {
        ContaPagarRepository repository = new ContaPagarRepository();

        public ActionResult Index()
        {
            List<ContaPagar> contasPagar = repository.ObterTodos("");

            ViewBag.ContasPagar = contasPagar;

            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Store(string nome, decimal valor, string tipo)
        {
            ContaPagar contaPagar = new ContaPagar();
            contaPagar.Nome = nome;
            contaPagar.Valor = valor;
            contaPagar.Tipo = tipo;
            int id = repository.Inserir(contaPagar);

            return RedirectToAction("Index");
        }

        public ActionResult Apagar(int id)
        {
            repository.Apagar(id);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            ContaPagar contaPagar = repository.ObterPeloId(id);
            ViewBag.ContaPagar = contaPagar;

            return View();
        }

        public ActionResult Update(int id, string nome, decimal valor, string tipo)
        {
            ContaPagar contaPagar = new ContaPagar();
            contaPagar.Id = id;
            contaPagar.Nome = nome;
            contaPagar.Valor = valor;
            contaPagar.Tipo = tipo;
            repository.Alterar(contaPagar);

            return RedirectToAction("Index");
        }
    }
}