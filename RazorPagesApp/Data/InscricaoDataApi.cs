using RazorPagesApp.HttpClient.Interface;
using RazorPagesApp.Models;

namespace RazorPagesApp.Data
{
    public class InscricaoDataApi : Interface.IInscricaoData
    {

        public Task Alterar(InscricaoModel inscricao)
        {
            throw new NotImplementedException();
        }

        public Task<InscricaoModel> ConsultarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task Inativar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Inserir(InscricaoModel inscricao)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InscricaoModel>> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
