using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesApp.Models
{
    public class Aluno
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório.")]
        [MaxLength(255, ErrorMessage = "Nome não deve ter mais que 255 caracteres.")]
        [MinLength(3, ErrorMessage = "Nome não deve ter menos que 3 caracteres.")]
        [DisplayName("Nome")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Usuário é obrigatório.")]
        [MaxLength(45, ErrorMessage = "Usuário não deve ter mais que 45 caracteres.")]
        [MinLength(3, ErrorMessage = "Usuário não deve ter menos que 3 caracteres.")]
        [DisplayName("Usuário")]
        public required string Usuario { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório.")]
        [MaxLength(60, ErrorMessage = "Senha não deve ter mais que 60 caracteres.")]
        [MinLength(3, ErrorMessage = "Senha não deve ter menos que 3 caracteres.")]
        [DisplayName("Senha")]
        public required string Senha { get; set; }
    }
}
