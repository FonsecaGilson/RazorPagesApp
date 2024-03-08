using RazorPagesApp.HttpClient.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Data
{
    public class AlunoDataApi : Interface.IAlunoData
    {
        private readonly IAlunoHttpClient _AlunoData;

        public AlunoDataApi(IAlunoHttpClient alunoData)
        {
            _AlunoData = alunoData;
        }

        public async Task<int> Inserir(AlunoModel aluno)
        {
            return await _AlunoData.Inserir(aluno);
        }

        public async Task Alterar(AlunoModel aluno)
        {
            await _AlunoData.Alterar(aluno);
        }

        public async Task Excluir(int id)
        {
            await _AlunoData.Excluir(id);
        }

        public async Task<AlunoModel> ConsultarPorId(int id)
        {
            return await _AlunoData.ConsultarPorId(id);
        }

        public async Task<IEnumerable<AlunoModel>> Listar()
        {
            return await _AlunoData.Listar();
        }
    }
}
