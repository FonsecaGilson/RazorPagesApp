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

namespace RazorPagesApp.Pages_Inscricao
{
    public class EditModel : PageModel
    {
        private readonly IInscricaoData _inscricaoData;

        public EditModel(IInscricaoData inscricaoData)
        {
            _inscricaoData = inscricaoData;
        }

        [BindProperty]
        public InscricaoModel InscricaoModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscricaomodel =  await _inscricaoData.ConsultarPorId(id.GetValueOrDefault());
            
            if (inscricaomodel == null)
            {
                return NotFound();
            }

            InscricaoModel = inscricaomodel;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _inscricaoData.Alterar(InscricaoModel);

            return RedirectToPage("./Index");
        }
    }
}
