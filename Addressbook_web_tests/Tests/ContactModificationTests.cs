using Addressbook_web_tests;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = (new ContactData("David", "Williams"));
            newData.Middlename = "Jameson";
            newData.Nickname = "Cat";
            newData.Title = "bla-bla-bla";
            newData.Company = "TIR";
            newData.Address = "bla-bla-bla";
            newData.Home = "+475 (18) 338-22-11";
            newData.Mobile = "+7-900-668-36-12";
            newData.Work = "+7-457-989-11-78";
            newData .Fax = "+475 (18) 299-45-61";
            newData.Email = "fluffy_unicorn123@example.com";
            newData.Email2 = "cosmic_pineapple_88@example.com";
            newData.Email3 = "wandering_ninja_99@example.com";
            newData.Homepage = "bla-bla-bla";

            app.Contacts.Modify(1, newData);
        }
    }
}
