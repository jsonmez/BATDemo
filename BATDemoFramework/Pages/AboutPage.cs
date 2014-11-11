namespace BATDemoFramework
{
    public class AboutPage
    {
        public void Goto()
        {
            Pages.TopNavigation.About();
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("About");
        }
    }
}