using RazorPagesApp.Models;

namespace RazorPagesApp.Data.Interface
{
    public interface IAlunoData
    {
        public Task<int> Inserir(Aluno aluno);

        public Task Alterar(Aluno aluno);

        public Task Excluir(int id);

        public Task<Aluno> ConsultarPorId(int id);

        public Task<IEnumerable<Aluno>> Listar();
    }
}
