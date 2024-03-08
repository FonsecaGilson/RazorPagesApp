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

namespace RazorPagesApp.Pages_Inscricao
{
    public class IndexModel : PageModel
    {
        private readonly IInscricaoData _inscricaoData;

        public IndexModel(IInscricaoData inscricaoData)
        {
            _inscricaoData = inscricaoData;
        }

        public IList<InscricaoModel> InscricaoModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            InscricaoModel = (await _inscricaoData.Listar()).ToList();
        }
    }
}
