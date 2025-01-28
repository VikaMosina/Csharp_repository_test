using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Addressbook_web_tests;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AddContactTests : TestBase
    {
        [Test]
        public void TheTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToContactPage();
            ContactData contact = (new ContactData("Vika", "Mosina"));
            contact.Middlename = "Konstantinovna";
            contact.Nickname = "CoolGirl";
            contact.Title = "bla-bla";
            contact.Company = "RIT";
            contact.Address = "bla-bla";
            contact.Home = "+375 (17) 227-46-71";
            contact.Mobile = "+7-900-555-78-90";
            contact.Work = "+7-457-256-89-53";
            contact.Fax = "+375 (17) 227-23-18";
            contact.Email = "cutowok-ale63@list.ru";
            contact.Email2 = "nut_ahadilu36@inbox.ru";
            contact.Email3 = "vok-ofulexo91@inbox.ru";
            contact.Homepage = "bla-bla";
            FillContactForm(contact);
            SubmitContactCreation();
            ReturnToHomePage();
        }
    }
}

