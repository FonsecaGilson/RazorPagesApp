using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Data;
using RazorPagesApp.Data.Interface;
using RazorPagesApp.HttpClient.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Aluno
{
    public class DeleteModel : PageModel
    {
        private readonly IAlunoData _alunoData;

        public DeleteModel(IAlunoData alunoData)
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

            await _alunoData.Inativar(id.GetValueOrDefault());

            return RedirectToPage("./Index");
        }
    }
}
