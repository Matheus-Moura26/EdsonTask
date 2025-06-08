using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceManager.Repository.Repositories;

public class TransactionRepository(MyDbContext context) : GenericRepository<Transaction>(context)
{
    
}