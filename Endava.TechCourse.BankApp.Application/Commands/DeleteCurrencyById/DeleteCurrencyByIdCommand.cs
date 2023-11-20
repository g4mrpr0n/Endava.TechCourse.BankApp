using Endava.TechCourse.BankApp.Application.Commands;
using MediatR;

namespace Endava.TechCource.BankApp.Application.Commands.DeleteCurrencyById
{
    public class DeleteCurrencyByIdCommand : IRequest<CommandStatus>
    {
        public Guid Id { get; set; }
    }
}