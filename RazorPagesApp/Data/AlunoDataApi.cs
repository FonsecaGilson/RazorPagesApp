using RazorPagesApp.HttpClient.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Data
{
    public class AlunoDataApi : Interface.IAlunoData
    {
        private readonly IAlunoHttpClient _alunoData;

        public AlunoDataApi(IAlunoHttpClient alunoData)
        {
            _alunoData = alunoData;
        }

        public async Task<int> Inserir(AlunoModel aluno)
        {
            return await _alunoData.Inserir(aluno);
        }

        public async Task Alterar(AlunoModel aluno)
        {
            await _alunoData.Alterar(aluno);
        }

        public async Task Inativar(int id)
        {
            await _alunoData.Inativar(id);
        }

        public async Task<AlunoModel> ConsultarPorId(int id)
        {
            return await _alunoData.ConsultarPorId(id);
        }

        public async Task<IEnumerable<AlunoModel>> Listar()
        {
            return await _alunoData.Listar();
        }
    }
}
