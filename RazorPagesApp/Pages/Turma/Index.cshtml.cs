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
    public class IndexModel : PageModel
    {
        private readonly ITurmaData _turmaData;

        public IndexModel(ITurmaData turmaData)
        {
            _turmaData = turmaData;
        }

        public IList<TurmaModel> TurmaModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            TurmaModel = (await _turmaData.Listar()).ToList();
        }
    }
}
