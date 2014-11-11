using BATDemoFramework.Generators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BATDemoFramework
{
    public class RegisterPage
    {

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailAddressTextField;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordTextField;

        [FindsBy(How = How.Id, Using = "confirmPassword")]
        private IWebElement confirmPasswordTextField;

        [FindsBy(How = How.CssSelector, Using = "input[type='submit']")]
        private IWebElement registerButton;

        public void Goto()
        {
            Pages.TopNavigation.Register();
        }

        public void RegisterNewUser()
        {
            var user = UserGenerator.Generate();

            emailAddressTextField.SendKeys(user.EmailAddress);
            passwordTextField.SendKeys(user.Password);
            confirmPasswordTextField.SendKeys(user.Password);

            registerButton.Click();
        }
    }
}
