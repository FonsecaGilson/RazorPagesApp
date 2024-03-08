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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesApp.Data.RazorPagesAppContext _context;

        public DetailsModel(RazorPagesApp.Data.RazorPagesAppContext context)
        {
            _context = context;
        }

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
    }
}
