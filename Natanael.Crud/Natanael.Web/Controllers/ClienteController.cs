using Natanael.Aplicacao.Clientes;
using Natanael.Aplicacao.Clientes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Natanael.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IServicoDeGestaoDeClientes _servicoDeGestaoDeClientes;

        public ClienteController(IServicoDeGestaoDeClientes servicoDeGestaoDeClientes)
        {
            this._servicoDeGestaoDeClientes = servicoDeGestaoDeClientes;
        }

        public ActionResult Index(ModeloDeListaDeClientes modelo)
        {
            modelo = this._servicoDeGestaoDeClientes.BuscarClientesPorPaginacao(modelo.Filtro, 1);

            return View(modelo);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(ModeloDeCadastroDeCliente modelo)
        {
            var retorno = this._servicoDeGestaoDeClientes.Cadastrar(modelo);

            return RedirectToAction(nameof(Index));
        }
    }
}