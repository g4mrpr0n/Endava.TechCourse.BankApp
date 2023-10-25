using Endava.TechCourse.BankApp.Domain.Common;

namespace Endava.TechCourse.BankApp.Domain.Models
{
    public class CashByCode : BaseEntity

    {
        public Wallet Wallet { get; set; }
        public Currency Currency { get; set; }
        public decimal Amount { get; set; }
        public uint Code { get; set; }
    }
}