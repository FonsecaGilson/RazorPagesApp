using RazorPagesApp.Data;
using RazorPagesApp.HttpClient;
using RazorPagesApp.HttpClient.Interface;
using Refit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesApp.Data.Interface;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

builder.Services.AddRazorPages();
builder.Services.AddDbContext<RazorPagesAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPagesAppContext") ?? throw new InvalidOperationException("Connection string 'RazorPagesAppContext' not found.")));

builder.Services.AddTransient<IAlunoData, AlunoDataApi>();
builder.Services.AddTransient<ITurmaData, TurmaDataApi>();
builder.Services.AddTransient<IInscricaoData, InscricaoDataApi>();

builder.Services.AddTransient<AuthHeadersHandler>();

builder.Services.AddRefitClient<IAlunoHttpClient>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(config["ServicesUrls:TestApi"]))
    .AddHttpMessageHandler<AuthHeadersHandler>();

builder.Services.AddRefitClient<ITurmaHttpClient>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(config["ServicesUrls:TestApi"]))
    .AddHttpMessageHandler<AuthHeadersHandler>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");

    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
