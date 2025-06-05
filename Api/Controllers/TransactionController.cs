
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
    public async Task<ActionResult<Transaction>> CreateTransaction([FromBody] Transaction transaction)
    {
        var result = await transactionAppService.Create(transaction);
        return CreatedAtAction(
            nameof(GetTransactionById),
            new { id = result.TransactionId },
            result
        );
    }


    [HttpDelete]
    public async Task<ActionResult> DeleteTransaction(int id)
    {
        var result = await transactionAppService.Delete(id);
        return Ok("Pessoa Deletada com Sucesso");
    }

    [HttpPut]
    public async Task<ActionResult<Transaction>> UpdateTransaction(int id, [FromBody] Transaction transaction)
    {
        var result = await transactionAppService.Update(id, transaction);
        return Ok(result);
    }
}
