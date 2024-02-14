using AloqueInfra.Models;

namespace AloqueInfra.Repository
{
    public interface FuncoesGerais<Modelo>
    {
        public Modelo BuscarPorID(int ID);
        public List<Modelo> BuscarTodos();

        public Modelo Adicionar(Modelo cliente);
        public Modelo Editar(Modelo cliente);
        public bool Apagar(int ID);
    }
}