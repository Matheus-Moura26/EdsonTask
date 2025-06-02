using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceManager.Repository.Repositories;

public class BankingMethodRepository(DbContext context) : GenericRepository<BankingMethod>(context)
{
    
}