using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Data.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Inscricao
{
    public class DeleteModel : PageModel
    {
        private readonly IInscricaoData _inscricaoData;

        public DeleteModel(IInscricaoData inscricaoData)
        {
            _inscricaoData = inscricaoData;
        }

        [BindProperty]
        public InscricaoModel InscricaoModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscricaomodel = await _inscricaoData.ConsultarPorId(id.GetValueOrDefault());

            if (inscricaomodel == null)
            {
                return NotFound();
            }
            else
            {
                InscricaoModel = inscricaomodel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await _inscricaoData.Inativar(id.GetValueOrDefault());

            return RedirectToPage("./Index");
        }
    }
}
