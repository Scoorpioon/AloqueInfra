using System.ComponentModel.DataAnnotations;

namespace AloqueInfra.Models
{
    public class AlocacaoModelo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, digite o valor de alocação")]
        [Range(0, 10000)]
        public decimal ValorAlocacao { get; set; }

        public bool valorFechado { get; set; }

        [Required(ErrorMessage = "Insira a data de início")]
        public DateTime dataInicio { get; set; }

        [Required(ErrorMessage = "Insira a data final")]
        public DateTime dataFim { get; set; }

        //public ICollection<ColaboradorModelo> Colaboradores {  get; set; }
    }
}