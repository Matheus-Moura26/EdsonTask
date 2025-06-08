using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceManager.Repository.Repositories;

public class PersonRepository(MyDbContext context) : GenericRepository<Person>(context)
{
    
}