using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Data.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Turma
{
    public class CreateModel : PageModel
    {
        private readonly ITurmaData _turmaData;

        public CreateModel(ITurmaData turmaData)
        {
            _turmaData = turmaData;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TurmaModel TurmaModel { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _turmaData.Inserir(TurmaModel);

            return RedirectToPage("./Index");
        }
    }
}
