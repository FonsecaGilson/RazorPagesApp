using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Data;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Aluno
{
    public class DeleteModel : PageModel
    {
        private readonly AlunoDataApi _alunoHttpClient;

        public DeleteModel(AlunoDataApi alunoHttpClient)
        {
            _alunoHttpClient = alunoHttpClient;
        }

        [BindProperty]
        public AlunoModel Aluno { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = await _alunoHttpClient.ConsultarPorId(id.GetValueOrDefault());

            if (aluno == null)
            {
                return NotFound();
            }
            else
            {
                Aluno = aluno;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await _alunoHttpClient.Excluir(id.GetValueOrDefault());

            return RedirectToPage("./Index");
        }
    }
}
