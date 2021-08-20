using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View___Web.Controllers
{
    public class ContaReceberController : Controller
    {
        ContaReceberRepository repository = new ContaReceberRepository();

        public ActionResult Index()
        {
            List<ContaReceber> contasReceber = repository.ObterTodos("");

            ViewBag.ContasReceber = contasReceber;

            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Store(string nome, decimal valor, decimal valorRecebido)
        {
            ContaReceber contaReceber = new ContaReceber();
            contaReceber.Nome = nome;
            contaReceber.Valor = valor;
            contaReceber.ValorRecebido = valorRecebido;
            int id = repository.Inserir(contaReceber);

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            ContaReceber contaReceber = repository.ObterPeloId(id);

            ViewBag.ContaReceber = contaReceber;

            return View();
        }

        public ActionResult Update(int id, string nome, decimal valor, decimal valorRecebido)
        {
            ContaReceber contaReceber = new ContaReceber();
            contaReceber.Id = id;
            contaReceber.Nome = nome;
            contaReceber.Valor = valor;
            contaReceber.ValorRecebido = valorRecebido;
            repository.Alterar(contaReceber);

            return RedirectToAction("Index");
        }

        public ActionResult Apagar(int id)
        {
            repository.Apagar(id);
            return RedirectToAction("Index");
        }
    }
}