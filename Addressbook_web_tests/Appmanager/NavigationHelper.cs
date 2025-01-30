using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {
        public string baseURL;

        public NavigationHelper(IWebDriver driver, string baseURL) : base(driver)
        {
        }
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
        public void GoToContactPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
        public void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
        public void ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }
        public void ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
        }
    }
}
