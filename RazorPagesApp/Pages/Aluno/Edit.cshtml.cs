using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Data;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Aluno
{
    public class EditModel : PageModel
    {
        private readonly AlunoDataApi _alunoHttpClient;

        public EditModel(AlunoDataApi alunoHttpClient)
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

            Aluno = aluno;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _alunoHttpClient.Alterar(Aluno);

            return RedirectToPage("./Index");
        }
    }
}
