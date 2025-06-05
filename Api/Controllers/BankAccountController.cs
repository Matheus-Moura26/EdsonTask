using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceManager.Application.AppService;
using Microsoft.AspNetCore.Mvc;
using FinanceManager.Domain.Entities;
using FinanceManager.Appilcation.AppService;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Runtime.CompilerServices;


namespace FinanceManager.Api.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class BankAccountController(BankAccountAppService bankAccountAppService) : ControllerBase
{

    [HttpPost]
    public async Task<ActionResult<BankAccount>> CreateBankAccount(BankAccount bankAccount)
    {
        var result = await bankAccountAppService.Create(bankAccount);
        return Ok(result);
    }

    [HttpGet]
    public async Task<ActionResult<BankAccount>> GetBankAccountById(int id)
    {
        return Ok(await bankAccountAppService.Get(id));
    }

    [HttpDelete]
    public async Task<ActionResult<BankAccount>> DeleteBankAccount(int id)
    {
        return Ok(await bankAccountAppService.Delete(id));
    }

    [HttpPut]
    public async Task<ActionResult<BankAccount>> UpdateBankAccount(BankAccount bankAccount)
    {
        var result = await bankAccountAppService.Update(bankAccount.BankAccountId, bankAccount);
        return Ok(result);
    }

}
