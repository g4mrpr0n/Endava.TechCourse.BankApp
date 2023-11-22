using AutoFixture.Idioms;
using Endava.TechCourse.BankApp.Application.Commands.TransferFunds;

namespace Endava.TechCourse.BankApp.Tests.ApplicationTests.CommandsTests
{
    public class TransferFundsHandlerTests
    {
        [Test, ApplicationData]
        public void CanCreateInstance(GuardClauseAssertion assertion)
           => assertion.Verify(typeof(TransferFundsHandler).GetConstructors());
    }
}