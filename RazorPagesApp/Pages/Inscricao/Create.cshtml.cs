using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Data.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Inscricao
{
    public class CreateModel : PageModel
    {
        private readonly IInscricaoData _inscricaoData;

        public CreateModel(IInscricaoData inscricaoData)
        {
            _inscricaoData = inscricaoData;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public InscricaoModel InscricaoModel { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _inscricaoData.Inserir(InscricaoModel);

            return RedirectToPage("./Index");
        }
    }
}
