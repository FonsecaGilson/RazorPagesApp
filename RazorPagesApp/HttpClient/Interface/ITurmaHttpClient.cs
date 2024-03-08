using Refit;

namespace RazorPagesApp.HttpClient.Interface
{
    public interface ITurmaHttpClient
    {
        [Post("/Inserir")]
        Task<object> Inserir(object turma);

        [Put("/Alterar")]
        Task<object> Alterar(object turma);

        [Delete("/Excluir")]
        Task<object> Excluir(object turma);

        [Get("/ConsultarPorId")]
        Task<object> ConsultarPorId(object turma);

        [Get("/Listar")]
        Task<object> Listar(object turma);
    }
}
