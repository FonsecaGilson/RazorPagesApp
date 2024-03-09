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
            try
            {
                return await _turmaData.Inserir(turma);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task Alterar(TurmaModel turma)
        {
            try
            {
                await _turmaData.Alterar(turma);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task Inativar(int id)
        {
            try
            {
                await _turmaData.Inativar(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<TurmaModel> ConsultarPorId(int id)
        {
            try
            {
                return await _turmaData.ConsultarPorId(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<TurmaModel>> Listar()
        {
            try
            {
                return await _turmaData.Listar();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
