using AloqueInfra.Models;
using AloqueInfra.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AloqueInfra.Controllers
{
    public class AlocacaoController : Controller
    {
        FuncoesGerais<AlocacaoModelo> _funcoesAlocacao;
        FuncoesGerais<ClienteModelo> _funcoesClientes;
        FuncoesGerais<RecursoModelo> _funcoesRecursos;

        public AlocacaoController(FuncoesGerais<AlocacaoModelo> funcoes, FuncoesGerais<ClienteModelo> clientes, FuncoesGerais<RecursoModelo> recursos)
        {
            _funcoesAlocacao = funcoes;
            _funcoesClientes = clientes;
            _funcoesRecursos = recursos;
        }

        public IActionResult Index()
        {
            // List<AlocacaoModelo> todasAlocacoes = _funcoesGerais.BuscarTodos();
            return View();
        }

        public IActionResult Criar()
        {
            AlocacaoModelo alocacao = new AlocacaoModelo();

            ViewBag.todosClientes = _funcoesClientes.BuscarTodos();
            ViewBag.todosFuncionarios = _funcoesRecursos.BuscarTodos();

            /*var modelos = new ClienteRecursoAlocacaoVM
            {
                Alocacoes = alocacao,
                Clientes = _funcoesClientes.BuscarTodos()
                
            }; */

            return View();
        }

        public IActionResult Deletar(int id)
        {
            _funcoesAlocacao.Apagar(id);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            // ClienteModelo alocacao = _funcoesGerais.BuscarPorID(id);
            return View();
        }

        [HttpPost]
        public IActionResult Criar(AlocacaoModelo alocacao)
        {
            _funcoesAlocacao.Adicionar(alocacao);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(AlocacaoModelo alocacao)
        {
            _funcoesAlocacao.Editar(alocacao);
            return RedirectToAction("Index");
        }
    }
}