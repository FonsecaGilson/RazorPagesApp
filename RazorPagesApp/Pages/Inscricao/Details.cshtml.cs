using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Data.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Inscricao
{
    public class DetailsModel : PageModel
    {
        private readonly IInscricaoData _inscricaoData;

        public DetailsModel(IInscricaoData inscricaoData)
        {
            _inscricaoData = inscricaoData;
        }

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
    }
}
