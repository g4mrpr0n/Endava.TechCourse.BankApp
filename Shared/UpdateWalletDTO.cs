namespace Endava.TechCourse.BankApp.Shared
{
    public class UpdateWalletDTO
    {
        public decimal Amount { get; set; }
        public int Pincode { get; set; }
        public string Type { get; set; }
        public Guid CurrencyId { get; set; }
        public Guid WalletId { get; set; }
    }
}