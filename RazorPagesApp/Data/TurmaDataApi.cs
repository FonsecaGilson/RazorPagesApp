using RazorPagesApp.HttpClient.Interface;

namespace RazorPagesApp.Data
{
    public class TurmaDataApi : Interface.ITurmaData
    {
        private readonly ITurmaHttpClient _TurmaData;

        public TurmaDataApi(ITurmaHttpClient turmaData)
        {
            _TurmaData = turmaData;
        }

        public async Task<object> Inserir(object turma)
        {
            return await _TurmaData.Inserir(turma);
        }

        public async Task<object> Alterar(object turma)
        {
            return await _TurmaData.Alterar(turma);
        }

        public async Task<object> Excluir(object turma)
        {
            return await _TurmaData.Excluir(turma);
        }

        public async Task<object> ConsultarPorId(object turma)
        {
            return await _TurmaData.ConsultarPorId(turma);
        }

        public async Task<object> Listar(object turma)
        {
            return await _TurmaData.Listar(turma);
        }
    }
}
