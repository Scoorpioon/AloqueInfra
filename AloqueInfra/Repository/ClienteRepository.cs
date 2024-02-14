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

        public ClienteModelo Adicionar(ClienteModelo cliente)
        {
            _DatabaseContext.Clientes.Add(cliente);
            _DatabaseContext.SaveChanges();
            return cliente;
        }
        public ClienteModelo Editar(ClienteModelo cliente)
        {
            return cliente;
        }

        public ClienteModelo BuscarPorID(int ID)
        {
            return _DatabaseContext.Clientes.FirstOrDefault(contato => contato.Id == ID);
        }

        public List<ClienteModelo> BuscarTodos()
        {
            return _DatabaseContext.Clientes.ToList();
        }

        public bool Apagar(int ID)
        {
            ClienteModelo cliente = BuscarPorID(ID);

            if(cliente == null) throw new Exception("Houve algum erro ao procurar o cliente.");

            _DatabaseContext.Clientes.Remove(cliente);
            _DatabaseContext.SaveChanges();

            return true;
        }
    }
}