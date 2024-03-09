using RazorPagesApp.Common.Middleware;
using RazorPagesApp.Data;
using RazorPagesApp.Data.Interface;
using RazorPagesApp.HttpClient;
using RazorPagesApp.HttpClient.Interface;
using Refit;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

builder.Services.AddRazorPages();

builder.Services.AddTransient<IAlunoData, AlunoDataApi>();
builder.Services.AddTransient<ITurmaData, TurmaDataApi>();
builder.Services.AddTransient<IInscricaoData, InscricaoDataApi>();

builder.Services.AddTransient<AuthHeadersHandler>();

builder.Services.AddRefitClient<IAlunoHttpClient>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(config["ServicesUrls:Aluno"]))
    .AddHttpMessageHandler<AuthHeadersHandler>();

builder.Services.AddRefitClient<ITurmaHttpClient>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(config["ServicesUrls:Turma"]))
    .AddHttpMessageHandler<AuthHeadersHandler>();

builder.Services.AddRefitClient<IInscricaoHttpClient>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(config["ServicesUrls:Inscricao"]))
    .AddHttpMessageHandler<AuthHeadersHandler>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");

    app.UseHsts();
}

app.UseApiErrorHandlingMiddleware();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
