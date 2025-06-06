using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceManager.Domain.Entities;
using FinanceManager.Repository.Repositories;

namespace FinanceManager.Appilcation.AppService;

public class BankingMethodAppService(BankingMethodRepository bankingMethodRepository)
{
    public async Task<BankingMethod> Create(BankingMethod bankingMethod)
    {
        await bankingMethodRepository.AddAsync(bankingMethod);
        return bankingMethod;
    }

    public async Task<BankingMethod?> Get(int id)
    {
        var result = await bankingMethodRepository.GetByIdAsync(id);
        return result;
    }

    public async Task<BankingMethod?> Delete(int id)
    {
        var result = await bankingMethodRepository.GetByIdAsync(id);
        await bankingMethodRepository.DeleteAsync(result);
        return result;
    }

    

}