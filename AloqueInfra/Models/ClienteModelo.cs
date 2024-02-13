using System.ComponentModel.DataAnnotations;

namespace AloqueInfra.Models
{
    public class ClienteModelo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, digite o nome do cliente")]
        [StringLength(60)]
        public string clienteNome { get; set; }

        [Required(ErrorMessage = "O CNPJ do cliente é obrigatório.")]
        [StringLength(14)]
        public string clienteCNPJ { get; set; }

        [Required(ErrorMessage = "O telefone do cliente é essencial para contato.")]
        [StringLength(12)]
        public string clienteTelefone { get; set; }

        [Required(ErrorMessage = "O e-mail do cliente é essencial para contato.")]
        [StringLength(60)]
        public string clienteEmail { get; set; }

        [Required(ErrorMessage = "Por favor, digite o endereço do cliente")]
        [StringLength(100)]
        public string clienteEndereco { get; set; }

        public bool clienteEmDebito { get; set; }

        public DateTime Datacad {  get; set; }

        public DateTime Updatedat { get; set; }
    }
}