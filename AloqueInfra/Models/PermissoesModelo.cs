using System.ComponentModel.DataAnnotations;

namespace AloqueInfra.Models
{
    public class PermissoesModelo
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Nome { get; set; }

        [StringLength(255)]
        public string Descricao { get; set; }

    }
}
