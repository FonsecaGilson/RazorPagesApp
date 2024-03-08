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
        [DisplayName("Aluno")]
        public required int AlunoId { get; set; }

        [Required(ErrorMessage = "Truma é obrigatório.")]
        [DisplayName("Aluno")]
        public required int TurmaId { get; set; }
    }
}
