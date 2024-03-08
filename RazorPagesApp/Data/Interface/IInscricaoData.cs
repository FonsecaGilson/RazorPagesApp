using RazorPagesApp.Models;

namespace RazorPagesApp.Data.Interface
{
    public interface IInscricaoData
    {
        public Task<int> Inserir(InscricaoModel inscricao);

        public Task Alterar(InscricaoModel inscricao);

        public Task Inativar(int id);

        public Task<InscricaoModel> ConsultarPorId(int id);

        public Task<IEnumerable<InscricaoModel>> Listar();
    }
}
