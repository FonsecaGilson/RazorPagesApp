using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Data.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Turma
{
    public class IndexModel : PageModel
    {
        private readonly ITurmaData _turmaData;

        public IndexModel(ITurmaData turmaData)
        {
            _turmaData = turmaData;
        }

        public IList<TurmaModel> TurmaModel { get; set; } = default!;

        public async Task OnGetAsync()
        {
            TurmaModel = (await _turmaData.Listar()).ToList();
        }
    }
}
