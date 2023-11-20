using MediatR;

namespace Endava.TechCourse.BankApp.Application.Commands.UpdateCurrency
{
    public class UpdateCurrencyCommand : IRequest<CommandStatus>
    {
        public string Name { get; set; }
        public decimal ChangeRate { get; set; }
        public string CurrencyCode { get; set; }
        public Guid CurrencyId { get; set; }
    }
}