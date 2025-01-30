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

        }

            [TearDown]
            public void TeardownTest()
            {
            app.Stop();
            }
    }
  }
