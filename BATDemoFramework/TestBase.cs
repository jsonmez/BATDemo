using BATDemoFramework.Generators;
using NUnit.Framework;

namespace BATDemoFramework
{
    [TestFixture]
    public class TestBase
    {
        [TestFixtureSetUp]
        public static void Initialize()
        {
            Browser.Initialize();
            UserGenerator.Initialize();
        }        

        [TestFixtureTearDown]
        public static void TestFixtureTearDown()
        {
            Browser.Close();
        }

        [TearDown]
        public static void TearDown()
        {
            if(Pages.TopNavigation.IsLoggedIn())
                Pages.TopNavigation.LogOut();

            if(UserGenerator.LastGeneratedUser != null)
                Browser.Goto("Account/DeleteUsers.cshtml");
        }
    }
}
