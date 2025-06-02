using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceManager.Repository.Repositories;

public class TransactionRepository(DbContext context) : GenericRepository<Transaction>(context)
{
    
}