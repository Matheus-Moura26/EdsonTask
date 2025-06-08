
using FinanceManager.Application.AppService;
using FinanceManager.Domain.Entities;
using FinanceManager.Repository.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyDbContext>(opt =>
    opt.UseInMemoryDatabase("MyDbContext")
);

builder.Services.AddScoped<BankingMethodRepository>();
builder.Services.AddScoped<PersonRepository>();
builder.Services.AddScoped<BankAccountRepository>();
builder.Services.AddScoped<TransactionRepository>();

builder.Services.AddScoped<PersonAppService>();
builder.Services.AddScoped<BankAccountAppService>();
builder.Services.AddScoped<BankingMethodAppService>();
builder.Services.AddScoped<TransactionAppService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();


app.Run();
