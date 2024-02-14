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

        bool FuncoesGerais<ClienteModelo>.Apagar(ClienteModelo cliente)
        {

            _DatabaseContext.Clientes.Remove(cliente);
            _DatabaseContext.SaveChanges();

            return true;
        }
        ClienteModelo FuncoesGerais<ClienteModelo>.Editar(ClienteModelo cliente)
        {
            return cliente;
        }

        ClienteModelo FuncoesGerais<ClienteModelo>.BuscarPorID(int ID)
        {
            return _DatabaseContext.Clientes.FirstOrDefault(contato => contato.Id == ID);
        }

        List<ClienteModelo> FuncoesGerais<ClienteModelo>.BuscarTodos()
        {
            return _DatabaseContext.Clientes.ToList();
        }
    }
}