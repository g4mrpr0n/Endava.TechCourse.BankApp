using Endava.TechCourse.BankApp.Domain.Models;
using MediatR;

namespace Endava.TechCourse.BankApp.Application.Queries.GetAllCurrencies
{
    public class GetAllCurrenciesQuery : IRequest<IEnumerable<Currency>>
    {
    }
}