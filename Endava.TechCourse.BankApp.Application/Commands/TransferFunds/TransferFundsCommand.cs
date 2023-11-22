using MediatR;

namespace Endava.TechCourse.BankApp.Application.Commands.TransferFunds
{
    public class TransferFundsCommand : IRequest<CommandStatus>
    {
        public string SourceWalletId { get; set; }
        public string DestinationWalletId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}