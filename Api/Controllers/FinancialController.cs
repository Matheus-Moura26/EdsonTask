

using Microsoft.AspNetCore.Mvc;
using FinanceManager.Domain.Entities;
using FinanceManager.Application.AppService;


namespace Api.Controller.financial;


[ApiController]
[Route("api/[controller]/[action]")]
public class FinancialController(PersonAppService personAppService) : ControllerBase
{
   

   
    

    

    [HttpPost]
    public ActionResult<BankingMethod> CreateBankingMethod( BankingMethod bankingMethod)
    {
        bankingMethod.BankingMethodId = _BankingMethod.Count + 1;
        _BankingMethod.Add(bankingMethod);
        return Created();
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