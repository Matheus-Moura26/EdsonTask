using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceManager.Repository.Repositories;

public class BankAccountRepository(MyDbContext context) : GenericRepository<BankAccount>(context)
{
    
}