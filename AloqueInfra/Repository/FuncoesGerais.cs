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

        /*void AtualizarDados(Modelo dadosOriginais, Modelo dadosNovos, string nomeIdentificador, List<string> campos)
        {
            for(int contador = 0;  contador < campos.Count; contador++)
            {
                dadosOriginais.$"{nomeIdentificador}{campos[contador]}" = nomeIdentificador.dadosNovos;
            }
        }*/
    }
}

