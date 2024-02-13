using AloqueInfra.Models;
using SiteContatos.Data;

namespace AloqueInfra.Repository
{
    public class ClienteRepository : FuncoesGerais<ClienteModelo>
    {
        private readonly DatabaseContext _DatabaseContext;
        public ClienteRepository(DatabaseContext contextoDoBanco)
        {
            _DatabaseContext = contextoDoBanco;
        }

        ClienteModelo FuncoesGerais<ClienteModelo>.Adicionar(ClienteModelo cliente)
        {
            _DatabaseContext.Clientes.Add(cliente);
            _DatabaseContext.SaveChanges();
            return cliente;
        }
    }
}
