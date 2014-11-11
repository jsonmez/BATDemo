using BATDemoFramework;
using OpenQA.Selenium.Support.PageObjects;

namespace BATDemoFramework
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static AboutPage About
        {
            get { return GetPage<AboutPage>(); }
        }

        public static TopNavigationPage TopNavigation
        {
            get { return GetPage<TopNavigationPage>(); }
        }

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }

        public static ContactPage Contact
        {
            get { return GetPage<ContactPage>(); }
        }

        public static RegisterPage Register
        {
            get { return GetPage<RegisterPage>(); }
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static ManageAccountPage ManageAccount
        {
            get { return GetPage<ManageAccountPage>(); }
        }
    }
}
