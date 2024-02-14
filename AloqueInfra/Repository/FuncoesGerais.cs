using AloqueInfra.Models;

namespace AloqueInfra.Repository
{
    public interface FuncoesGerais<Modelo>
    {
        Modelo BuscarPorID(int ID);
        List<Modelo> BuscarTodos();

        Modelo Adicionar(Modelo cliente);
        Modelo Editar(Modelo cliente);
        bool Apagar(Modelo cliente);
    }
}