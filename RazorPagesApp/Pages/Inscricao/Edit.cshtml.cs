using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Data;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Inscricao
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesApp.Data.RazorPagesAppContext _context;

        public EditModel(RazorPagesApp.Data.RazorPagesAppContext context)
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

            var inscricaomodel =  await _context.InscricaoModel.FirstOrDefaultAsync(m => m.Id == id);
            if (inscricaomodel == null)
            {
                return NotFound();
            }
            InscricaoModel = inscricaomodel;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(InscricaoModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InscricaoModelExists(InscricaoModel.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool InscricaoModelExists(int id)
        {
            return _context.InscricaoModel.Any(e => e.Id == id);
        }
    }
}
