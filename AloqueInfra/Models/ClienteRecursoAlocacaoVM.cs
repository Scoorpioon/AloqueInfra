namespace AloqueInfra.Models
{
    public class ClienteRecursoAlocacaoVM
    {

        public List<ClienteModelo> Clientes {  get; set; }
        public AlocacaoModelo Alocacoes {  get; set; }
        public List<RecursoModelo> Funcionarios { get; set; }
    }
}
