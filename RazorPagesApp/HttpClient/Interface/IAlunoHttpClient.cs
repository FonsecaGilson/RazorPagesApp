using RazorPagesApp.Models;
using Refit;

namespace RazorPagesApp.HttpClient.Interface
{
    public interface IAlunoHttpClient
    {
        [Post("/Inserir")]
        Task<int> Inserir(Aluno aluno);

        [Put("/Alterar")]
        Task Alterar(Aluno aluno);

        [Delete("/Excluir")]
        Task Excluir(int id);

        [Get("/ConsultarPorId")]
        Task<Aluno> ConsultarPorId(int id);

        [Get("/Listar")]
        Task<IEnumerable<Aluno>> Listar();
    }
}
