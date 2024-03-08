using RazorPagesApp.Models;
using Refit;

namespace RazorPagesApp.HttpClient.Interface
{
    public interface IAlunoHttpClient
    {
        [Post("/Inserir")]
        Task<int> Inserir(AlunoModel aluno);

        [Put("/Alterar")]
        Task Alterar(AlunoModel aluno);

        [Delete("/Inativar")]
        Task Inativar(int id);

        [Get("/ConsultarPorId")]
        Task<AlunoModel> ConsultarPorId(int id);

        [Get("/Listar")]
        Task<IEnumerable<AlunoModel>> Listar();
    }
}
