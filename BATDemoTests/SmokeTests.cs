using BATDemoFramework;
using NUnit.Framework;

namespace BATDemoTests
{
    [TestFixture]
    public class SmokeTests : TestBase
    {
        [Test]
        public void CanGoToAboutPage()
        {
            Pages.About.Goto();
            Assert.IsTrue(Pages.About.IsAt());
        }

        [Test]
        public void CanGoToHomePage()
        {
            Pages.Home.Goto();
            Assert.IsTrue(Pages.Home.IsAt());
        }

        [Test]
        public void CanGoToContactPage()
        {
            Pages.Contact.Goto();
            Assert.IsTrue(Pages.Contact.IsAt());
        }

        [Test]
        public void CanRegisterNewAccount()
        {
            Pages.Register.Goto();
            Pages.Register.RegisterNewUser();
            
            Assert.IsTrue(Pages.TopNavigation.LoggedInAsLastRegisteredUser(), "User not registered successfully");

        }

        [Test]
        public void CanLogIn()
        {
            Pages.Register.Goto();
            Pages.Register.RegisterNewUser();
            Pages.TopNavigation.LogOut();

            Pages.Login.Goto();
            Pages.Login.LogInAsLastRegisteredUser();
            Assert.IsTrue(Pages.TopNavigation.LoggedInAsLastRegisteredUser());
        }

        [Test]
        public void CanLogout()
        {
            // Create a new user
            Pages.Register.Goto();
            Pages.Register.RegisterNewUser();

            // Verify can log out
            Pages.TopNavigation.LogOut();
            Assert.IsFalse(Pages.TopNavigation.IsLoggedIn());
        }

        [Test]
        public void CanChangePassword()
        {
            // Create a new user
            Pages.Register.Goto();
            Pages.Register.RegisterNewUser();

            // Change the password
            Pages.ManageAccount.Goto();
            Pages.ManageAccount.ChangePassword();
            Pages.TopNavigation.LogOut();

            // Try to log in with old password
            Pages.Login.Goto();
            Pages.Login.LogInAsLastRegisteredUser();
            Assert.IsFalse(Pages.TopNavigation.IsLoggedIn());

            // Log in with new password
            Pages.Login.Goto();
            Pages.Login.LogInAsLastRegisteredUser(LoginPage.LoginOptions.UseLastGeneratedPassword);
            Assert.IsTrue(Pages.TopNavigation.IsLoggedIn());
        }
    }


}
