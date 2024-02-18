using AloqueInfra.Models;
using SiteContatos.Data;

namespace AloqueInfra.Repository
{
    public class UsuarioRepository : FuncoesGerais<UsuarioModelo>
    {
        private readonly DatabaseContext _DatabaseContext;
        public UsuarioRepository(DatabaseContext contextoDoBanco)
        {
            _DatabaseContext = contextoDoBanco;
        }

        public UsuarioModelo Adicionar(UsuarioModelo usuario)
        {
            _DatabaseContext.Usuarios.Add(usuario);
            _DatabaseContext.SaveChanges();
            return usuario;
        }

        public UsuarioModelo BuscarPorID(int ID)
        {
            return _DatabaseContext.Usuarios.FirstOrDefault(usuario => usuario.Id == ID);
        }

        public List<UsuarioModelo> BuscarTodos()
        {
            return _DatabaseContext.Usuarios.ToList();
        }

        public bool Apagar(int ID)
        {
            /*ClienteModelo cliente = BuscarPorID(ID);

            if (cliente == null) throw new Exception("Houve algum erro ao procurar o cliente.");

            _DatabaseContext.Clientes.Remove(cliente);
            _DatabaseContext.SaveChanges();*/

            return true;
        }

        public UsuarioModelo Editar(UsuarioModelo usuario)
        {
            UsuarioModelo dadosOriginais = BuscarPorID(usuario.Id);

            /*if (dadosOriginais == null) throw new Exception("Ocorreu algum erro ao tentar encontrar o contato.");

            dadosOriginais.clienteNome = cliente.clienteNome;
            dadosOriginais.clienteCNPJ = cliente.clienteCNPJ;
            dadosOriginais.clienteEmail = cliente.clienteEmail;
            dadosOriginais.clienteTelefone = cliente.clienteTelefone;
            dadosOriginais.clienteEndereco = cliente.clienteEndereco;

            _DatabaseContext.Clientes.Update(dadosOriginais);
            _DatabaseContext.SaveChanges();*/

            return dadosOriginais;
        }
    }
}