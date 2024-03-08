﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesApp.Data;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Turma
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesApp.Data.RazorPagesAppContext _context;

        public CreateModel(RazorPagesApp.Data.RazorPagesAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TurmaModel TurmaModel { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TurmaModel.Add(TurmaModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
