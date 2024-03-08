using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Data.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Aluno
{
    public class IndexModel : PageModel
    {
        private readonly IAlunoData _alunoData;

        public IndexModel(IAlunoData alunoData)
        {
            _alunoData = alunoData;
        }

        public IList<AlunoModel> Aluno { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Aluno = (await _alunoData.Listar()).ToList();
        }
    }
}
