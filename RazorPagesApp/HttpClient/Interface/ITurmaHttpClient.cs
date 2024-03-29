﻿using RazorPagesApp.Models;
using Refit;

namespace RazorPagesApp.HttpClient.Interface
{
    public interface ITurmaHttpClient
    {
        [Post("/Inserir")]
        Task<int> Inserir(TurmaModel turma);

        [Put("/Alterar")]
        Task Alterar(TurmaModel turma);

        [Delete("/Inativar/{id}")]
        Task Inativar(int id);

        [Get("/ConsultarPorId/{id}")]
        Task<TurmaModel> ConsultarPorId(int id);

        [Get("/Listar")]
        Task<IEnumerable<TurmaModel>> Listar();
    }
}
