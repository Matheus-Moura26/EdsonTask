using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameWork;

namespace FinanceManager.Repository.Repositories;

public class BankAccountRepository(DbContext context) : GenericRepository<BankAccount>(context)
{
    
}