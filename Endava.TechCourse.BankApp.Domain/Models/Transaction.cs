using Endava.TechCourse.BankApp.Domain.Common;

namespace Endava.TechCourse.BankApp.Domain.Models
{
    public class Transaction : BaseEntity
    {
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public Wallet FromWallet { get; set; }
        public Wallet ToWallet { get; set; }
    }
}