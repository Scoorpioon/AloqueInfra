using AloqueInfra.Models;
using AloqueInfra.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AloqueInfra.Controllers
{
    public class UsuarioController : Controller
    {
        FuncoesGerais<UsuarioModelo> _funcoesGerais;

        public UsuarioController(FuncoesGerais<UsuarioModelo> funcoes)
        {
            _funcoesGerais = funcoes;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Deletar(int id)
        {
            _funcoesGerais.Apagar(id);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            UsuarioModelo usuario = _funcoesGerais.BuscarPorID(id);
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Cadastrar(UsuarioModelo usuario)
        {
            _funcoesGerais.Adicionar(usuario);
            return RedirectToAction("Index", "Home", null);
        }

        [HttpPost]
        public IActionResult Editar(UsuarioModelo usuario)
        {
            _funcoesGerais.Editar(usuario);
            return RedirectToAction("Index", "Home", null);
        }
    }
}