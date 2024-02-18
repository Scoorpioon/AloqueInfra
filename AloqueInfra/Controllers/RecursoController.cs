using AloqueInfra.Models;
using AloqueInfra.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AloqueInfra.Controllers
{
    public class RecursoController : Controller
    {
        FuncoesGerais<RecursoModelo> _funcoesGerais;

        public RecursoController(FuncoesGerais<RecursoModelo> funcoes)
        {
            _funcoesGerais = funcoes;
        }

        public IActionResult Index()
        {
            List<RecursoModelo> todosFuncionarios = _funcoesGerais.BuscarTodos();
            return View(todosFuncionarios);
        }

        public IActionResult Criar()
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
            RecursoModelo funcionario = _funcoesGerais.BuscarPorID(id);
            return View(funcionario);
        }

        [HttpPost]
        public IActionResult Criar(RecursoModelo funcionario)
        {
            _funcoesGerais.Adicionar(funcionario);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(RecursoModelo funcionario)
        {
            _funcoesGerais.Editar(funcionario);
            return RedirectToAction("Index");
        }
    }
}