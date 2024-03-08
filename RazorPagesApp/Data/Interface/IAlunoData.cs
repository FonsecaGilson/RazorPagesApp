using RazorPagesApp.Models;

namespace RazorPagesApp.Data.Interface
{
    public interface IAlunoData
    {
        public Task<int> Inserir(AlunoModel aluno);

        public Task Alterar(AlunoModel aluno);

        public Task Excluir(int id);

        public Task<AlunoModel> ConsultarPorId(int id);

        public Task<IEnumerable<AlunoModel>> Listar();
    }
}
