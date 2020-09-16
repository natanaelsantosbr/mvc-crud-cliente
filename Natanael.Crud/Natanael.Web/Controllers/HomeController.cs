using Natanael.Aplicacao.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Natanael.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServicoDeGestaoDeClientes _servicoDeGestaoDeClientes;

        public HomeController(IServicoDeGestaoDeClientes servicoDeGestaoDeClientes)
        {
            this._servicoDeGestaoDeClientes = servicoDeGestaoDeClientes;
        }

        public ActionResult Index()
        {
            this._servicoDeGestaoDeClientes.Processar();

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