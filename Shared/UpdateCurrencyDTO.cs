namespace Endava.TechCourse.BankApp.Shared
{
    public class UpdateCurrencyDTO
    {
        public string Name { get; set; }
        public decimal ChangeRate { get; set; }
        public string CurrencyCode { get; set; }
        public Guid CurrencyId { get; set; }
    }
}