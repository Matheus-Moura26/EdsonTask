using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceManager.Domain.Entities
{
   

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
}