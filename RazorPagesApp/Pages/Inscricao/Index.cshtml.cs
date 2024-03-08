using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public IList<InscricaoModel> InscricaoModel { get; set; } = default!;

        public async Task OnGetAsync()
        {
            InscricaoModel = (await _inscricaoData.Listar()).ToList();
        }
    }
}
