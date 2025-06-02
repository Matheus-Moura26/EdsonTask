using FinanceManager.Application.AppService;
using FinanceManager.Domain.Entities;
using FinanceManager.Repository.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyDbContext>(opt =>
    opt.UseInMemoryDatabase("BancoDeTeste") // ou UseNpgsql(...)
);
// Adicionar serviços ao contêiner.
builder.Services.AddScoped<BankingMethodRepository>();
builder.Services.AddScoped<PersonRepository>();
builder.Services.AddScoped<BankAccountRepository>();
builder.Services.AddScoped<TransactionRepository>();

builder.Services.AddScoped<PersonAppService>();

builder.Services.AddControllers();

var app = builder.Build();


app.UseHttpsRedirection();
app.MapControllers();

app.Run();
