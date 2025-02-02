using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class HelperBase
    {
        protected IWebDriver driver;
        protected ApplicftionManager manager;

        public HelperBase(ApplicftionManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }
    }
}