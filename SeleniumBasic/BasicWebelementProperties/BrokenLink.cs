using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.BasicWebelementProperties
{
     class BrokenLink
    {
        [Test]
        public void checkBrokenLink()
        {
          IWebDriver driver= new ChromeDriver();
            Thread.Sleep(2000);

            driver.Navigate().GoToUrl("https://www.actitime.com/");
            Thread.Sleep(5000);
         
           // driver.Manage().Window.Maximize();
          driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
          ReadOnlyCollection<IWebElement> alllLinks = driver.FindElements(By.XPath("//a"));
            Console.WriteLine (alllLinks.Count);
            for (int i = 0;i<alllLinks.Count; i++)
            {
            string  url = alllLinks[i].GetAttribute("href");
               Console.WriteLine (url);

                Uri links = new Uri(url);
                
            }
            driver.Quit();
        }
    }
}
