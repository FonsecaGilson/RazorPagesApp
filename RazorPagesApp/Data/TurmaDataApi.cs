using RazorPagesApp.HttpClient.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Data
{
    public class TurmaDataApi : Interface.ITurmaData
    {
        private readonly ITurmaHttpClient _turmaData;

        public TurmaDataApi(ITurmaHttpClient turmaData)
        {
            _turmaData = turmaData;
        }

        public async Task<int> Inserir(TurmaModel turma)
        {
            return await _turmaData.Inserir(turma);
        }

        public async Task Alterar(TurmaModel turma)
        {
            await _turmaData.Alterar(turma);
        }

        public async Task Inativar(int id)
        {
            await _turmaData.Inativar(id);
        }

        public async Task<TurmaModel> ConsultarPorId(int id)
        {
            return await _turmaData.ConsultarPorId(id);
        }

        public async Task<IEnumerable<TurmaModel>> Listar()
        {
            return await _turmaData.Listar();
        }
    }
}
