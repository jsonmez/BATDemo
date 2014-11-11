namespace BATDemoFramework
{
    public class ContactPage
    {
        public void Goto()
        {
            Pages.TopNavigation.Contact();
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Contact");
        }
    }
}