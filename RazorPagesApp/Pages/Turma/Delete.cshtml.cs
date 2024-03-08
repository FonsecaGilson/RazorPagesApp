using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Data.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Turma
{
    public class DeleteModel : PageModel
    {
        private readonly ITurmaData _turmaData;

        public DeleteModel(ITurmaData turmaData)
        {
            _turmaData = turmaData;
        }

        [BindProperty]
        public TurmaModel TurmaModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turmamodel = await _turmaData.ConsultarPorId(id.GetValueOrDefault());

            if (turmamodel == null)
            {
                return NotFound();
            }
            else
            {
                TurmaModel = turmamodel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await _turmaData.Inativar(id.GetValueOrDefault());

            return RedirectToPage("./Index");
        }
    }
}
