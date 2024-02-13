using AloqueInfra.Models;

namespace AloqueInfra.Repository
{
    public interface FuncoesGerais<Modelo>
    {
        ClienteModelo Adicionar(Modelo cliente);
    }
}
