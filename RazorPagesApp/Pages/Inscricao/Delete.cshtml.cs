using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Data;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Inscricao
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesApp.Data.RazorPagesAppContext _context;

        public DeleteModel(RazorPagesApp.Data.RazorPagesAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public InscricaoModel InscricaoModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscricaomodel = await _context.InscricaoModel.FirstOrDefaultAsync(m => m.Id == id);

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

            var inscricaomodel = await _context.InscricaoModel.FindAsync(id);
            if (inscricaomodel != null)
            {
                InscricaoModel = inscricaomodel;
                _context.InscricaoModel.Remove(InscricaoModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
