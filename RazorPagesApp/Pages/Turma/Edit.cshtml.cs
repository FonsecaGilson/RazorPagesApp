using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Data;
using RazorPagesApp.Data.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Turma
{
    public class EditModel : PageModel
    {
        private readonly ITurmaData _turmaData;

        public EditModel(ITurmaData turmaData)
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

            var turmamodel =  await _turmaData.ConsultarPorId(id.GetValueOrDefault());

            if (turmamodel == null)
            {
                return NotFound();
            }

            TurmaModel = turmamodel;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _turmaData.Alterar(TurmaModel);

            return RedirectToPage("./Index");
        }
    }
}
