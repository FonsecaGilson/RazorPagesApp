using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesApp.Models
{
    public class InscricaoModel
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Aluno é obrigatório.")]
        [DisplayName("AlunoId")]
        public required int AlunoId { get; set; }

        [Required(ErrorMessage = "Turma é obrigatório.")]
        [DisplayName("TurmaId")]
        public required int TurmaId { get; set; }
    }
}
