using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceManager.Repository.Repositories;

public class PersonRepository(DbContext context) : GenericRepository<Person>(context)
{
    
}