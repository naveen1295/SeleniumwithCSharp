using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SampleCsharpProject.PageObjects;
using Seleniumwithcsharp.Browsers;
using System;
using System.Configuration;

namespace SampleCsharpProject.TestCases
{
    class LoginTest
    {

        IWebDriver driver;
        
        [SetUp]
        public void StartBrowser()
        {
            Browser.Init();
            driver = Browser.ReturnDriver();
        }

        [Test]
        public void Test()
        {
            //driver.Url = ConfigurationManager.AppSettings["URL"];
            
            var loginPage = new LoginPage(driver);
          
            loginPage.EnterUserName("bm_test8");
            loginPage.EnterPassword("Pega1234!");
            loginPage.ClickLoginButton();
            //driver.FindElement(By.Id("SelectedDealership")).SendKeys("Quantun Toyota");
            //driver.FindElement(By.XPath("//a[text()='Create']")).Click();
            //driver.FindElement(By.XPath("//span[text()='Quote']")).Click();
        }

        [TearDown]
        public void CloseBrowser()
        {
            // driver.Close();
            driver.Quit();
        }
    }
}
