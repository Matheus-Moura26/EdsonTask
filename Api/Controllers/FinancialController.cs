

using Microsoft.AspNetCore.Mvc;
using FinanceManager.Domain.Entities;
using FinanceManager.Application.AppService;
using System.Threading.Tasks;
using FinanceManager.Appilcation.AppService;


namespace Api.Controller.financial;


[ApiController]
[Route("api/[controller]/[action]")]
public class FinancialController(BankingMethod bankingMethod) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<BankingMethod>> CreateBankingMethod(BankingMethod bankingMethod)
    {
        var result = await BankingMethodAppService.Create(bankingMethod);
        return result;
    }



    

    [HttpGet]
    public ActionResult<BankingMethod> GetBakingMethodById(int id)
    {
        var bankingMethod = _BankingMethod.FirstOrDefault(b => b.BankingMethodId == id);

        if (bankingMethod == null)
            return NotFound("BankingMethod não encontrado");

        return Ok(bankingMethod);
    }

    



    [HttpDelete]
    public ActionResult<BankingMethod> DeleteBankingMethod(int id)
    {
        var bankingMethod = _BankingMethod.FirstOrDefault(b => b.BankingMethodId == id);
        if (bankingMethod == null)
            return NotFound("BankingMethod Não encontrado");
        return Ok("BankingMethod Excluído");
    }
}