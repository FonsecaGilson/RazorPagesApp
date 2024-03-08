using RazorPagesApp.Models;

namespace RazorPagesApp.Data.Interface
{
    public interface ITurmaData
    {
        public Task<int> Inserir(TurmaModel turma);

        public Task Alterar(TurmaModel turma);

        public Task Inativar(int id);

        public Task<TurmaModel> ConsultarPorId(int id);

        public Task<IEnumerable<TurmaModel>> Listar();
    }
}
