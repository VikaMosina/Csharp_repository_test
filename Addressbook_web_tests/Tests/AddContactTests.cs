using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AddContactTests : TestBase
    {
        [Test]
        public void ContactCreation()
        {
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

            app.Contacts.Create(contact);;
        }
        
        [Test]
        public void EmptyContactCreation()
        {

            ContactData contact = (new ContactData("", ""));
            contact.Middlename = "";
            contact.Nickname = "";
            contact.Title = "";
            contact.Company = "";
            contact.Address = "";
            contact.Home = "";
            contact.Mobile = "";
            contact.Work = "";
            contact.Fax = "";
            contact.Email = "";
            contact.Email2 = "";
            contact.Email3 = "";
            contact.Homepage = "";

            app.Contacts.Create(contact);
        }

    }
}

