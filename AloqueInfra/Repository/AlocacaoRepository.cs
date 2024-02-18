using AloqueInfra.Models;
using SiteContatos.Data;

namespace AloqueInfra.Repository
{
    public class AlocacaoRepository : FuncoesGerais<AlocacaoModelo>
    {
        private readonly DatabaseContext _DatabaseContext;
        public AlocacaoRepository(DatabaseContext contextoDoBanco)
        {
            _DatabaseContext = contextoDoBanco;
        }

        public AlocacaoModelo Adicionar(AlocacaoModelo alocacao)
        {
            _DatabaseContext.Alocacoes.Add(alocacao);
            _DatabaseContext.SaveChanges();
            return alocacao;
        }

        public AlocacaoModelo BuscarPorID(int ID)
        {
            return _DatabaseContext.Alocacoes.FirstOrDefault(alocacao => alocacao.Id == ID);
        }

        public List<AlocacaoModelo> BuscarTodos()
        {
            return _DatabaseContext.Alocacoes.ToList();
        }

        public bool Apagar(int ID)
        {
            AlocacaoModelo alocacao = BuscarPorID(ID);

            if (alocacao == null) throw new Exception("Houve algum erro ao procurar o cliente.");

            _DatabaseContext.Alocacoes.Remove(alocacao);
            _DatabaseContext.SaveChanges();

            return true;
        }

        public AlocacaoModelo Editar(AlocacaoModelo alocacao)
        {
            AlocacaoModelo dadosOriginais = BuscarPorID(alocacao.Id);

            if (dadosOriginais == null) throw new Exception("Ocorreu algum erro ao tentar encontrar o contato.");

            /*dadosOriginais.clienteNome = alocacao.clienteNome;
            dadosOriginais.clienteCNPJ = alocacao.clienteCNPJ;
            dadosOriginais.clienteEmail = alocacao.clienteEmail;
            dadosOriginais.clienteTelefone = alocacao.clienteTelefone;
            dadosOriginais.clienteEndereco = alocacao.clienteEndereco;

            _DatabaseContext.Clientes.Update(dadosOriginais);
            _DatabaseContext.SaveChanges();

            return dadosOriginais; */

            return dadosOriginais;
        }
    }
}