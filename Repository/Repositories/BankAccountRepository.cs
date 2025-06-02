using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceManager.Repository.Repositories;

public class BankAccountRepository(DbContext context) : GenericRepository<BankAccount>(context)
{
    
}