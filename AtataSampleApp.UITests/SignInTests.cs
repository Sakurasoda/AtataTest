using Atata;
using NUnit.Framework;

namespace AtataSampleApp.UITests
{
    public class SignInTests : UiTestFixture
    {
        [Test]
        public void SignIn()
        {
            Go.To<SignInPage>()
                .Wait(3).Close.Click()
                .Password.Set(Config.Account.Password)
                .Username.Set(Config.Account.UserName)
                .CheckCode.Set(Config.Account.CheckCode)
                .Wait(2)
                .LogMeIn.Click();
        }
    }
}
