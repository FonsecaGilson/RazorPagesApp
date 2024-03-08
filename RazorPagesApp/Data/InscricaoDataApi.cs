using RazorPagesApp.Data.Interface;
using RazorPagesApp.HttpClient.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Data
{
    public class InscricaoDataApi : Interface.IInscricaoData
    {
        private readonly IInscricaoHttpClient _inscricaoData;

        public InscricaoDataApi(IInscricaoHttpClient inscricaoData)
        {
            _inscricaoData = inscricaoData;
        }

        public async Task Alterar(InscricaoModel inscricao)
        {
            await _inscricaoData.Alterar(inscricao);
        }

        public async Task<InscricaoModel> ConsultarPorId(int id)
        {
            return await _inscricaoData.ConsultarPorId(id);
        }

        public async Task Inativar(int id)
        {
            await _inscricaoData.Inativar(id);  
        }

        public Task<int> Inserir(InscricaoModel inscricao)
        {
            return _inscricaoData.Inserir(inscricao);   
        }

        public async Task<IEnumerable<InscricaoModel>> Listar()
        {
            return await _inscricaoData.Listar();   
        }
    }
}
