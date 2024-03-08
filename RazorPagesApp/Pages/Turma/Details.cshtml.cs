using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Data;
using RazorPagesApp.Data.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages_Turma
{
    public class DetailsModel : PageModel
    {
        private readonly ITurmaData _turmaData;

        public DetailsModel(ITurmaData turmaData)
        {
            _turmaData = turmaData;
        }

        public TurmaModel TurmaModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turmamodel = await _turmaData.ConsultarPorId(id.GetValueOrDefault());

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
