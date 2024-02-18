using AloqueInfra.Models;
using AloqueInfra.Repository;
using Microsoft.EntityFrameworkCore;
using SiteContatos.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer("Server=GABRIEL;Database=DB_AloqueInfra;Integrated Security=SSPI;TrustServerCertificate=Yes");
});
builder.Services.AddScoped<FuncoesGerais<ClienteModelo>, ClienteRepository>();
builder.Services.AddScoped<FuncoesGerais<RecursoModelo>, RecursoRepository>();
builder.Services.AddScoped<FuncoesGerais<AlocacaoModelo>, AlocacaoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
