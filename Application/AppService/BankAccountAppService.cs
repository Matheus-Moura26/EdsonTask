using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceManager.Repository.Repositories;
using FinanceManager.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace FinanceManager.Application.AppService;

public class BankAccountAppService(BankAccountRepository bankAccountRepository)
{
    public async Task<BankAccount?> Get(int id)
    {
        var result = await bankAccountRepository.GetByIdAsync(id);
        return result;
    }

    public async Task<BankAccount?> Create(BankAccount bankAccount)
    {
        await bankAccountRepository.AddAsync(bankAccount);
        return await bankAccountRepository.GetByIdAsync(bankAccount.BankAccountId);
    }

    public async Task<BankAccount?> Delete(int id)
    {
        var result = await bankAccountRepository.GetByIdAsync(id);
        await bankAccountRepository.DeleteAsync(result);
        return result;
    }

    public async Task<BankAccount?> Update(int id, BankAccount bankAccount)
    {
        await bankAccountRepository.UpdateAsync(bankAccount);
        return bankAccount;
    }
}