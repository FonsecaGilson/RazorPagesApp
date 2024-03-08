using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Data;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Aluno
{
    public class CreateModel : PageModel
    {
        private readonly AlunoDataApi _alunoHttpClient;

        public CreateModel(AlunoDataApi alunoHttpClient)
        {
            _alunoHttpClient = alunoHttpClient;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Aluno Aluno { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _alunoHttpClient.Inserir(Aluno);

            return RedirectToPage("./Index");
        }
    }
}
