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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesApp.Data.RazorPagesAppContext _context;

        public IndexModel(RazorPagesApp.Data.RazorPagesAppContext context)
        {
            _context = context;
        }

        public IList<TurmaModel> TurmaModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            TurmaModel = await _context.TurmaModel.ToListAsync();
        }
    }
}
