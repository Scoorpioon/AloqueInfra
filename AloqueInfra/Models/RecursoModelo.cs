using System.ComponentModel.DataAnnotations;

namespace AloqueInfra.Models
{
    public class RecursoModelo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, digite o nome do funcionário")]
        [StringLength(60)]
        public string funcNome { get; set; }

        [Required(ErrorMessage = "Por favor, digite o CPF do funcionário")]
        [StringLength(11)]
        public string funcCPF { get; set; }

        [Required(ErrorMessage = "Por favor, digite o RG do funcionário")]
        [StringLength(9)]
        public string funcRG { get; set; }

        [Required(ErrorMessage = "Por favor, digite o e-mail do funcionário")]
        [StringLength(60)]
        public string funcEmail { get; set; }

        [Range(0, 10000)]
        public int FuncTempoAlocacao { get; set; }

        [Required(ErrorMessage = "Digite o valor/comissão diária do funcionário")]
        [Range(1, 1000)]
        public decimal funcValorDiario { get; set; }
    }
}