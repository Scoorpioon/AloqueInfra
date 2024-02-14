using AloqueInfra.Models;
using AloqueInfra.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AloqueInfra.Controllers
{
    public class ClienteController : Controller
    {
        FuncoesGerais<ClienteModelo> _funcoesGerais;

        public ClienteController(FuncoesGerais<ClienteModelo> funcoes)
        {
            _funcoesGerais = funcoes;
        }

        public IActionResult Index()
        {
            List<ClienteModelo> todosClientes = _funcoesGerais.BuscarTodos();
            return View(todosClientes);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ClienteModelo cliente)
        {
            _funcoesGerais.Adicionar(cliente);
            return RedirectToAction("Index");
        }
    }
}