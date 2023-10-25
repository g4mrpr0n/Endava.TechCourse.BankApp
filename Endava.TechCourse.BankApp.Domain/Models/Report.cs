using Endava.TechCourse.BankApp.Domain.Common;

namespace Endava.TechCourse.BankApp.Domain.Models
{
    public class Report : BaseEntity
    {
        public List<Transaction> Transactions { get; set; }
        public decimal TotalAmount { get; set; }
        public Wallet Wallet { get; set; }
        public Currency Currency { get; set; }
    }
}