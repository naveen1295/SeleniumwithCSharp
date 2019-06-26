using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seleniumwithcsharp.Helpers
{
    class ElementHelpers
    {
        int wait = 5;
        //Enter Text
       public static void EnterValue(IWebElement ielement, String value, String elementname)
        {
            ielement.SendKeys(value);
            
        }
    }
}
