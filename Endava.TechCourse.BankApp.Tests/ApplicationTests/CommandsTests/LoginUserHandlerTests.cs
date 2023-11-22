using AutoFixture.Idioms;
using Endava.TechCource.BankApp.Application.Commands.LoginUser;

namespace Endava.TechCourse.BankApp.Tests.ApplicationTests.CommandsTests
{
    public class LoginUserHandlerTests
    {
        [Test, ApplicationData]
        public void CanCreateInstance(GuardClauseAssertion assertion)
            => assertion.Verify(typeof(LoginUserHandler).GetConstructors());
    }
}