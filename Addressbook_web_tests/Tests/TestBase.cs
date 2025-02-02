using NUnit.Framework;

namespace WebAddressbookTests
{
    public class TestBase
    {
        protected ApplicftionManager app;

        [SetUp]
            public void SetupTest()
            {
            app = new ApplicftionManager();

            app.Navigation.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

            [TearDown]
            public void TeardownTest()
            {
            app.Stop();
            }
    }
  }
