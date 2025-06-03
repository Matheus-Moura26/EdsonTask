using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using FinanceManager.Repository.Repositories;

namespace FinanceManager.Appilcation.AppService;

public class TransactionAppService(TransactionRepository transactionRepository)
{
    public Task<Transaction> Create(Transaction transaction)
    {
        
    }
}