using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Addressbook_web_tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

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
