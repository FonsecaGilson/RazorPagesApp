using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Data.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Aluno
{
    public class EditModel : PageModel
    {
        private readonly IAlunoData _alunoData;

        public EditModel(IAlunoData alunoData)
        {
            _alunoData = alunoData;
        }

        [BindProperty]
        public AlunoModel Aluno { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = await _alunoData.ConsultarPorId(id.GetValueOrDefault());

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

            await _alunoData.Alterar(Aluno);

            return RedirectToPage("./Index");
        }
    }
}
