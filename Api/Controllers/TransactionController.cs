
using FinanceManager.Application.AppService;
using Microsoft.AspNetCore.Mvc;
using FinanceManager.Domain.Entities;

namespace Api.Controllers.Transactions;

[ApiController]
[Route("api/[controller]/[action]")]

public class TransactionController(TransactionAppService transactionAppService) : ControllerBase
{
    [HttpGet]
    public  async Task<ActionResult<Transaction>> GetTransactionById(int id)
    {
        var transaction = await transactionAppService.Get(id);

        if (transaction == null)
            return NotFound("Transação não encontrada");

        return Ok(transaction);
    }

    [HttpPost]
    public async Task<ActionResult<Transaction>> CreateTransaction( Transaction transaction)
    {
        var result = await transactionAppService.Create(transaction);

        return Ok(result);
    }


    [HttpDelete]
    public async Task<ActionResult> DeleteTransaction(int id)
    {
        var deletarPessoa = await transactionAppService.Delete(id);
        var pessoaDeletada = await transactionAppService.Get(id);
        if (pessoaDeletada == null)
            return Ok("Pessoa Deletada com Sucesso");
        return BadRequest("Exclusão não realizada");
    }

    [HttpPut]
    public async Task<ActionResult<Transaction>> UpdateTransaction(int id, Transaction transaction)
    {
        var result = await transactionAppService.Update(id, transaction);
        if (result == null)
            return NotFound("Não encontrado");
        return Ok(result);
    }
}
