using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceManager.Application.AppService;
using Microsoft.AspNetCore.Mvc;
using FinanceManager.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Runtime.CompilerServices;


namespace FinanceManager.Api.Controllers.BankAccounts;

[ApiController]
[Route("api/[controller]/[action]")]
public class BankAccountController(BankAccountAppService bankAccountAppService) : ControllerBase
{

    [HttpPost]
    public async Task<ActionResult<BankAccount>> CreateBankAccount(BankAccount bankAccount)
    {
        var result = await bankAccountAppService.Create(bankAccount);
        if (result == null)
            return NotFound();
        return Ok(result);
    }

    [HttpGet]
    public async Task<ActionResult<BankAccount>> GetBankAccountById(int id)
    {
        var result = await bankAccountAppService.Get(id);
        if (result == null)
            return NotFound();
        return Ok(result);
    }

    [HttpDelete]
    public async Task<ActionResult<BankAccount>> DeleteBankAccount(int id)
    {

        var result = await bankAccountAppService.Delete(id);
        if (result == null)
            return NotFound();
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult<BankAccount>> UpdateBankAccount(BankAccount bankAccount)
    {
        var result = await bankAccountAppService.Update(bankAccount.BankAccountId, bankAccount);
        if (result == null)
            return NotFound();
        return Ok(result);
    }

}
