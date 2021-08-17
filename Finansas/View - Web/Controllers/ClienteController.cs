using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View___Web.Controllers
{
    public class ClienteController : Controller
    {
        ClienteRepository repository = new ClienteRepository();

        public ActionResult Index()
        {
            List<Cliente> clientes = repository.ObterTodos("");

            ViewBag.Clientes = clientes;

            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Store(string nome, string cpf, string rg)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Cpf = cpf;
            cliente.Rg = rg;
            int id = repository.Inserir(cliente);

            return RedirectToAction("Index");
        }

        public ActionResult Apagar(int id)
        {
            repository.Apagar(id);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            Cliente cliente = repository.ObterPeloId(id);

            ViewBag.Cliente = cliente;

            return View();
        }

        public ActionResult Update(int id, string nome, string cpf, string rg)
        {
            Cliente cliente = new Cliente();
            cliente.Id = id;
            cliente.Nome = nome;
            cliente.Cpf = cpf;
            cliente.Rg = rg;
            bool alterou = repository.Alterar(cliente);

            return RedirectToAction("Index");
        }
    }
}