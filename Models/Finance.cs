namespace FinanceManager.Models
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

    public class Transaction
    {
        public int TransactionId { get; set; }
        public int OriginPersonid { get; set; }
        public int RecipientPersonid { get; set; }
        public int Amount { get; set; }
        public int BankAccountId { get; set; }
        public DateTime AddedOn { get; set; }
        public enum TransactionType {}
    }

    public class BankingMethod
    {
        public int BankingMethodId { get; set; }
        public string BankingMethodName { get; set; }
    }
}