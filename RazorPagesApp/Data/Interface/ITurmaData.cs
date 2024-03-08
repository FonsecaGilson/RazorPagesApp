namespace RazorPagesApp.Data.Interface
{
    public interface ITurmaData
    {
        public Task<object> Inserir(object turma);

        public Task<object> Alterar(object turma);

        public Task<object> Excluir(object turma);

        public Task<object> ConsultarPorId(object turma);

        public Task<object> Listar(object turma);
    }
}
