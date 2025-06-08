

using Microsoft.AspNetCore.Mvc;
using FinanceManager.Domain.Entities;
using FinanceManager.Application.AppService;
using System.Threading.Tasks;


namespace Api.Controllers.BankingMethods;


[ApiController]
[Route("api/[controller]/[action]")]
public class FinancialController(BankingMethodAppService bankingMethodAppService) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<BankingMethod?>> CreateBankingMethod(BankingMethod bankingMethod)
    {
        var result = await bankingMethodAppService.Create(bankingMethod);
        return result;
    }

    [HttpGet]
    public async Task<ActionResult<BankingMethod?>> GetBakingMethodById(int id)
    {
        return await bankingMethodAppService.Get(id);
    }


    [HttpPut]
    public async Task<ActionResult<BankingMethod?>> UpdateBankingMethod(BankingMethod bankingMethod)
    {
        var result = await bankingMethodAppService.Update(bankingMethod);
        return Ok(bankingMethod);      
    }


    [HttpDelete]
    public async Task<ActionResult<BankingMethod?>> DeleteBankingMethod(int id)
    {
        await bankingMethodAppService.Delete(id);
        return Ok();
    }
}