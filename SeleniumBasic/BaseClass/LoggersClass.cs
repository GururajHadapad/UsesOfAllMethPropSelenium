using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBasic.BaseClass
{
    public class LoggersClass
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void openBrowser() 
        {
        driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
        }
        [OneTimeTearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }

    }
}
