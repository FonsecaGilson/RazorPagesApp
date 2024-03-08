using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesApp.Models
{
    public class Turma
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Turma é obrigatório.")]
        [MaxLength(45, ErrorMessage = "Turma não deve ter mais que 45 caracteres.")]
        [MinLength(3, ErrorMessage = "Turma não deve ter menos que 3 caracteres.")]
        [DisplayName("Turma")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Ano é obrigatório.")]
        [Range(2000, 2100, ErrorMessage = "Ano deve ser entre 2000 e 2100")]
        [DisplayName("Ano")]
        public required int Ano { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório.")]
        [MaxLength(60, ErrorMessage = "Senha não deve ter mais que 60 caracteres.")]
        [MinLength(3, ErrorMessage = "Senha não deve ter menos que 3 caracteres.")]
        [DisplayName("Senha")]
        public required string Senha { get; set; }
    }
}
