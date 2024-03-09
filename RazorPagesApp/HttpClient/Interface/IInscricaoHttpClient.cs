using RazorPagesApp.Models;
using Refit;

namespace RazorPagesApp.HttpClient.Interface
{
    public interface IInscricaoHttpClient
    {
        [Post("/Inserir")]
        Task<int> Inserir(InscricaoModel inscricao);

        [Put("/Alterar")]
        Task Alterar(InscricaoModel inscricao);

        [Delete("/Inativar/{id}")]
        Task Inativar(int id);

        [Get("/ConsultarPorId/{id}")]
        Task<InscricaoModel> ConsultarPorId(int id);

        [Get("/Listar")]
        Task<IEnumerable<InscricaoModel>> Listar();
    }
}
