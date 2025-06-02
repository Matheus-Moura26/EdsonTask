namespace FinanceManager.Domain.Entities
{

    public class BankAccount
    {
        public int BankAccountId { get; set; }
        public string OwnerPersonId { get; set; }
        public int BankAccountNumber { get; set; }
        public string OwnerFullName { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int CurrentAmount { get; set; }
    }
}