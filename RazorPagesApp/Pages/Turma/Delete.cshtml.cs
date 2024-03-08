using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Data;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Turma
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesApp.Data.RazorPagesAppContext _context;

        public DeleteModel(RazorPagesApp.Data.RazorPagesAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TurmaModel TurmaModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turmamodel = await _context.TurmaModel.FirstOrDefaultAsync(m => m.Id == id);

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

            var turmamodel = await _context.TurmaModel.FindAsync(id);
            if (turmamodel != null)
            {
                TurmaModel = turmamodel;
                _context.TurmaModel.Remove(TurmaModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
