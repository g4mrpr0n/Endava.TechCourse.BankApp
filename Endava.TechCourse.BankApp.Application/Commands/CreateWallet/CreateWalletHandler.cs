using Endava.TechCourse.BankApp.Domain.Models;
using Endava.TechCourse.BankApp.Infrastructure.Persistence;
using Endava.TechCourse.BankApp.Shared.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Endava.TechCourse.BankApp.Application.Commands.CreateWallet
{
    public class CreateWalletHandler : IRequestHandler<CreateWalletCommand, CommandStatus>
    {
        private readonly ApplicationDbContext context;

        public CreateWalletHandler(ApplicationDbContext context)
        {
            ArgumentNullException.ThrowIfNull(context);

            this.context = context;
        }

        public async Task<CommandStatus> Handle(CreateWalletCommand request, CancellationToken cancellationToken)
        {
            var currency = await context.Currencies.FirstOrDefaultAsync(x => x.CurrencyCode == request.Currency, cancellationToken);

            if (currency is null)
                return CommandStatus.Failed("Valuta pentru acest portofel nu exista");

            var newWallet = new Wallet()
            {
                Currency = request.Currency,
                ChangeRate = currency.ChangeRate,
                WalletType = (WalletType)new Random().Next(0, 4),
            };

            await context.Wallets.AddAsync(newWallet, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);

            return new CommandStatus();
        }

        /*
        private string GenerateUniqueDigitsFromGuid()
        {
            Guid guid = Guid.NewGuid();
            // Convert the first 8 characters of the GUID to a 32-bit integer
            int numericValue = BitConverter.ToInt32(guid.ToByteArray(), 0);
            // Ensure the value is non-negative (take absolute value)
            numericValue = Math.Abs(numericValue);
            // Convert to a string with 16 digits
            string uniqueDigits = numericValue.ToString("D16");

            return uniqueDigits;
        }
        */
    }
}