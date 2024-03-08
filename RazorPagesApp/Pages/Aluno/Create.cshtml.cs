using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Data;
using RazorPagesApp.Data.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Aluno
{
    public class CreateModel : PageModel
    {
        private readonly IAlunoData _alunoData;

        public CreateModel(IAlunoData alunoData)
        {
            _alunoData = alunoData;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AlunoModel Aluno { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _alunoData.Inserir(Aluno);

            return RedirectToPage("./Index");
        }
    }
}
