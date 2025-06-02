

using Microsoft.AspNetCore.Mvc;
using FinanceManager.Domain.Entities;


namespace Api.Controller.financial;


[ApiController]
[Route("api/[controller]/[action]")]
public class FinancialController : ControllerBase
{
   

   
    [HttpPost]
    public ActionResult<BankAccount> CreateBankAccount( BankAccount bankAccount)
    {
        bankAccount.BankAccountId = _bankAccount.Count + 1;
        _bankAccount.Add(bankAccount);
        return Created();
    }

    [HttpPost]
    public ActionResult<Transaction> CreateTransacion( Transaction transaction)
    {
        transaction.TransactionId = _transaction.Count + 1;
        _transaction.Add(transaction);
        return Created();
    }

    [HttpPost]
    public ActionResult<BankingMethod> CreateBankingMethod( BankingMethod bankingMethod)
    {
        bankingMethod.BankingMethodId = _BankingMethod.Count + 1;
        _BankingMethod.Add(bankingMethod);
        return Created();
    }

    [HttpGet]
    public ActionResult<BankAccount> GetBankAccountById(int id)
    {
        var account = _bankAccount.FirstOrDefault(a => a.BankAccountId == id);
        if (account == null)
            return NotFound("Conta Bancária não encontrada");
        return Ok(account);
    }

    [HttpGet]
    public ActionResult<BankAccount> GetTransactionById(int id)
    {
        var transaction = _transaction.FirstOrDefault(a => a.TransactionId == id);

        if (transaction == null)
            return NotFound("Transação não encontrada");
        return Ok(transaction);
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
    public ActionResult<BankAccount> DeleteBankAccount(int id)
    {
        var bankAccount = _bankAccount.FirstOrDefault(a => a.BankAccountId == id);

        if (bankAccount == null)
            return NotFound("Banco não encontrado");

        _bankAccount.Remove(bankAccount);

        return Ok("Banco Excluído Com sucesso");
    }

    [HttpDelete]
    public ActionResult<Transaction> DeleteTransaction(int id)
    {
        var transaction = _transaction.FirstOrDefault(a => a.TransactionId == id);
        if (transaction == null)
            return NotFound("Transação não encontrada");
        _transaction.Remove(transaction);
        return Ok("Transação deletada");
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