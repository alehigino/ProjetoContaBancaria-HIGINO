using ProjetoContaBancaria.Application;
using ProjetoContaBancaria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoContaBancaria.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ClienteApplication _clienteApplication = new ClienteApplication();

        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Fazer_Login(Cliente cliente)
        {
            ViewBag.retorno = _clienteApplication.ConsLogin(cliente.Nom_Email, cliente.Nom_Senha);
            return View();
        }
    }
}