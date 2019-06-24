using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SampleCsharpProject.PageObjects;
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
            var folderpath = System.IO.Directory.GetCurrentDirectory();
            driver = new ChromeDriver(folderpath);
            //driver.Url = "https://stg2.quantumportal.com.au/prweb";
            //var url = ConfigurationManager.AppSettings["URL"];
            //var folderPath = ConfigurationManager.AppSettings["FolderPath"];
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void Test()
        {
            //driver.Url = ConfigurationManager.AppSettings["URL"];
            driver.Url = "https://stg2.quantumportal.com.au/prweb"; 

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
