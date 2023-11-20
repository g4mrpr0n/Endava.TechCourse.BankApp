using Endava.TechCourse.BankApp.Domain.Models;
using MediatR;

namespace Endava.TechCourse.BankApp.Application.Commands.UpdateWallet
{
    public class UpdateWalletCommand : IRequest<CommandStatus>
    {
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public string Type { get; set; }
        public Guid CurrencyId { get; set; }
        public Guid WalletId { get; set; }
    }
}