using BATDemoFramework.Generators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BATDemoFramework
{
    public class ManageAccountPage
    {
        [FindsBy(How = How.Id, Using = "currentPassword")]
        private IWebElement currentPasswordTextField;

        [FindsBy(How = How.Id, Using = "newPassword")]
        private IWebElement newPasswordTextField;

        [FindsBy(How = How.Id, Using = "confirmPassword")]
        private IWebElement confirmPasswordTextField;

        [FindsBy(How = How.CssSelector, Using = "button[type='submit']")]
        private IWebElement changePasswordButton;


        public void Goto()
        {
            Pages.TopNavigation.ManageAccount();
        }

        public void ChangePassword()
        {
            currentPasswordTextField.SendKeys(UserGenerator.LastGeneratedUser.Password);
            newPasswordTextField.SendKeys(PasswordGenerator.Generate());
            confirmPasswordTextField.SendKeys(PasswordGenerator.LastGeneratedPassword);

            changePasswordButton.Click();
        }
    }
}