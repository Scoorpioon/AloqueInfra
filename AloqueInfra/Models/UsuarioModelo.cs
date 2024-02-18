using System.ComponentModel.DataAnnotations;

namespace AloqueInfra.Models
{
    public class UsuarioModelo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome de usuário é obrigatório. (Será desenvolvido " +
            "um sistema de nome de usuário automático no decorrer do processo de desenvolvimento)")]
        [StringLength(20)]
        public string usuarioApelido { get; set; }
        [Required(ErrorMessage = "Por favor, digite o seu nome completo.")]
        [StringLength(60)]
        public string usuarioNomeCompleto { get; set; }

        [Required(ErrorMessage = "Por favor, digite o seu e-mail.")]
        [StringLength(60)]
        public string usuarioEmail { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [StringLength(40)]
        public string usuarioSenha {  get; set; }
    }
}
