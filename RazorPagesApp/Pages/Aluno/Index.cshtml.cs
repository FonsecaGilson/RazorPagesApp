using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Data;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Aluno
{
    public class IndexModel : PageModel
    {
        private readonly AlunoDataApi _alunoHttpClient;

        public IndexModel(AlunoDataApi alunoHttpClient)
        {
            _alunoHttpClient = alunoHttpClient;
        }

        public IList<Aluno> Aluno { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Aluno = (await _alunoHttpClient.Listar()).ToList();
        }
    }
}
