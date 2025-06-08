using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceManager.Repository.Repositories;

public class BankingMethodRepository(MyDbContext context) : GenericRepository<BankingMethod>(context)
{
    
}