using System.ComponentModel.DataAnnotations;

namespace AloqueInfra.Models
{
    public class ClienteModelo
    {
        public int Id { get; set;}

        [Required(ErrorMessage = "Por favor, digite o nome do cliente")]
        public string Nome { get; set;}

        [Required(ErrorMessage = "O CNPJ do cliente é obrigatório.")]
        public string CNPJ { get; set;}

        [Required(ErrorMessage = "O telefone do cliente é essencial para contato.")]
        public string Telefone { get; set;}

        [Required(ErrorMessage = "O e-mail do cliente é essencial para contato.")]
        public string Email { get; set;}

        [Required(ErrorMessage = "Por favor, digite o endereço do cliente")]
        public string Endereço { get; set;}
    }
}