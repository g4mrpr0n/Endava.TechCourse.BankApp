namespace Endava.TechCourse.BankApp.Domain.Common
{
    internal class BaseEntity
    {
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime TimeStamp { get; } = DateTime.Now;
    }
}