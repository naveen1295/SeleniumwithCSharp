using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seleniumwithcsharp.Browsers
{
    class Browser
    {
        private static IWebDriver driver;
        private static string baseurl = "https://stg2.quantumportal.com.au/prweb";
        private static string browser = "Chrome";
        

        public static void Init()
        {
            var folderpath = System.IO.Directory.GetCurrentDirectory();
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver(folderpath);
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
            }
            driver.Manage().Window.Maximize();
            Goto(baseurl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static string Title
        {
            get { return driver.Title; }
        }

        public static void Goto(string url)
        {
            driver.Url = url;
        }
        public static void Close()
        {
            driver.Quit();
        }

        public IWebDriver ReturnDriver()
        {
             return driver;
        }
    }
}
