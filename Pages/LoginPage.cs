using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using System;


namespace SampleCsharpProject.PageObjects
{
    class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        // -------------------Elements-----------------------
        public IWebElement UserName => driver.FindElement(By.Id("txtUserID"));

        public IWebElement Password => driver.FindElement(By.Id("txtPassword"));

        private IWebElement LoginButton => driver.FindElement(By.Id("sub"));
        
        //-------------Methods-------------------

       public LoginPage EnterUserName(String username)
        {
            UserName.SendKeys(username);
            return this;
        }

        public LoginPage EnterPassword(String password)
        {
            Password.SendKeys(password);
            return this;
        }

        public LoginPage ClickLoginButton()
        {
            LoginButton.Click();
            return this;
        }
    }
}
