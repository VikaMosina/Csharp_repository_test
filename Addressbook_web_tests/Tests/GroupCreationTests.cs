using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreation()
        {
            app.Navigation.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigation.GoToGroupsPage();
            app.Groups.InitNewGroupCreation();
            GroupData group = (new GroupData("a"));
            group.Header = "b";
            group.Footer = "c";
            app.Groups.FillGroupForm(group);
            app.Groups.SubmitGroupCreation();
            app.Navigation.ReturnToGroupsPage();
        }
    }
}
