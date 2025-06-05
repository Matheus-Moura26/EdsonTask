using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceManager.Repository.Repositories;
using FinanceManager.Domain.Entities;

namespace FinanceManager.Appilcation.AppService;

public class TransactionAppService(TransactionRepository transactionRepository)
{
    public async Task<Transaction?> Get(int id)
    {
        return await transactionRepository.GetByIdAsync(id);
    }

    public async Task<Transaction?> Create(Transaction transaction)
    {
        await transactionRepository.AddAsync(transaction);
        return transaction;
    }

    public async Task<Transaction?> Delete(Transaction transaction)
    {
        await transactionRepository.DeleteAsync(transaction);
        return transaction;
    }

    public async Task<Transaction?> Update(int id, Transaction transaction)
    {
        await transactionRepository.UpdateAsync(transaction);
        return transaction;       
    }
}