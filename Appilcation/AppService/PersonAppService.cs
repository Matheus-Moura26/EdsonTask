

using Microsoft.AspNetCore.Mvc;
using FinanceManager.Domain.Entities;
using FinanceManager.Repository.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;

namespace FinanceManager.Application.AppService;

public class PersonAppService(PersonRepository personRepository)
{
    public async Task<Person?> Get(int id)
    {
        return await personRepository.GetByIdAsync(id);
    }

    public async Task<List<Person>> GetAll()
    {
        return await personRepository.GetAllAsync();
    }
}




